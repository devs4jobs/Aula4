using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;
using Order.OrderItem.enums;

namespace Order.OrderItem
{
    class Ordere
    {
        Guid Guid { get; set; }
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public Client Client { get; set; }
        public List<OrderItem> Itens { get; set; } = new List<OrderItem>();

        public Ordere()
        {

        }
        public Ordere(DateTime moment,OrderStatus status,Client cliente)
        {
            Guid=Guid.NewGuid();
            Moment = moment;
            Status = status;
            Client = cliente;
        }
        public void AddItem(OrderItem item)
        {
            Itens.Add(item);
        }
        public void RemoveItem(OrderItem item)
        {
            Itens.Remove(item);
        }
        public double Total()
        {
            double sum = 0.0;
            foreach(OrderItem item in Itens)
            {
                sum += item.SuBTotal();
            }
            return sum;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Fiscal Note:{Guid}");
            sb.AppendLine("Order moment: " + Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine("Order status: " + Status);
            sb.AppendLine("Client: " + Client);
            sb.AppendLine("Order items: ");
            foreach(OrderItem item in Itens)
            {
                sb.AppendLine(item.ToString());
            }
            sb.AppendLine("Total price: $" + Total().ToString("F2", CultureInfo.InvariantCulture));
            return sb.ToString();
        }
    }
}
