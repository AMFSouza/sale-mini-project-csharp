using System;
using System.Globalization;
using Sale_Mini_Project.Entities;
using Sale_Mini_Project.Entities.Enums;


namespace Sale_Mini_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            MessageOnTop();
            Customer customer = GetCustomer();
            Order order = GetOrder(customer);

            Console.Write("How many items to this order? ");
            int n = int.Parse(Console.ReadLine());

            ProcessOrder(n, order);

            Console.WriteLine();
            Console.WriteLine("ORDER SUMMARY:");
            Console.WriteLine(order);
        }

        static void MessageOnTop()
        {
            Console.WriteLine("Enter the customer data:");

        }

        static Customer GetCustomer()
        {
            // customer
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("E-mail: ");
            string email = Console.ReadLine();
            Console.Write("Birthdate: (DD/MM/YYYY): ");
            DateTime birthdate = DateTime.Parse(Console.ReadLine());
            Customer customer = new Customer(name, email, birthdate);
            return customer;
        }

        static Order GetOrder(Customer customer)
        {
            Console.WriteLine("Enter order data:");
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());
            Order order = new Order(DateTime.Now, status, customer);
            return order;
        }

        static void ProcessOrder(int n, Order order)
        {
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Enter #{i} item data:");
                Console.Write("Enter the product name: ");
                string productName = Console.ReadLine();

                Console.Write("Enter product price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.Write("Enter quantity: ");
                int quantity = int.Parse(Console.ReadLine());

                Product product = new Product(productName, price);
                order.AddItem(new OrderItem(quantity, price, product));
            }
        }


    }
}
