namespace Lesson_5___Debug_GUI_Errors
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBoxEmployees = new System.Windows.Forms.ListBox();
            this.buttonShow = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxEmployees
            // 
            this.listBoxEmployees.FormattingEnabled = true;
            this.listBoxEmployees.Location = new System.Drawing.Point(13, 13);
            this.listBoxEmployees.Name = "listBoxEmployees";
            this.listBoxEmployees.Size = new System.Drawing.Size(300, 329);
            this.listBoxEmployees.TabIndex = 0;
            // 
            // buttonShow
            // 
            this.buttonShow.Location = new System.Drawing.Point(320, 38);
            this.buttonShow.Name = "buttonShow";
            this.buttonShow.Size = new System.Drawing.Size(111, 37);
            this.buttonShow.TabIndex = 1;
            this.buttonShow.Text = "&Show";
            this.buttonShow.UseVisualStyleBackColor = true;
            this.buttonShow.Click += new System.EventHandler(this.buttonShow_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 362);
            this.Controls.Add(this.buttonShow);
            this.Controls.Add(this.listBoxEmployees);
            this.Name = "MainForm";
            this.Text = "Error Form";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxEmployees;
        private System.Windows.Forms.Button buttonShow;
    }
}

