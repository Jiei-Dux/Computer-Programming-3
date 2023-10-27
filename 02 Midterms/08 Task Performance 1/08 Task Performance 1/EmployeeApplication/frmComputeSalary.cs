using System;
using System.Data;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Collections.Generic;

using EmployeeApplication.EmployeeNamespace;
using EmployeeApplication.EmployeeInterface;

namespace EmployeeApplication
{
    public partial class frmComputeSalary : Form
    {
        public frmComputeSalary()
        {
            InitializeComponent();
        }

        private void btn_ComputeSalary_Click(object sender, EventArgs e)
        {
            string? fname = Txt_FName.Text;
            string? lname = Txt_LName.Text;
            string? dept = Txt_Dpt.Text;
            string? job = Txt_JobTitle.Text;

            int hrs = Convert.ToInt32(Txt_Hrs.Text);
            double rph = Convert.ToDouble(Txt_RPH.Text);

            PartTimeEmployee Class2 = new(fname, lname, dept, job);

            Class2.computeSalary(hrs, rph);

            Lbl_UsrFName.Text = fname;
            Lbl_UsrLName.Text = lname;
            Lbl_UsrSalary.Text = Convert.ToString(Class2.getSalary());
        }
    }
}
