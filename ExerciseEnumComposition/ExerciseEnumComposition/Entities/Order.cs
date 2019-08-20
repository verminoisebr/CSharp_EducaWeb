﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;
using ExerciseEnumComposition.Entities.Enums;

namespace ExerciseEnumComposition.Entities
{
    class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public Client Client { get; set; }
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();

        public Order()
        {
        }

        public Order(DateTime moment, OrderStatus status, Client client)
        {
            Moment = moment;
            Status = status;
            Client = client;
        }

        public void AddItem(OrderItem item)
        {
            Items.Add(item);
        }

        public void RemoveItem(OrderItem item)
        {
            Items.Remove(item);
        }

        public double Total(List<OrderItem> Items)
        {
            double sum = 0.0;
            foreach (OrderItem item in Items)
            {
                sum += item.SubTotal();
            }
            return sum;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("ORDER SUMARY:");
            sb.AppendLine("Order moment: " + Moment.ToString("dd/MM/yyyy - HH:mm:ss"));
            sb.AppendLine("Order status: " + Status.ToString());
            sb.AppendLine(Client.ToString());
            sb.AppendLine("Order items: ");
            foreach (OrderItem item in Items)
            {
                sb.AppendLine(item.ToString());
            }
            sb.Append("Total price: $" + Total(Items).ToString("F2", CultureInfo.InvariantCulture));
            return sb.ToString();
        }
    }
}
