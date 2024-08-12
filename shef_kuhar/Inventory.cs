using shef_kuhar;
using shef_kuhar.Properties;
using System;
using System.Collections.Generic;
using System.Linq;

namespace shef_kuhar
{ 

    public class Inventory<T> where T : FoodItem
    {
        private List<T> items;

        public Inventory()
        {
            items = new List<T>();
        }

        public void AddItem(T item)
        {
            items.Add(item);
        }
        public IEnumerable<T> GetItems() 
        {
            return items.AsReadOnly();
        }
        public void AddItemFromInput()
        {
            Console.WriteLine("Введіть ціну:");
            string name = Console.ReadLine();

            Console.WriteLine("Введите цену:");
            double price = Convert.ToDouble(Console.ReadLine());

            if (typeof(T) == typeof(Product))
            {
                Console.WriteLine("Введіть кількість:");
                int quantity = Convert.ToInt32(Console.ReadLine());
                AddItem((T)(object)new Product(name, price, quantity));
            }
            else if (typeof(T) == typeof(Recipe))
            {
                Console.WriteLine("Введіть інгредієнти:");
                string ingredients = Console.ReadLine(); 
                Console.WriteLine("Введіть інструкції:");
                string instructions = Console.ReadLine(); 
                Console.WriteLine("Введіть кількість порцій:");
                int servings = Convert.ToInt32(Console.ReadLine()); 
                AddItem((T)(object)new Recipe(name, ingredients, instructions, price, servings)); 
            }
        }

        public void PrintInventory()
        {
            foreach (var item in items)
            {
                item.DisplayInfo();
            }
        }
    }


}

public class Inventory<T> where T : FoodItem
{
    private List<T> items;

    public Inventory()
    {
        items = new List<T>();
    }

  
    public void AddItem(T item) 
    {
        items.Add(item);
    }

    public IEnumerable<T> GetItems() 
    {
        return items.AsReadOnly();
    }
    public void PrintInventory()
    {
        foreach (var item in items)
        {
            item.DisplayInfo();
        }
    }
}


public class RecipeInventory
{
    private List<Recipe> recipes;

    public RecipeInventory()
    {
        recipes = new List<Recipe>();
    }

    public void AddRecipe(Recipe recipe)
    {
        recipes.Add(recipe);
    }

    public void PrintRecipes()
    {
        foreach (var recipe in recipes)
        {
            recipe.PrintRecipe();
        }
    }
}
