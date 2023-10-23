using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Data.Common;

namespace CashierApplication.UserAccountNamespace
{
    internal class Cashier : UserAccount
    {
        private string Department;

        public Cashier(string name, string department, string uName, string password)
        {
            user_name = uName;
            Department = department;
            user_password = password;
        }

        public override bool validateLogin(string uName, string password)
        {
            if ( uName == "admin" && password == "admin" )
            {
                return true;
            }

            return false;
        }

        public string getDepartment()
        {
            return Department;
        }
    }
}
