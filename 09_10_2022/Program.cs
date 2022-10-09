using System;
using System.Collections;
using System.Collections.Generic;

namespace HashTables
{
    internal class Program
    {

        /*static void Main(string[] args)
        {

                         //Hashtables
                        Hashtable numbernames = new Hashtable();
                        numbernames.Add(1, "One");

                        Hashtable cities = new Hashtable(){
                            {"UK", "London, MAnchestar"},
                            {"Bulgaria", "Sofia, Plovdiv"}
                        };

                        foreach (DictionaryEntry de in numbernames)
                        {
                            Console.WriteLine($"Key {de.Key}. Value {de.Value} ");
                        }
                        foreach (DictionaryEntry de in cities)
                        {
                            Console.WriteLine($"Key {de.Key}. Value {de.Value.GetHashCode()} ");
                        }
             


            //Design Patterns

            /// <summary>

            /// Entry point into console application.

            /// </summary>
        }*/
        public static void Main()

        {

            // Abstract factory #1

            CountryFatory factoryEurope = new CarfactoryEurope();

            Client world = new Client(factoryEurope);

            world.Run();



            // Abstract factory #2

            CountryFatory factoryJapan = new CarfactoryJapan();

            Client world2 = new Client(factoryJapan);

            world2.Run();



            // Wait for user input

            Console.ReadKey();

        }

    }

    abstract class CountryFatory

    {

        public abstract ProductCorolla CreateCorolla();

        public abstract ProductPrius CreatePrius();

    }

    class CarfactoryEurope : CountryFatory

    {

        public override ProductCorolla CreateCorolla()

        {

            return new Corolla();

        }

        public override ProductPrius CreatePrius()

        {
            return null;
        }

    }


    class CarfactoryJapan : CountryFatory

    {

        public override ProductCorolla CreateCorolla()

        {
            return null;

        }

        public override ProductPrius CreatePrius()

        {

            return new Prius();

        }

    }

    abstract class ProductCorolla

    {
        public abstract void Output(ProductCorolla a);
    }

    abstract class ProductPrius

    {

        public abstract void Output(ProductPrius a);

    }






    class Corolla : ProductCorolla

    {
        public override void Output(ProductCorolla a)

        {

            Console.WriteLine(this.GetType().Name +

              " Outputs with " + a.GetType().Name);

        }
    }



    /// <summary>

    /// The 'Prius' class

    /// </summary>

    class Prius : ProductPrius

    {

        public override void Output(ProductPrius a)

        {

            Console.WriteLine(this.GetType().Name +

              " Outputs with " + a.GetType().Name);

        }

    }





    /// <summary>

    /// The 'Client' class. Outpution environment for the products.

    /// </summary>

    class Client

    {

        private ProductCorolla _abstractProductA;

        private ProductPrius _abstractProductB;



        // Constructor

        public Client(CountryFatory factory)

        {

            _abstractProductB = factory.CreatePrius();

            _abstractProductA = factory.CreateCorolla();

        }



        public void Run()

        {

            _abstractProductB.Output(_abstractProductA);

        } 
    }
}
