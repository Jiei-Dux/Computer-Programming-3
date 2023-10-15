using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentNamespace
{
    public partial class frmStudentInfo : Form
    {
        public frmStudentInfo()
        {
            InitializeComponent();
        }


        // ========== // ========== // ========== // ========== // ========== //


        private void submitBtn_Click(object sender, EventArgs e)
        {
            StudentInfo Class2 = new StudentInfo();


            // ========== // ========== // ========== // ========== // ========== //


            Class2.stdID = Convert.ToInt32(TxtBox_stdID.Text);
            Class2.LName = TxtBox_LName.Text;
            Class2.FName = TxtBox_FName.Text;


            // ========== // ========== // ========== // ========== // ========== //


            ListBox_stdID.Items.Add(Class2.stdID);
            ListBox_LName.Items.Add(Class2.LName);
            ListBox_FName.Items.Add(Class2.FName);
        }
    }


    // ========== // ========== // ========== // ========== // ========== //


    class StudentInfo
    {
        private int studID;
        private string fname = "", lname = "";


        // ========== // ========== // ========== // ========== // ========== //


        public int stdID
        {
            get { return studID; }
            set { studID = value; }
        }

        public string FName
        {
            get { return fname; }
            set { fname = value; }
        }

        public string LName
        {
            get { return lname; }
            set { lname = value; }
        }


        // ========== // ========== // ========== // ========== // ========== //


        public StudentInfo()
        {
            
        }

        public StudentInfo(int studID, string fname, string lname)
        {
            stdID = studID;
            FName = fname;
            LName = lname;
        }
    }
}
