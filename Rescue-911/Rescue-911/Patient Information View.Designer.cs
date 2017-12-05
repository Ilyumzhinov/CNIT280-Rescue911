namespace Rescue_911
{
    partial class Patient_Information_View
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblComplications = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblBirthDate = new System.Windows.Forms.Label();
            this.lblBloodType = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtBloodType = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnAddRecord = new System.Windows.Forms.Button();
            this.txtComplications = new System.Windows.Forms.TextBox();
            this.DTPBirthDate = new System.Windows.Forms.DateTimePicker();
            this.lstHistory = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblComplications
            // 
            this.lblComplications.AutoSize = true;
            this.lblComplications.Location = new System.Drawing.Point(27, 367);
            this.lblComplications.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblComplications.Name = "lblComplications";
            this.lblComplications.Size = new System.Drawing.Size(147, 25);
            this.lblComplications.TabIndex = 21;
            this.lblComplications.Text = "Complications";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(546, 285);
            this.lblAge.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(56, 25);
            this.lblAge.TabIndex = 20;
            this.lblAge.Text = "Age:";
            // 
            // lblBirthDate
            // 
            this.lblBirthDate.AutoSize = true;
            this.lblBirthDate.Location = new System.Drawing.Point(526, 17);
            this.lblBirthDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBirthDate.Name = "lblBirthDate";
            this.lblBirthDate.Size = new System.Drawing.Size(113, 25);
            this.lblBirthDate.TabIndex = 19;
            this.lblBirthDate.Text = "Birth Date:";
            // 
            // lblBloodType
            // 
            this.lblBloodType.AutoSize = true;
            this.lblBloodType.Location = new System.Drawing.Point(28, 285);
            this.lblBloodType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBloodType.Name = "lblBloodType";
            this.lblBloodType.Size = new System.Drawing.Size(127, 25);
            this.lblBloodType.TabIndex = 18;
            this.lblBloodType.Text = "Blood Type:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 25);
            this.label1.TabIndex = 17;
            this.label1.Text = "Name:";
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(677, 282);
            this.txtAge.Margin = new System.Windows.Forms.Padding(4);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(226, 31);
            this.txtAge.TabIndex = 16;
            // 
            // txtBloodType
            // 
            this.txtBloodType.Location = new System.Drawing.Point(168, 282);
            this.txtBloodType.Margin = new System.Windows.Forms.Padding(4);
            this.txtBloodType.Name = "txtBloodType";
            this.txtBloodType.Size = new System.Drawing.Size(252, 31);
            this.txtBloodType.TabIndex = 15;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(148, 14);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(252, 31);
            this.txtName.TabIndex = 13;
            // 
            // btnAddRecord
            // 
            this.btnAddRecord.Location = new System.Drawing.Point(891, 346);
            this.btnAddRecord.Name = "btnAddRecord";
            this.btnAddRecord.Size = new System.Drawing.Size(161, 46);
            this.btnAddRecord.TabIndex = 24;
            this.btnAddRecord.Text = "Add Record";
            this.btnAddRecord.UseVisualStyleBackColor = true;
            this.btnAddRecord.Click += new System.EventHandler(this.btnAddRecord_Click);
            // 
            // txtComplications
            // 
            this.txtComplications.Location = new System.Drawing.Point(51, 396);
            this.txtComplications.Margin = new System.Windows.Forms.Padding(4);
            this.txtComplications.Multiline = true;
            this.txtComplications.Name = "txtComplications";
            this.txtComplications.Size = new System.Drawing.Size(1040, 223);
            this.txtComplications.TabIndex = 22;
            // 
            // DTPBirthDate
            // 
            this.DTPBirthDate.Location = new System.Drawing.Point(657, 12);
            this.DTPBirthDate.Margin = new System.Windows.Forms.Padding(6);
            this.DTPBirthDate.Name = "DTPBirthDate";
            this.DTPBirthDate.Size = new System.Drawing.Size(396, 31);
            this.DTPBirthDate.TabIndex = 35;
            // 
            // lstHistory
            // 
            this.lstHistory.FormattingEnabled = true;
            this.lstHistory.ItemHeight = 25;
            this.lstHistory.Location = new System.Drawing.Point(1078, 12);
            this.lstHistory.Name = "lstHistory";
            this.lstHistory.Size = new System.Drawing.Size(206, 429);
            this.lstHistory.TabIndex = 36;
            this.lstHistory.SelectedIndexChanged += new System.EventHandler(this.lstHistory_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.DTPBirthDate);
            this.panel1.Controls.Add(this.lstHistory);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblBirthDate);
            this.panel1.Location = new System.Drawing.Point(20, 178);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1287, 451);
            this.panel1.TabIndex = 37;
            // 
            // Patient_Information_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnAddRecord);
            this.Controls.Add(this.txtComplications);
            this.Controls.Add(this.lblComplications);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.lblBloodType);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.txtBloodType);
            this.Controls.Add(this.panel1);
            this.Name = "Patient_Information_View";
            this.Padding = new System.Windows.Forms.Padding(20, 17, 20, 17);
            this.Size = new System.Drawing.Size(1366, 643);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.txtBloodType, 0);
            this.Controls.SetChildIndex(this.txtAge, 0);
            this.Controls.SetChildIndex(this.lblBloodType, 0);
            this.Controls.SetChildIndex(this.lblAge, 0);
            this.Controls.SetChildIndex(this.lblComplications, 0);
            this.Controls.SetChildIndex(this.txtComplications, 0);
            this.Controls.SetChildIndex(this.btnAddRecord, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblComplications;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblBirthDate;
        private System.Windows.Forms.Label lblBloodType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtBloodType;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnAddRecord;
        private System.Windows.Forms.TextBox txtComplications;
        private System.Windows.Forms.DateTimePicker DTPBirthDate;
        private System.Windows.Forms.ListBox lstHistory;
        private System.Windows.Forms.Panel panel1;
    }
}
