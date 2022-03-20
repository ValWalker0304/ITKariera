using System;
using System.Collections.Generic;
using System.Text;

namespace Izpit
{
    public class Product
    {
        private string name;
        private int quantity;
        private double price;

        public Product()
        {

        }
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public int Quantitiy
        {
            get { return this.quantity; }
            set { this.quantity = value; }
        }
        public double Price
        {
            get { return this.price; }
            set { this.price = value; }
        }

        public Product(string name, int quantity, double price)
        {
            this.name = name;
            this.quantity = quantity;
            this.price = price;
        }
        public void Print()
        {
            Console.WriteLine("Product: {0}, Quantity: {1}, Price {2} lv", this.name, this.quantity, this.price);
        }
    }
}
