namespace Tutorial6
{
    partial class AlarmForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.labelTime = new System.Windows.Forms.Label();
            this.numericUpDownMinuteSelector = new System.Windows.Forms.NumericUpDown();
            this.labelInstruction = new System.Windows.Forms.Label();
            this.buttonSetAlarm = new System.Windows.Forms.Button();
            this.timerSecond = new System.Windows.Forms.Timer(this.components);
            this.buttonAlarmOff = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinuteSelector)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTime
            // 
            this.labelTime.Font = new System.Drawing.Font("Trebuchet MS", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTime.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelTime.Location = new System.Drawing.Point(109, 51);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(682, 176);
            this.labelTime.TabIndex = 0;
            this.labelTime.Text = "hh:mm:pm";
            this.labelTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numericUpDownMinuteSelector
            // 
            this.numericUpDownMinuteSelector.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownMinuteSelector.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.numericUpDownMinuteSelector.Location = new System.Drawing.Point(111, 266);
            this.numericUpDownMinuteSelector.Maximum = new decimal(new int[] {
            1440,
            0,
            0,
            0});
            this.numericUpDownMinuteSelector.Name = "numericUpDownMinuteSelector";
            this.numericUpDownMinuteSelector.Size = new System.Drawing.Size(120, 98);
            this.numericUpDownMinuteSelector.TabIndex = 1;
            // 
            // labelInstruction
            // 
            this.labelInstruction.AutoSize = true;
            this.labelInstruction.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInstruction.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelInstruction.Location = new System.Drawing.Point(106, 381);
            this.labelInstruction.Name = "labelInstruction";
            this.labelInstruction.Size = new System.Drawing.Size(207, 29);
            this.labelInstruction.TabIndex = 2;
            this.labelInstruction.Text = "Minutes from Now";
            // 
            // buttonSetAlarm
            // 
            this.buttonSetAlarm.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSetAlarm.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.buttonSetAlarm.Location = new System.Drawing.Point(333, 266);
            this.buttonSetAlarm.Name = "buttonSetAlarm";
            this.buttonSetAlarm.Size = new System.Drawing.Size(173, 144);
            this.buttonSetAlarm.TabIndex = 3;
            this.buttonSetAlarm.Text = "&Set Alarm";
            this.buttonSetAlarm.UseVisualStyleBackColor = true;
            this.buttonSetAlarm.Click += new System.EventHandler(this.buttonSetAlarm_Click);
            // 
            // timerSecond
            // 
            this.timerSecond.Enabled = true;
            this.timerSecond.Interval = 1000;
            this.timerSecond.Tick += new System.EventHandler(this.timerSecond_Tick);
            // 
            // buttonAlarmOff
            // 
            this.buttonAlarmOff.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAlarmOff.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.buttonAlarmOff.Location = new System.Drawing.Point(561, 266);
            this.buttonAlarmOff.Name = "buttonAlarmOff";
            this.buttonAlarmOff.Size = new System.Drawing.Size(173, 144);
            this.buttonAlarmOff.TabIndex = 4;
            this.buttonAlarmOff.Text = "Alarm &Off";
            this.buttonAlarmOff.UseVisualStyleBackColor = true;
            this.buttonAlarmOff.Click += new System.EventHandler(this.buttonAlarmOff_Click);
            // 
            // AlarmForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(882, 503);
            this.Controls.Add(this.buttonAlarmOff);
            this.Controls.Add(this.buttonSetAlarm);
            this.Controls.Add(this.labelInstruction);
            this.Controls.Add(this.numericUpDownMinuteSelector);
            this.Controls.Add(this.labelTime);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AlarmForm";
            this.Text = "Alarm Clock";
            this.Load += new System.EventHandler(this.AlarmForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinuteSelector)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.NumericUpDown numericUpDownMinuteSelector;
        private System.Windows.Forms.Label labelInstruction;
        private System.Windows.Forms.Button buttonSetAlarm;
        private System.Windows.Forms.Timer timerSecond;
        private System.Windows.Forms.Button buttonAlarmOff;
    }
}

