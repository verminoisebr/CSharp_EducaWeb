using System;
using System.Collections.Generic;
using System.Globalization;
using ExerciseInheritancePolimorfism.Entities;

namespace ExerciseInheritancePolimorfism
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();

            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.Write("Common, used or imported (c,u,i)?");
                char option = char.Parse(Console.ReadLine());
                Console.WriteLine($"Product #{i} data: ");
                Console.Write("Name: ");
                string prodName = Console.ReadLine();
                Console.Write("Price: ");
                double prodPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (option == 'c')
                    products.Add(new Product(prodName, prodPrice));
                else if (option == 'u')
                {
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime prodDate = DateTime.Parse(Console.ReadLine());
                    products.Add(new UsedProduct(prodName, prodPrice, prodDate));
                }
                else
                {
                    Console.Write("Customs fee: $ ");
                    double prodFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    products.Add(new ImportedProduct(prodName, prodPrice, prodFee));
                }
            }

            Console.WriteLine("PRICE TAGS: ");
            foreach (Product x in products)
            {
                Console.WriteLine(x.PriceTag());
            }
        }
    }
}
