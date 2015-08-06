/*
    Coded by: Concord Spark Tutoring
    Date: July 12, 2015
    Purpose: Lab - LINQing to Employees
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab___LINQingToEmployees
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee[] employeeList = new Employee[5];

            #region Code to Initialize Employees
            employeeList[0] = new Employee(); //Use Default Values

            employeeList[1] = new Employee
            {
                EmployeeID = "A0088888",
                FirstName = "John",
                LastName = "Diggle",
                YearlySalary = 40565.54M
            };

            employeeList[2] = new Employee
            {
                EmployeeID = "A0086423",
                FirstName = "Therese",
                LastName = "Rose",
                YearlySalary = 5555.55M
            };

            employeeList[3] = new Employee();
            employeeList[3].EmployeeID = "B0084638";
            employeeList[3].YearlySalary = 24644.44M;

            employeeList[4] = new Employee();
            employeeList[4].FirstName = "Joe";
            employeeList[4].LastName = "Davidson";
            #endregion            


            #region LINQ
            //Find the Employees who have no first and no last name
            IEnumerable<Employee> namelessEmployees = from Employee in employeeList
                                                      where (Employee.FirstName == "N/A") &&
                                                      (Employee.LastName == "N/A" )
                                                      select Employee;

            //Find the Employees who have a salary greater than 50.000$
            IEnumerable <Employee> richEmployees = from Employee in employeeList
                                                   where (Employee.YearlySalary > 50000.0M)
                                                   select Employee;

            //Obtain a list of all Employees, sorted by lastName/Firstname
            IEnumerable<Employee> sortedEmployees = from Employee in employeeList
                                                    orderby Employee.LastName, Employee.FirstName
                                                    select Employee;

            //Find any employee(s) whose ID begins with the capital letter ‘B’
            IEnumerable<Employee> bEmployees = from Employee in employeeList
                                               where Employee.EmployeeID.StartsWith("B")
                                               select Employee;

            //Find any employee(s) whose ID begins with the capital letter ‘A’
            IEnumerable<Employee> aEmployees = from Employee in employeeList
                                               where Employee.EmployeeID.StartsWith("A")
                                               select Employee;

            //Find any employee(s) whose first name begins with the capital letter ‘J’
            IEnumerable<Employee> jEmployees = from Employee in employeeList
                                               where Employee.FirstName.StartsWith("A")
                                               select Employee;


            #endregion

            #region output

            Console.WriteLine("Employees without first and last name: ");

            if (namelessEmployees.Count() > 0)
            {
                foreach (Employee member in namelessEmployees)
                {
                    Console.WriteLine("{0}, {1}, {2}", member.EmployeeID, member.FirstName, member.LastName);
                }
            }
            else Console.WriteLine("Query returned nothing");


            Console.WriteLine("Employees with salary greater than 50.000: ");
            if (richEmployees.Count() > 0)
            {
                foreach (Employee member in richEmployees)
                {
                    Console.WriteLine("{0}, {1}, {2}", member.EmployeeID, member.FirstName, member.LastName);
                }
            }
            else Console.WriteLine("Query returned nothing");

            Console.WriteLine("Employees, sorted by first and last Name: ");
            if (sortedEmployees.Count() > 0)
            {
                foreach (Employee member in sortedEmployees)
                {
                    Console.WriteLine("{0}, {1}, {2}", member.EmployeeID, member.FirstName, member.LastName);
                }
            }
            else Console.WriteLine("Query returned nothing");

            Console.WriteLine("Employees, whose ID begins with capital letter B: ");
            if (bEmployees.Count() > 0)
            {
                foreach (Employee member in bEmployees)
                {
                    Console.WriteLine("{0}, {1}, {2}", member.EmployeeID, member.FirstName, member.LastName);
                }
            }
            else Console.WriteLine("Query returned nothing");

            Console.WriteLine("Employees, whose ID begins with capital letter A: ");
            if (aEmployees.Count() > 0)
            {
                foreach (Employee member in aEmployees)
                {
                    Console.WriteLine("{0}, {1}, {2}", member.EmployeeID, member.FirstName, member.LastName);
                }
            }
            else Console.WriteLine("Query returned nothing");

            Console.WriteLine("Employees, whosed first name begins with capital letter J: ");
            if (jEmployees.Count() > 0)
            {
                foreach (Employee member in namelessEmployees)
                {
                    Console.WriteLine("{0}, {1}, {2}", member.EmployeeID, member.FirstName, member.LastName);
                }
            }
            else Console.WriteLine("Query returned nothing");

            #endregion
        }
    }
}
