using System;
using System.Collections.Generic;
using System.Text;
using Order.OrderItem;
using System.Globalization;
namespace Order.OrderItem
{
    class OrderItem
    {
        public int Quantity { get; set; }
        public double Price { get; set; }
        public Product Product { get; set; } 
        public OrderItem()
        {
        }
        public OrderItem(int Quantidade,double preco,Product product)
        {
            Quantity = Quantidade;
            Price = preco;
            Product = product;
        }
        public double SuBTotal()
        {
            return Quantity * Price;
        }
        public override string ToString()
        {
            return Product.NomeProd
                + ", $"
                + Price.ToString("F2", CultureInfo.InvariantCulture)
                + ", Quantity"
                + Quantity
                + ", Subtotal: $"
                + SuBTotal().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
