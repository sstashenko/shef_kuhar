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
    public partial class Form1 : Form
    {
        private Inventory<Product> inventory; 
        private List<Recipe> recipes; 
        private DataManager dataManager; 

        public Form1()
        {
            InitializeComponent(); 
            dataManager = new DataManager(); 
            recipes = dataManager.LoadRecipesFromXml("recipes.xml"); 
            var products = dataManager.LoadProductsFromXml("products.xml"); 
            inventory = new Inventory<Product>(); 
            foreach (var product in products)
            {
                inventory.AddItem(product); 
            }
        }

        private void управлінняРецептамиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var recipeForm = new RecipeForm(recipes); 
            recipeForm.Show(); 
        }

        private void управлінняПродуктамиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            var productInventory = new Inventory<Product>(); 
            var recipeInventory = new RecipeInventory();
            var recipes = new List<Recipe>();

            var productForm = new ProductForm(productInventory); 
            productForm.Show(); 
        }

        private void менюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            var productInventory = new Inventory<Product>(); 
            var recipeInventory = new RecipeInventory(); 

            
            var dataManager = new DataManager(); 
            var recipes = dataManager.LoadRecipesFromXml("recipes.xml"); 

            var menuForm = new MenuForm(productInventory, recipeInventory, recipes);
            menuForm.Show(); 
        }

        private void вихідToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

    }
}
