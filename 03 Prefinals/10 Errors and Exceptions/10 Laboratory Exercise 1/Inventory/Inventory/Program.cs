namespace Inventory
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new FrmAddProduct());
            //ApplicationConfiguration.Initialize();
            //Application.Run(new FrmAddProduct());
        }
    }
}