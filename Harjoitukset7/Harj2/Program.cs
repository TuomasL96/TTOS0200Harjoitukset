using System;
using System.Collections.Generic;

namespace Harj2
{
    class Program
    {
        static void Main(string[] args)
        {
            TestShoppingCart();
        }
        static void TestShoppingCart()
        {
            List<Product> products = new List<Product>();
            products.Add(new Product("Milk", 1.4));
            products.Add(new Product("Beer", 2.2));
            products.Add(new Product("Butter", 3.2));
            products.Add(new Product("Cheese", 4.2));

            Console.WriteLine("All products in collection");
            foreach (Product product in products)
            {
                Console.WriteLine(product.ToString());
            }
        }
    }
}
