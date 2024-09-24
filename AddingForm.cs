using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shop
{
    public partial class AddingForm : Form
    {
        public event EventHandler<string>? ManufacturerAdded;

        public AddingForm()
        {
            InitializeComponent();
        }

        private void AddingButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(NameBox.Text) ||
                string.IsNullOrEmpty(DescBox.Text) ||
                string.IsNullOrEmpty(ImageBox.Text) ||
                string.IsNullOrEmpty(ProdBox.Text) ||
                string.IsNullOrEmpty(PriceBox.Text) ||
                string.IsNullOrEmpty(QuanBox.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            double price;
            if (!double.TryParse(PriceBox.Text, out price))
            {
                MessageBox.Show("Price must be a valid number.");
                return;
            }

            int quantity;
            if (!int.TryParse(QuanBox.Text, out quantity))
            {
                MessageBox.Show("Quantity must be a valid integer.");
                return;
            }

            string manufacturerName = ProdBox.Text;
            Manufacturer? manufacturer;
            using (var context = new MyDbContext())
            {
                manufacturer = context.Manufacturers.FirstOrDefault(m => m.Name == manufacturerName);


                if (manufacturer == null)
                {
                    manufacturer = new Manufacturer { Name = manufacturerName };
                    context.Manufacturers.Add(manufacturer);
                }

                string productName = NameBox.Text;
                bool productExists = context.Products.Any(p => p.Name == productName);

                if (productExists)
                {
                    MessageBox.Show("A product with this name already exists.");
                    return;
                }

                Product product = new Product
                {
                    Name = productName,
                    Description = DescBox.Text,
                    Path = ImageBox.Text,
                    Price = price,
                    Manufacturer = manufacturer,
                    Quantity = quantity
                };

                context.Products.Add(product);

                try
                {
                    context.SaveChanges();
                    MessageBox.Show("Product added successfully.");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
            }
        }

        private void SelectPathButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedPath = openFileDialog.FileName;
                ImageBox.Text = selectedPath;
            }
        }
    }
}