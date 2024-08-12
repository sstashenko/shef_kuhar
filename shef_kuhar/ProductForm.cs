using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace shef_kuhar
{
    public partial class ProductForm : Form
    {
        private Inventory<Product> inventory; 
        private DataManager dataManager;

        public ProductForm(Inventory<Product> inventory) 
        {
            InitializeComponent();
            this.inventory = inventory;
            dataManager = new DataManager();
        }



        private void addButton_Click_1(object sender, EventArgs e)
        {
            var product = new Product(
         nameTextBox.Text,
         (double)priceNumericUpDown.Value,
         (int)quantityNumericUpDown.Value
     );

            inventory.AddItem(product); 

            dataManager.SaveProductsToXml(inventory.GetItems().ToList(), "products.xml"); 
            MessageBox.Show("Product added and saved successfully!");

        }

        private void viewButton_Click_1(object sender, EventArgs e)
        {
            var viewForm = new ViewProductsForm(inventory.GetItems().ToList()); 
            viewForm.Show();
        }
    }

}
