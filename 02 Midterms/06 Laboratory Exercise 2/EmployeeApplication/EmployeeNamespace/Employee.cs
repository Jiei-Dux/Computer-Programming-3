using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApplication.EmployeeNamespace
{
    public class Employee
    {
        private int employeeID;
        private string 
            fname, 
            lname, 
            position;


        // ========== // ========== // ========== // ========== // ========== //


        public int EmployeeID 
        {
            get { return employeeID; }
            set { employeeID = value; }
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

        public string Position
        {
            get { return position; }
            set { position = value; }
        }


        // ========== // ========== // ========== // ========== // ========== //


        public Employee(int employeeID, string fname, string lname, string position)
        {
            EmployeeID = employeeID;
            FName = fname;
            LName = lname;
            Position = position;
        }
    }
}
