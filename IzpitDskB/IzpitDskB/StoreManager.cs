using System;
using System.Collections.Generic;
using System.Text;

namespace Izpit
{
    public class StoreManager
    {
        public Product products1;
        public Product products2;
        public Product products3;

        public StoreManager()
        {

        }
        public StoreManager(Product products1, Product products2, Product products3)
        {
            this.products1 = products1;
            this.products2 = products2;
            this.products3 = products3;
        }
        public void GetTheMostExpensive()
        {
            if (products1.Price > products2.Price && products1.Price > products3.Price)
            {
                products1.Print();
            }
            else if (products2.Price > products1.Price && products2.Price > products3.Price)
            {
                products2.Print();
            }
            else if (products3.Price > products2.Price && products3.Price > products1.Price)
            {
                products3.Print();
            }
        }
    }
}
