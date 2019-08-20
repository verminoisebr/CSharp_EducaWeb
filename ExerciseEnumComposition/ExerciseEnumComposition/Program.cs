using System;
using ExerciseEnumComposition.Entities;
using ExerciseEnumComposition.Entities.Enums;
using System.Globalization;

namespace ExerciseEnumComposition
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order1;

            Console.WriteLine("Enter client data:");
            Console.Write("Name: ");
            string clientName = Console.ReadLine();
            Console.Write("Email: ");
            string clientEmail = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime clientBirthDate = DateTime.Parse(Console.ReadLine());
            Client c1 = new Client(clientName, clientEmail, clientBirthDate);

            Console.WriteLine("Enter order data:");
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

            order1 = new Order(DateTime.Now, status, c1);

            Console.Write("How many items to this order? ");
            int numberItems = int.Parse(Console.ReadLine());
            for (int i = 1; i <= numberItems; i++)
            {
                Console.WriteLine($"Enter #{i} item data:");
                Console.Write("Product name: ");
                string prodName = Console.ReadLine();
                Console.Write("Product price: ");
                double prodPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Product itemProd = new Product(prodName, prodPrice);

                Console.Write("Quantity: ");
                int prodQtd = int.Parse(Console.ReadLine());
                OrderItem item = new OrderItem(prodQtd, prodPrice, itemProd);

                order1.AddItem(item);
            }
            Console.WriteLine(order1);
        }
    }
}
