using System;
using System.Collections.Generic;
using System.Text;
using Ex_Contracts.Entites.Enums;
using Ex_Contracts.Entites;

namespace Ex_Contracts.Entites
{
    class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public Client Client { get; set; }
        public List<OrderItem> OrderItem { get; set; } = new List<OrderItem>();

        public Order()
        {
        }

        public Order(DateTime moment, OrderStatus status, Client client)
        {
            Moment = moment;
            Status = status;
            Client = client;
        }
    }
}
