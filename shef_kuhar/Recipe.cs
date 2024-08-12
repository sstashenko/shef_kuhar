using System;

namespace shef_kuhar
    public class Recipe : IComparable<Recipe>
    {
        private string name;
        private string ingredients;
        private string instructions;
        private double preparationTime;
        private int servings;

         public Recipe() : this("Unknown Recipe", "No ingredients", "No instructions", 0.0, 1) { }

         public Recipe(string name, string ingredients, string instructions, double preparationTime, int servings)
        {
            this.name = name;
            this.ingredients = ingredients;
            this.instructions = instructions;
            this.preparationTime = preparationTime;
            this.servings = servings;
        }

         public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Ingredients
        {
            get { return ingredients; }
            set { ingredients = value; }
        }

        public string Instructions
        {
            get { return instructions; }
            set { instructions = value; }
        }

        public double PreparationTime
        {
            get { return preparationTime; }
            set { preparationTime = value; }
        }

        public int Servings
        {
            get { return servings; }
            set { servings = value; }
        }

        public int CompareTo(Recipe other)
        {
            return this.preparationTime.CompareTo(other.preparationTime);
        }

        public virtual void PrintRecipe()
        {
            Console.WriteLine(ToString());
        }

        public override string ToString()
        {
            return $"{Name}:\nIngredients: {Ingredients}\nInstructions: {Instructions}\nPreparation Time: {PreparationTime} minutes\nServings: {Servings}";
        }
    }

}
