using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashierApplication.ItemNamespace
{
    abstract class Item
    {
        protected string? item_name;
        protected double item_price;
        protected int item_quantity;
        private double total_price;

        public Item()
        {

        }

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


    // ========== //


    class DiscountedItem : Item
    {
        private double item_discount;
        private double discounted_price;
        private double payment_amount;
        private double change;

        public DiscountedItem(string name, double price, int quantity, double discount)
        {
            item_name = name;
            item_discount = price * quantity * discount * 0.01;
            discounted_price = price * quantity - item_discount;
        }

        public override double getTotalPrice()
        {
            return discounted_price;
        }

        public override void setPayment(double amount)
        {
            payment_amount = amount;
        }

        public double getChange()
        {
            change = payment_amount - getTotalPrice();
            return change;
        }
    }
}
