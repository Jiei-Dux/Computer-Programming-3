using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentRegistrationApplication
{
    public partial class frmStudentRegistrationValidation : Form
    {
        public frmStudentRegistrationValidation(
            string Day,
            string Month,
            string Year
        )
        {
            InitializeComponent();
            stdBday.Text = Day + " / " + Month + " / " + Year;
        }

        private void frmStudentRegistrationValidation_Load(object sender, EventArgs e)
        {
            stdName.Text = 
                frmStudentRegistration.LName + ", " + 
                frmStudentRegistration.FName + 
                frmStudentRegistration.MName;
            stdGender.Text = frmStudentRegistration.Gender;
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
