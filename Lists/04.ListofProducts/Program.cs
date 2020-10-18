using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.ListofProducts
{
    class Program
    {
        static void Main(string[] args)
        {


            int n = int.Parse(Console.ReadLine());
            List<string> products = new List<string>();
            string product = "";

            for (int i = 0; i < n; i++)
            {
                product = Console.ReadLine();
                products.Add(product);
            }

            for (int i = 0; i < products.Count; i++)
            {
                products.Sort();
                Console.WriteLine($"{i+1}.{products[i]}");
            }
            


            //Read a number n and n lines of products. Print a numbered list of all the products ordered by name.
        }
    }
}
