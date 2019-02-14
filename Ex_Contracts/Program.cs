using System;
using System.Collections.Generic;
using System.Globalization;
using Ex_Contracts.Entites;
using Ex_Contracts.Entites.Enums;

namespace Ex_Contracts
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter client data:");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());

            Client client = new Client(name, email, birthDate);

            Console.WriteLine();
            Console.WriteLine("Enter order data:");
            Console.Write("Status: ");
            OrderStatus orderStatus = Enum.Parse<OrderStatus>(Console.ReadLine());
            Console.Write("How many items to this order? ");
            int items = int.Parse(Console.ReadLine());
            Console.WriteLine();
            for (int i = 1; i <= items; i++)
            {
                Console.WriteLine("Enter #" + i + " item data:");
                Console.Write("Product name: ");
                string productName = Console.ReadLine();
                Console.Write("Product price: $");
                double productPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());

                Product item = new Product(productName, productPrice);
                OrderItem orderItem = new OrderItem(quantity, productPrice, item);
            }

            Order order = new Order(DateTime.Now, orderStatus, client);
            Console.WriteLine();
            Console.WriteLine("ORDER SUMARY:");
            Console.WriteLine(order);
            Console.WriteLine(client);
            Console.Write("Order items: ");
            
        }
    }
}
