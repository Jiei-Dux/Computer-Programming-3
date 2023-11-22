using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace EmployeeApplication.EmployeeInterface
{
    interface IEmployee
    {
        string? FirstName
        {
            get;
            set;
        }

        string? LastName
        {
            get;
            set;
        }

        string? Department
        {
            get;
            set;
        }

        string? JobTitle
        {
            get;
            set;
        }

        double BasicSalary
        {
            get;
            set;
        }

        void computeSalary(int hoursWorked, double ratePerHour);
    }
}
