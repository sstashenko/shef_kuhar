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
    public partial class ViewProductsForm : Form
    {
        private List<Product> products;  
        private DataManager dataManager;

        public ViewProductsForm(List<Product> products)
        {
            InitializeComponent();
            this.products = products;
            dataManager = new DataManager();

            // Завантаження даних при відкритті форми
            LoadProducts();
        }

        private void LoadProducts()
        {
            products = dataManager.LoadProductsFromXml("products.xml");
            dataGridViewProducts.DataSource = products; // Встановлення джерела даних для DataGridView
        }

     

         
    }
}
