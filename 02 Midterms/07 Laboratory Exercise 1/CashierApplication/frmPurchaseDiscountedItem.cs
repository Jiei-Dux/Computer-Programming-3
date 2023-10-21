using CashierApplication.ItemNamespace;

namespace CashierApplication
{
    public partial class frmPurchaseDiscountedItem : Form
    {
        public frmPurchaseDiscountedItem()
        {
            InitializeComponent();
            Txt_Item.Text = null;
        }

        private void Btn_Compute_Click(object sender, EventArgs e)
        {
            string ItemName = Txt_Item.Text;

            int Quantity = Convert.ToInt32(Txt_Qty.Text);
            int Discount = Convert.ToInt32(Txt_Discount.Text);

            double Price = Convert.ToDouble(Txt_Price.Text);

            DiscountedItem Class2 = new DiscountedItem(ItemName, Price, Quantity, Discount);

            Display_TtlAmount.Text = Convert.ToString(Class2.getTotalPrice());
        }

        private void Btn_Submit_Click(object sender, EventArgs e)
        {
            string ItemName = Txt_Item.Text;

            int Quantity = Convert.ToInt32(Txt_Qty.Text);
            int Discount = Convert.ToInt32(Txt_Discount.Text);

            double Price = Convert.ToDouble(Txt_Price.Text);

            double Amount = Convert.ToDouble(Txt_Payment.Text);

            DiscountedItem Class2 = new DiscountedItem(ItemName, Price, Quantity, Discount);

            Class2.setPayment(Amount);

            Display_Change.Text = Convert.ToString(Class2.getChange());
        }
    }
}