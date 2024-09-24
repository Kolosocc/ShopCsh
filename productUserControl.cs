using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Shop
{
    public partial class productUserControl : UserControl
    {
        public productUserControl(Product product)
        {
            InitializeComponent();
            string imagePath = product.Path;
            if (File.Exists(imagePath))
            {
                pictureBox1.Image = Image.FromFile(imagePath);
            }
            else
            {
                string projectPath = System.IO.Path.GetFullPath(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\.."));
                imagePath = System.IO.Path.Combine(projectPath, "img", "default.png");
                pictureBox1.Image = Image.FromFile(imagePath);
            }


            NameLabel.Text = product.Name;
            DesLabel.Text = product.Description;
            ProdLabel.Text = product.Manufacturer.Name;
            PriceLabel.Text = product.Price.ToString();
            QuanLabel.Text = product.Quantity.ToString();
            if (product.Quantity > 0)
            {
                this.BackColor = Color.AliceBlue;
            }
            else
            {
                this.BackColor = Color.LightGray;
            }

        }

    }
}
