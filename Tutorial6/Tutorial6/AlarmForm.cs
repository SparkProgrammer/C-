using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Tutorial6
{
    public partial class AlarmForm : Form
    {
        private DateTime alarmTime;
        private bool alarmOn;

        #region Methods
        public AlarmForm()
        {
            InitializeComponent();
        }

        void AlarmForm_Load(object sender, EventArgs e)
        {
            labelTime.Text = DateTime.Now.ToString("T");
            this.CenterToScreen();
        }

        private void buttonSetAlarm_Click(object sender, EventArgs e)
        {
            int minutesFromNow = Convert.ToInt32(numericUpDownMinuteSelector.Value);

            alarmTime = DateTime.Now.AddMinutes(minutesFromNow);
            alarmOn = true;
        }

        

        private void timerSecond_Tick(object sender, EventArgs e)
        {
            labelTime.Text = DateTime.Now.ToString("T");

            if (DateTime.Now.Ticks >= alarmTime.Ticks && alarmOn == true)
            {
                SystemSounds.Beep.Play();
            }
        }

        

        private void buttonAlarmOff_Click(object sender, EventArgs e)
        {
            alarmOn = false;
        }

        #endregion
    }
}
