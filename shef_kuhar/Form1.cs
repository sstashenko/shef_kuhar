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
        private Inventory<Product> inventory; // список продуктів
        private List<Recipe> recipes; // Список рецептів
        private DataManager dataManager; // Менеджер даних

        public Form1()
        {
            InitializeComponent(); // Ініціалізуємо компоненти форми
            dataManager = new DataManager(); // Створюємо новий екземпляр DataManager
            recipes = dataManager.LoadRecipesFromXml("recipes.xml"); // Завантажуємо рецепти з XML файлу
            var products = dataManager.LoadProductsFromXml("products.xml"); // Завантажуємо продукти з XML файлу
            inventory = new Inventory<Product>(); // Створюємо інвентар для продуктів
            foreach (var product in products)
            {
                inventory.AddItem(product); // Додаємо продукти в інвентар за допомогою методу AddItem
            }
        }

        private void управлінняРецептамиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var recipeForm = new RecipeForm(recipes); // Створюємо нову форму для управління рецептами
            recipeForm.Show(); // Відкриваємо форму
        }

        private void управлінняПродуктамиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Приклад створення інвентаря
            var productInventory = new Inventory<Product>(); // Створюємо інвентар для продуктів
            var recipeInventory = new RecipeInventory(); // Змінюємо на RecipeInventory
            var recipes = new List<Recipe>(); // Створюємо список рецептів

            // Створюємо екземпляр ProductForm
            var productForm = new ProductForm(productInventory); // Передаємо інвентар продуктів до ProductForm
            productForm.Show(); // Відкриваємо форму
        }

        private void менюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Приклад створення інвентаря
            var productInventory = new Inventory<Product>(); // Створюємо інвентар для продуктів
            var recipeInventory = new RecipeInventory(); // Створюємо інвентар для рецептів

            // Завантаження рецептів з XML
            var dataManager = new DataManager(); // Створюємо новий екземпляр DataManager
            var recipes = dataManager.LoadRecipesFromXml("recipes.xml"); // Завантажуємо рецепти з XML

            // Тепер створюємо екземпляр MenuForm, передаючи правильні аргументи
            var menuForm = new MenuForm(productInventory, recipeInventory, recipes); // Створюємо форму меню
            menuForm.Show(); // Відкриваємо форму
        }

        private void вихідToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Закриваємо додаток
        }

    }
}
