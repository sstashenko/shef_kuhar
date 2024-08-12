using System;

namespace shef_kuhar
{
    public class Product : FoodItem
    {
        private int quantity;

         public Product() : this("Unknown Product", 0.0, 0)
        {
        }

        public Product(string name, double price, int quantity)
            : base(name, price)
        {
            this.quantity = quantity;
        }

        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

         public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Quantity: {Quantity}");
        }

        public void DecreaseQuantity(int amount)
        {
            if (amount > Quantity)
            {
                throw new InvalidOperationException("Not enough quantity available.");
            }
            Quantity -= amount;
        }
    }

     public interface ICookable
    {
        void Cook();
    }
}
