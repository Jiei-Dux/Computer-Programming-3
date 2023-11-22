using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace CashierApplication.ItemNamespace
{
    internal class DiscountedItem : Item
    {
        private double change;
        private double item_discount;
        private double payment_amount;
        private double discounted_price;

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
