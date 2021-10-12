using Sale_Mini_Project.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Sale_Mini_Project.Entities
{
    class Order
    {
        public DateTime CreatedAt { get; set; }
        public OrderStatus Status { get; set; }
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();
        public Customer Customer { get; set; }
        public Order() { }

        public Order(DateTime createdAt, OrderStatus status, Customer customer)
        {
            CreatedAt = createdAt;
            Status = status;
            Customer = customer;
        }

        public void AddItem(OrderItem item)
        {
            Items.Add(item);
        }

        public void RemoveItem(OrderItem item)
        {
            Items.Remove(item);
        }

        public double Total()
        {
            double sum = 0.0;

            foreach(OrderItem item in Items)
            {
                sum += item.Subtotal();
            }

            return sum;
        }

        public override string ToString()
        {
            string message = "Order moment: " + CreatedAt.ToString() + '\n';
            message += "Order status: " + Status + '\n';
            message += "Customer: " + Customer + '\n';
            message += "Order items:" + '\n';

            StringBuilder sb = new StringBuilder();
            sb.Append(message);
            foreach(OrderItem item in Items)
            {
                sb.Append(item.ToString());
            }

            sb.Append("Total price: " + Total().ToString("F2", CultureInfo.InvariantCulture));

            return sb.ToString();
        }
    }
}
