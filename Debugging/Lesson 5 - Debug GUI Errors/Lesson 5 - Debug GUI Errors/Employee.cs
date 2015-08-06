using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_5___Debug_GUI_Errors
{
    class Employee
    {
        private String empId;
        private String firstName;
        private String lastName;

        public String EmployeeID
        {
            set
            {
                empId = value;
            }
            get
            {
                return empId;
            }
        }

        public String FirstName
        {
            set
            {
                firstName = value;
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
                lastName = value;
            }
            get
            {
                return lastName;
            }
        }
    }
}
