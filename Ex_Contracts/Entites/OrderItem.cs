using System;
using System.Collections.Generic;
using System.Text;
using Ex_Contracts.Entites.Enums;

namespace Ex_Contracts.Entites
{
    class OrderItem
    {
        public int Quantity { get; set; }
        public double Price { get; set; }
        public Product Item { get; set; }

        public OrderItem()
        {
        }

        public OrderItem(int quantity, double price, Product item)
        {
            Quantity = quantity;
            Price = price;
            Item = item;
        }

        public double subTotal()
        {
            return Price * Quantity;
        }
    }
}
