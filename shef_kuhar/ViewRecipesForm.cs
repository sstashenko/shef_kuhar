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
    public partial class ViewRecipesForm : Form
    {
        private List<Recipe> recipes;
        private DataManager dataManager;

        public ViewRecipesForm(List<Recipe> recipes)
        {
            InitializeComponent();
            this.recipes = recipes;
            dataManager = new DataManager();

            
            LoadRecipes();
        }

        private void LoadRecipes()
        {
            recipes = dataManager.LoadRecipesFromXml("recipes.xml");
            dataGridViewRecipes.DataSource = recipes; 

        }


    }
}
