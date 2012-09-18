using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IEquatableDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // DEMO: modify Product to implement IEquatable or not

            Product p1 = new Product(1, "Chai", 18.00);
            Product p2 = new Product(1, "Chai", 18.00);
            Product p3 = new Product(2, "Green Tea", 22.00);

            Console.WriteLine("The products are equal: {0}",p1.Equals(p2));

            List<Product> products = new List<Product>();
            products.Add(p1);
            products.Add(p3);

            Product p4 = new Product(2, "Green Tea", 22.00);
            bool inList = products.Contains<Product>(p4);

            Console.WriteLine( "The list {0} contain the product",
                inList ? "does" : "does not");
        }
    }
}
