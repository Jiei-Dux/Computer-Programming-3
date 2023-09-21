namespace StudentRegistrationApplication
{
    public partial class frmStudentRegistration : Form
    {
        public frmStudentRegistration()
        {
            InitializeComponent();
        }

        public static string FName = string.Empty;
        public static string LName = string.Empty;
        public static string MName = string.Empty;

        public static string Gender = string.Empty;

        private void cmbDay_DropDown(object sender, EventArgs e)
        {
            cmbDay.Items.Add(" --- Day ---");
            for (int Day = 1; Day <= 31; Day++)
            {
                cmbDay.Items.Add(Day);
            }
        }

        private void cmbMonth_DropDown(object sender, EventArgs e)
        {
            cmbMonth.Items.Add(" --- Month ---");
            for (int Month = 1; Month <= 12; Month++)
            {
                cmbMonth.Items.Add(Month);
            }
        }

        private void cmbYear_DropDown(object sender, EventArgs e)
        {
            cmbYear.Items.Add(" --- Year ---");
            for (int Year = 1900; Year <= DateTime.UtcNow.Year; Year++)
            {
                cmbYear.Items.Add(Year);
            }
        }

        private void regBtn_Click(object sender, EventArgs e)
        {
            FName = fnTxtBox.Text;
            LName = lnTxtBox.Text;
            MName = mnTxtBox.Text;

            if (maleBtn.Checked)
            {
                Gender = maleBtn.Text;
            }

            if (femaleBtn.Checked)
            {
                Gender = femaleBtn.Text;
            }

            frmStudentRegistrationValidation F2 = new frmStudentRegistrationValidation(
                cmbDay.SelectedItem.ToString(),
                cmbMonth.SelectedItem.ToString(),
                cmbYear.SelectedItem.ToString()
            );
            F2.ShowDialog();
        }
    }
}