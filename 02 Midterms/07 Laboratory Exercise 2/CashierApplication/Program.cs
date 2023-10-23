namespace CashierApplication
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            frmLoginAccount LoginAcc = new();
            frmPurchaseDiscountedItem App = new();
            
            Application.Run(LoginAcc);
        }
    }
}