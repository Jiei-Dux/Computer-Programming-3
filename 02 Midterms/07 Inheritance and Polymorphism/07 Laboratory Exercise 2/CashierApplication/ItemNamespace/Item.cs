using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace CashierApplication.ItemNamespace
{
    abstract class Item
    {
        protected int item_quantity;
        protected double item_price;
        protected string? item_name;

        private double total_price;

        public Item() { }

        public Item(string name, double price, int quantity)
        {
            item_name = name;
            item_price = price;
            item_quantity = quantity;
            total_price = price * quantity;
        }

        public abstract double getTotalPrice();
        public abstract void setPayment(double amount);
    }
}
