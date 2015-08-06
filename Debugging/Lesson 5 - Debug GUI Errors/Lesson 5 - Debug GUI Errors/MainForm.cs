using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson_5___Debug_GUI_Errors
{
    /// <summary>
    /// Show student the correct results and allow him/her to debug accordingly and correct the code
    /// to get the proper results.
    /// </summary>
    public partial class MainForm : Form
    {
        Employee[] companyEmployees;

        public MainForm()
        {
            InitializeComponent();
            InitializeCompanyEmployees();
        }

        private void InitializeCompanyEmployees()
        {
            companyEmployees = new Employee[20];

            for (int i = 0; i < companyEmployees.Length; ++i)
            {
                companyEmployees[i] = new Employee();
            }

            companyEmployees[0].FirstName = "John";
            companyEmployees[1].LastName = "Dalton";
            companyEmployees[10].EmployeeID = "A0073433";
            companyEmployees[5].LastName = "3445555";
            companyEmployees[2].LastName = "Artemis";
            companyEmployees[19].LastName = "Fondue";
        }

        private void buttonShow_Click(object sender, EventArgs e)
        {
            var employeeNames = from employee in companyEmployees
                                where employee.LastName != null
                                orderby employee.LastName ascending
                                select employee;

            foreach(Employee emp in employeeNames)
            {                
                listBoxEmployees.Items.Add(emp.LastName + " " + emp.FirstName);
            }            
        }
    }
}
