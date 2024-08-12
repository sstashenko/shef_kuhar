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
    public partial class RecipeForm : Form
    {
        private List<Recipe> recipes;

        public RecipeForm(List<Recipe> recipes)
        {
            InitializeComponent();
            this.recipes = recipes;
        }




        private void button1_Click(object sender, EventArgs e)
        {
 
            var recipe = new Recipe(
                nameTextBox.Text,
    ingredientsTextBox.Text,
    instructionsTextBox.Text,
    (double)preparationTimeNumericUpDown.Value,
    (int)servingsNumericUpDown.Value 
            );

            recipes.Add(recipe);

            DataManager dataManager = new DataManager();
            dataManager.SaveRecipesToXml(recipes, "recipes.xml");

            MessageBox.Show("Recipe added and saved successfully!");
        }


        private void viewButton_Click_1(object sender, EventArgs e)
        {
            var viewForm = new ViewRecipesForm(recipes);
            viewForm.Show();
        }
    }
}
