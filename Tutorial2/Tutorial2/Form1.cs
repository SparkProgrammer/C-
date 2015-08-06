using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tutorial2
{
    public partial class Form1 : Form
    {
        private Employee record;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            record = new Employee();

                record.Age = 34;
                record.DateHired = new DateTime(1993, 10, 12);
                record.FirstName = "John";
                record.LastName = "Martin";
                record.YearlyIncome = 350000.53M;
                record.PayPerHour = 14.62F;
                record.Comments = "Excellent Worker";
        }

        private void buttonShowData_Click(object sender, EventArgs e)
        {
            textBoxAge.Text = record.Age.ToString();
            textBox_employeeName.Text = record.FirstName + " " + record.LastName;
            textBoxDate_Hired.Text = record.DateHired.ToString("yyyy, MMMMM dd");
            textBoxYearly_Income.Text = record.YearlyIncome.ToString();
            textBoxComments.Text = record.Comments;
            textBoxPay_Rate.Text = record.PayPerHour.ToString();

        }

        private void buttonClearFields_Click(object sender, EventArgs e)
        {
            textBoxAge.Text = "";
            textBox_employeeName.Text = "";
            textBoxDate_Hired.Text = "";
            textBoxYearly_Income.Text = "";
            textBoxComments.Text = "";
            textBoxPay_Rate.Text = "";
        }

        private void buttonSave_Comments_Click(object sender, EventArgs e)
        {
            record.Comments = textBoxComments.Text;
        }
    }
}
