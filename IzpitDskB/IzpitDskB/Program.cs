using System;

namespace Izpit
{
    class Program
    { 
        static void Main(string[] args)
        {
            Product products1 = new Product();
            products1.Name = "Водка";
            products1.Price = 3;
            products1.Quantitiy = 1;
            products1.Print();

            Product products2 = new Product();
            products2.Name = "Количка";
            products2.Price = 2;
            products2.Quantitiy = 1;
            products2.Print();

            Product products3 = new Product();
            products3.Name = "Чипс";
            products3.Price = 5;
            products3.Quantitiy = 1;
            products3.Print();

            StoreManager pp1 = new StoreManager() { products1 = products1, products2 = products2, products3 = products3 };
            pp1.GetTheMostExpensive();
        }
    }
}
