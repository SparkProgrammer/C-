using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial2
{
    class Employee
    {
        private uint age;
        private String firstName;
        private String lastName;
        private DateTime dateHired;
        private decimal yearlyIncome;
        private float payPerHour;
        private String comments;

        #region Properties

        public uint Age
        {
            set
            {
            if (value > 0)
                {
                    age = value;
                }
            }
            get
            { 
                return age;
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

        public DateTime DateHired
        {
            set
            {
                if(value.Year > 1900)
                {
                    dateHired = value;
                }
            }
            get
            {
                return dateHired;
            }
        }

        public decimal YearlyIncome
        {
            set
            {
                if(value >= 0.0M) //M suffix means 'Decimal' value
                {
                    yearlyIncome = value;
                }
            }
            get
            {
                return yearlyIncome;
            }
        }

        public float PayPerHour
        {
            set
            {
                if(value>= 0.0f) //f suffix means 'float' value
                {
                    payPerHour = value;
                }
            }
            get
            {
                return payPerHour;
            }
        }

        public string Comments
        {
            set
            {
                if(value.Length > 0)
                {
                    comments = value;
                }
            }
            get
            {
                return comments;
            }
        }

        #endregion



    }
}
