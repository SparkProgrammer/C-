namespace Tutorial2
{
    partial class Form1
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
            this.buttonSave_Comments = new System.Windows.Forms.Button();
            this.buttonShowData = new System.Windows.Forms.Button();
            this.textBox_employeeName = new System.Windows.Forms.TextBox();
            this.textBoxAge = new System.Windows.Forms.TextBox();
            this.textBoxDate_Hired = new System.Windows.Forms.TextBox();
            this.textBoxYearly_Income = new System.Windows.Forms.TextBox();
            this.textBoxPay_Rate = new System.Windows.Forms.TextBox();
            this.textBoxComments = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonClearFields = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonSave_Comments
            // 
            this.buttonSave_Comments.Location = new System.Drawing.Point(559, 321);
            this.buttonSave_Comments.Name = "buttonSave_Comments";
            this.buttonSave_Comments.Size = new System.Drawing.Size(198, 27);
            this.buttonSave_Comments.TabIndex = 0;
            this.buttonSave_Comments.Text = "Save Comments";
            this.buttonSave_Comments.UseVisualStyleBackColor = true;
            this.buttonSave_Comments.Click += new System.EventHandler(this.buttonSave_Comments_Click);
            // 
            // buttonShowData
            // 
            this.buttonShowData.Location = new System.Drawing.Point(559, 371);
            this.buttonShowData.Name = "buttonShowData";
            this.buttonShowData.Size = new System.Drawing.Size(198, 27);
            this.buttonShowData.TabIndex = 1;
            this.buttonShowData.Text = "Show &Data";
            this.buttonShowData.UseVisualStyleBackColor = true;
            this.buttonShowData.Click += new System.EventHandler(this.buttonShowData_Click);
            // 
            // textBox_employeeName
            // 
            this.textBox_employeeName.Location = new System.Drawing.Point(348, 43);
            this.textBox_employeeName.Name = "textBox_employeeName";
            this.textBox_employeeName.Size = new System.Drawing.Size(381, 22);
            this.textBox_employeeName.TabIndex = 2;
            // 
            // textBoxAge
            // 
            this.textBoxAge.Location = new System.Drawing.Point(93, 136);
            this.textBoxAge.Name = "textBoxAge";
            this.textBoxAge.Size = new System.Drawing.Size(117, 22);
            this.textBoxAge.TabIndex = 3;
            // 
            // textBoxDate_Hired
            // 
            this.textBoxDate_Hired.Location = new System.Drawing.Point(503, 136);
            this.textBoxDate_Hired.Name = "textBoxDate_Hired";
            this.textBoxDate_Hired.Size = new System.Drawing.Size(226, 22);
            this.textBoxDate_Hired.TabIndex = 4;
            // 
            // textBoxYearly_Income
            // 
            this.textBoxYearly_Income.Location = new System.Drawing.Point(140, 209);
            this.textBoxYearly_Income.Name = "textBoxYearly_Income";
            this.textBoxYearly_Income.Size = new System.Drawing.Size(196, 22);
            this.textBoxYearly_Income.TabIndex = 5;
            // 
            // textBoxPay_Rate
            // 
            this.textBoxPay_Rate.Location = new System.Drawing.Point(612, 209);
            this.textBoxPay_Rate.Name = "textBoxPay_Rate";
            this.textBoxPay_Rate.Size = new System.Drawing.Size(117, 22);
            this.textBoxPay_Rate.TabIndex = 6;
            // 
            // textBoxComments
            // 
            this.textBoxComments.Location = new System.Drawing.Point(52, 286);
            this.textBoxComments.Multiline = true;
            this.textBoxComments.Name = "textBoxComments";
            this.textBoxComments.Size = new System.Drawing.Size(284, 161);
            this.textBoxComments.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(227, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Employee Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Age:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(417, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Date Hired:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Yearly Income";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(540, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Pay Rate";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(49, 266);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Comments:";
            // 
            // buttonClearFields
            // 
            this.buttonClearFields.Location = new System.Drawing.Point(559, 420);
            this.buttonClearFields.Name = "buttonClearFields";
            this.buttonClearFields.Size = new System.Drawing.Size(198, 27);
            this.buttonClearFields.TabIndex = 14;
            this.buttonClearFields.Text = "Clear Fields";
            this.buttonClearFields.UseVisualStyleBackColor = true;
            this.buttonClearFields.Click += new System.EventHandler(this.buttonClearFields_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 495);
            this.Controls.Add(this.buttonClearFields);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxComments);
            this.Controls.Add(this.textBoxPay_Rate);
            this.Controls.Add(this.textBoxYearly_Income);
            this.Controls.Add(this.textBoxDate_Hired);
            this.Controls.Add(this.textBoxAge);
            this.Controls.Add(this.textBox_employeeName);
            this.Controls.Add(this.buttonShowData);
            this.Controls.Add(this.buttonSave_Comments);
            this.Name = "Form1";
            this.Text = "Employee Data";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSave_Comments;
        private System.Windows.Forms.Button buttonShowData;
        private System.Windows.Forms.TextBox textBox_employeeName;
        private System.Windows.Forms.TextBox textBoxAge;
        private System.Windows.Forms.TextBox textBoxDate_Hired;
        private System.Windows.Forms.TextBox textBoxYearly_Income;
        private System.Windows.Forms.TextBox textBoxPay_Rate;
        private System.Windows.Forms.TextBox textBoxComments;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonClearFields;
    }
}

