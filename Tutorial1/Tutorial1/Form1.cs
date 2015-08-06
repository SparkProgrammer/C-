using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tutorial1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonOk_Click(object sender, EventArgs e) //Listener
        {
            textBoxMessage.Text = "Hi! This is my first C# app! I hope you like it!";
        }
    }
}
