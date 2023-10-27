namespace EmployeeApplication
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            frmComputeSalary FORM = new();

            Application.Run(FORM);
        }
    }
}