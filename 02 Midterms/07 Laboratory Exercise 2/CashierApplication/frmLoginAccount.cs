using System;
using System.Data;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Collections.Generic;
using CashierApplication.UserAccountNamespace;

namespace CashierApplication
{
    public partial class frmLoginAccount : Form
    {
        public frmLoginAccount()
        {
            InitializeComponent();
        }

        private void Btn_Login_Click(object sender, EventArgs e)
        {
            string name = "admin", dept = "admin", uName, pass;

            uName = Txt_usrName.Text;
            pass = Txt_Passwd.Text;

            Cashier validation = new Cashier(name, dept, uName, pass);
            
            if ( validation.validateLogin(uName, pass) )
            {
                MessageBox.Show("You are now logged in!");
                this.Hide();
                var frmPurchaseDiscountedItem = new frmPurchaseDiscountedItem();
                frmPurchaseDiscountedItem.FormClosed += (s, args) => this.Close();
                frmPurchaseDiscountedItem.Show();
            }
        }

    }
}
