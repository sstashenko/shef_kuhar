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
    public partial class MenuForm : Form
    {
        private Inventory<Product> productInventory;
        private RecipeInventory recipeInventory;
        private List<Recipe> recipes;

        public MenuForm(Inventory<Product> productInventory, RecipeInventory recipeInventory, List<Recipe> recipes)
        {
            InitializeComponent();
            this.productInventory = productInventory;
            this.recipeInventory = recipeInventory;
            this.recipes = recipes;
            LoadRecipes();
        }

        private void LoadRecipes()
        {
            foreach (var recipe in recipes)
            {
                recipesComboBox.Items.Add(recipe.Name);
            }

             recipesDataGridView.DataSource = recipes;
        }



        private void recipesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedRecipeName = recipesComboBox.SelectedItem.ToString();
            var recipe = recipes.FirstOrDefault(r => r.Name == selectedRecipeName);
            if (recipe != null)
            {
                var recipeDetails = new List<Recipe> { recipe };
                recipesDataGridView.DataSource = recipeDetails;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            // Якщо чекбокс вибрано, фільтруємо рецепти
            if (checkBox1.Checked)
            {
                // Отримуємо всі рецепти, що готуються 15 хвилин або менше
                var filteredRecipes = recipes.Where(r => r.PreparationTime <= 1).ToList();
                recipesDataGridView.DataSource = filteredRecipes; // Оновлюємо джерело даних для відображення
            }
            else
            {
                // Якщо чекбокс не вибрано, відображаємо всі рецепти
                recipesDataGridView.DataSource = recipes; // Встановлюємо джерело даних на всі рецепти
            }
        }

        private void showAllButton_Click(object sender, EventArgs e)
        {
            recipesDataGridView.DataSource = recipes; // Встановлюємо джерело даних на всі рецепти

        }
    }

}
