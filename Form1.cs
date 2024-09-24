using Microsoft.EntityFrameworkCore;
using System.Drawing.Printing;
using System.Windows.Forms;
using Shop;
using System.Text;
using System.Security.Cryptography;
using Azure;

namespace Shop
{
    public partial class Form1 : Form
    {
        private List<Product> filteredProducts;
        private int currentPage = 1;
        private int productsPerPage = 5;
        private int totalPages = 1;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (var context = new MyDbContext())
            {
                context.Database.EnsureCreated();
                var products = context.Products.Include(p => p.Manufacturer).ToList();

                foreach (var product in products)
                {
                    var productControl = new productUserControl(product);
                    flowLayoutPanel1.Controls.Add(productControl);
                }
                ProdFiltBox.Items.Clear();
                ProdFiltBox.Items.Add("Все");
                ProdFiltBox.SelectedIndex = 0;
                foreach (var manufacturer in context.Manufacturers)
                {
                    ProdFiltBox.Items.Add($"{manufacturer.Name}");
                }
            }
            SortBox.Items.Add("Название ↑");
            SortBox.Items.Add("Цена ↑");
            SortBox.Items.Add("Цена ↓");
            SortBox.Items.Add("Количество ↑");
            SortBox.Items.Add("Количество ↓");
            SortBox.Items.Add("Производитель ↑");

            UpdatePageLabel();
        }

        private void LoadProducts()
        {
            using (var context = new MyDbContext())
            {
                var query = context.Products.Include(p => p.Manufacturer).AsQueryable();

                if (ProdFiltBox.SelectedIndex > 0)
                {
                    string selectedManufacturer = ProdFiltBox.SelectedItem.ToString();
                    query = query.Where(p => p.Manufacturer.Name == selectedManufacturer);
                }

                string searchTerm = FindBox.Text.Trim();
                if (!string.IsNullOrEmpty(searchTerm))
                {
                    query = query.Where(p => p.Name.Contains(searchTerm));
                }

                string sortField = SortBox.SelectedItem?.ToString();
                switch (sortField)
                {
                    case "Название ↑":
                        query = query.OrderBy(p => p.Name);
                        break;
                    case "Цена ↑":
                        query = query.OrderBy(p => p.Price);
                        break;
                    case "Цена ↓":
                        query = query.OrderByDescending(p => p.Price);
                        break;
                    case "Количество ↑":
                        query = query.OrderBy(p => p.Quantity);
                        break;
                    case "Количество ↓":
                        query = query.OrderByDescending(p => p.Quantity);
                        break;
                    case "Производитель ↑":
                        query = query.OrderBy(p => p.Manufacturer.Name);
                        break;
                    default:
                        query = query.OrderBy(p => p.Name);
                        break;
                }

                
                int productCount = query.Count();
                totalPages = (int)Math.Ceiling((double)productCount / productsPerPage);
                

                if (currentPage > totalPages)
                {
                    currentPage = totalPages;
                }

                int skipAmount = (currentPage - 1) * productsPerPage;
                query = query.Skip(skipAmount).Take(productsPerPage);

                filteredProducts = query.ToList();

                flowLayoutPanel1.Controls.Clear();

                foreach (var product in filteredProducts)
                {
                    var productControl = new productUserControl(product);
                    flowLayoutPanel1.Controls.Add(productControl);
                }

                
                UpdatePageLabel();
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ProdFiltBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentPage = 1; 
            LoadProducts();
        }

        private void SortBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentPage = 1; 
            LoadProducts();
        }

        private void FindBox_TextChanged(object sender, EventArgs e)
        {
            currentPage = 1; 
            LoadProducts();
        }

        private void AddingButton_Click(object sender, EventArgs e)
        {
            AddingForm addingForm = new AddingForm();
            addingForm.ShowDialog();
            LoadProducts();
            using (var context = new MyDbContext())
            {
                ProdFiltBox.Items.Clear();
                ProdFiltBox.Items.Add("Все");
                ProdFiltBox.SelectedIndex = 0;

                foreach (var manufacturer in context.Manufacturers)
                {
                    ProdFiltBox.Items.Add($"{manufacturer.Name}");
                }
            }
        }

        private void PreviousButton_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage--;
                LoadProducts();
            }
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            using (var context = new MyDbContext())
            {
                if (currentPage < totalPages)
                {
                    currentPage++;
                    LoadProducts();
                }
            }
        }

        private void AddingStandartButton_Click(object sender, EventArgs e)
        {
            string projectPath = System.IO.Path.GetFullPath(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\.."));
            string heshName = GenerateTimeBasedHash();
            using (var context = new MyDbContext())
            {
                Manufacturer? defaultManufacturer = context.Manufacturers.FirstOrDefault(m => m.Name == "Default Manufacturer");
                if (defaultManufacturer == null)
                {
                    string manufacturerName = "Default Manufacturer" + heshName;
                    defaultManufacturer = new Manufacturer { Name = manufacturerName };
                    context.Manufacturers.Add(defaultManufacturer);
                    context.SaveChanges();
                }

                var productsToAdd = new List<Product>
                {
                    new Product
                    {
                        Name = "Jacket" + heshName,
                        Description = "Stylish winter jacket.",
                        Path = System.IO.Path.Combine(projectPath, "img", "jacket.png"),
                        Price = 49.99,
                        Quantity = 10,
                        Manufacturer = defaultManufacturer
                    },
                    new Product
                    {
                        Name = "Phone" + heshName,
                        Description = "Latest smartphone model.",
                        Path = System.IO.Path.Combine(projectPath, "img", "phone.png"),
                        Price = 699.99,
                        Quantity = 5,
                        Manufacturer = defaultManufacturer
                    },
                    new Product
                    {
                        Name = "T-Shirt" + heshName,
                        Description = "Comfortable cotton t-shirt.",
                        Path = System.IO.Path.Combine(projectPath, "img", "T-short.png"),
                        Price = 19.99,
                        Quantity = 20,
                        Manufacturer = defaultManufacturer
                    }
                };

                foreach (var product in productsToAdd)
                {
                    bool productExists = context.Products.Any(p => p.Name == product.Name);
                    if (!productExists)
                    {
                        context.Products.Add(product);
                    }
                    else
                    {
                        MessageBox.Show($"Product '{product.Name}' already exists.");
                    }
                }

                try
                {
                    context.SaveChanges();
                    MessageBox.Show("Standard products added successfully.");
                    LoadProducts();
                }
                catch (DbUpdateException dbEx)
                {
                    string errorMessage = $"An error occurred while adding products: {dbEx.Message}";
                    if (dbEx.InnerException != null)
                    {
                        errorMessage += $"\nInner exception: {dbEx.InnerException.Message}";
                    }
                    MessageBox.Show(errorMessage);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An unexpected error occurred: {ex.Message}");
                }
            }
        }

        
        private void UpdatePageLabel()
        {
            PageLabel.Text = $"Страница {currentPage} из {totalPages}";
        }

        private string GenerateTimeBasedHash()
        {
            string timeStamp = DateTime.Now.ToString("yyyyMMddHHmmssfff");
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(timeStamp));
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString().Substring(0, 4).ToUpper();
            }
        }
    }
}
