using System;

namespace abstract_class
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person("Petar", 20, "Sofia", "blue", false);
            p.Introduce();
            
            //Mammal m = new Mammal("blue", false);
            //полиморфизъм
            Mammal p2 = new Person("Petar", 20, "Sofia", "blue", false);
            p2.HelloMethod();
        }
    }
}
