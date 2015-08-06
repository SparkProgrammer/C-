using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab___LINQingToEmployees
{
    class Employee
    {
        private String employeeId;
        private String firstName;
        private String lastName;
        private decimal yearlySalary;

        #region Properties
        public String EmployeeID
        {
            set
            {
                if(value.Length > 0)
                {
                    employeeId = value;
                }
            }
            get
            {
                return employeeId;
            }
        }

        public String FirstName
        {
            set
            {
                if(value.Length > 0)
                {
                    firstName = value;
                }
            }
            get
            {
                return firstName;
            }
        }

        public String LastName
        {
            set
            {
                if(value.Length > 0)
                {
                    lastName = value;
                }
            }
            get
            {
                return lastName;
            }
        }

        public Decimal YearlySalary
        {
            set
            {
                if(value >= 0.0M)
                {
                    yearlySalary = value;
                }
            }
            get
            {
                return yearlySalary;
            }
        }
        #endregion

        public Employee(String id = "N/A", String first = "N/A", String last = "N/A", decimal salary = 0.0M)
        {
            EmployeeID = id;
            FirstName = first;
            LastName = last;
            YearlySalary = salary;
        }

        public override string ToString()
        {
            return EmployeeID + " - " + FirstName + " " + LastName;
        }
    }
}
