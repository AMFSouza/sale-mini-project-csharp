using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Sale_Mini_Project.Entities
{
    class OrderItem
    {
        public int Quantity { get; set; }
        public double Price { get; set; }

        public OrderItem() { }

        public OrderItem(int quantity, double price)
        {
            Quantity = quantity;
            Price = price;
        }

        public Double Subtotal()
        {
            return Quantity * Price;
        }

        public override string ToString()
        {
            return $"{Quantity}, ${Subtotal().ToString("F2", CultureInfo.InvariantCulture)} ";
        }
    }
}
