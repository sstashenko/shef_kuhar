using System;

namespace shef_kuhar
{
    public abstract class FoodItem
    {
        protected string name; 
        protected double price; 
        protected FoodItem()
        {
            name = "Unknown Food Item"; 
            price = 0.0;
        }
        public FoodItem(string name, double price)
        {
            this.name = name; 
            this.price = price; 
        }
        public string Name
        {
            get { return name; }
            set { name = value; } 
        }
        public double Price
        {
            get { return price; }
            set { price = value; } 
        }
        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}, Price: {Price}"); 
        }
    }
}
