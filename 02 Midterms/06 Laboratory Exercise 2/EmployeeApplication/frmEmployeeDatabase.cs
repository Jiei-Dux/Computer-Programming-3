using EmployeeApplication.EmployeeNamespace;

namespace EmployeeApplication
{
    public partial class frmEmployeeDatabase : Form
    {
        public frmEmployeeDatabase()
        {
            InitializeComponent();
        }


        // ========== // ========== // ========== // ========== // ========== //


        private void submitBtn_Click(object sender, EventArgs e)
        {
            int EmployeeID = Convert.ToInt32(TxtBox_EmployeeID.Text);
            string
                firstName = TxtBox_FName.Text,
                lastName = TxtBox_LName.Text,
                position = TxtBox_Position.Text;


            // ========== // ========== // ========== // ========== // ========== //


            Employee Class2 = new Employee(EmployeeID, firstName, lastName, position);


            // ========== // ========== // ========== // ========== // ========== //


            employeeDatabase.Rows.Add(
                Class2.EmployeeID,
                Class2.FName,
                Class2.LName,
                Class2.Position);


            // ========== // ========== // ========== // ========== // ========== //


            TxtBox_EmployeeID.Clear();
            TxtBox_FName.Clear();
            TxtBox_LName.Clear();
            TxtBox_Position.Clear();
        }
    }
}