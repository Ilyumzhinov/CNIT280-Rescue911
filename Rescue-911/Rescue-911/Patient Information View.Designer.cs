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
            this.lblComplications.Location = new System.Drawing.Point(14, 191);
            this.lblComplications.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblComplications.Name = "lblComplications";
            this.lblComplications.Size = new System.Drawing.Size(72, 13);
            this.lblComplications.TabIndex = 21;
            this.lblComplications.Text = "Complications";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(273, 148);
            this.lblAge.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(29, 13);
            this.lblAge.TabIndex = 20;
            this.lblAge.Text = "Age:";
            // 
            // lblBirthDate
            // 
            this.lblBirthDate.AutoSize = true;
            this.lblBirthDate.Location = new System.Drawing.Point(263, 9);
            this.lblBirthDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBirthDate.Name = "lblBirthDate";
            this.lblBirthDate.Size = new System.Drawing.Size(57, 13);
            this.lblBirthDate.TabIndex = 19;
            this.lblBirthDate.Text = "Birth Date:";
            // 
            // lblBloodType
            // 
            this.lblBloodType.AutoSize = true;
            this.lblBloodType.Location = new System.Drawing.Point(14, 148);
            this.lblBloodType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBloodType.Name = "lblBloodType";
            this.lblBloodType.Size = new System.Drawing.Size(64, 13);
            this.lblBloodType.TabIndex = 18;
            this.lblBloodType.Text = "Blood Type:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Name:";
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(338, 147);
            this.txtAge.Margin = new System.Windows.Forms.Padding(2);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(115, 20);
            this.txtAge.TabIndex = 16;
            // 
            // txtBloodType
            // 
            this.txtBloodType.Location = new System.Drawing.Point(84, 147);
            this.txtBloodType.Margin = new System.Windows.Forms.Padding(2);
            this.txtBloodType.Name = "txtBloodType";
            this.txtBloodType.Size = new System.Drawing.Size(128, 20);
            this.txtBloodType.TabIndex = 15;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(74, 7);
            this.txtName.Margin = new System.Windows.Forms.Padding(2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(128, 20);
            this.txtName.TabIndex = 13;
            // 
            // btnAddRecord
            // 
            this.btnAddRecord.Location = new System.Drawing.Point(446, 180);
            this.btnAddRecord.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddRecord.Name = "btnAddRecord";
            this.btnAddRecord.Size = new System.Drawing.Size(80, 24);
            this.btnAddRecord.TabIndex = 24;
            this.btnAddRecord.Text = "Add Record";
            this.btnAddRecord.UseVisualStyleBackColor = true;
            this.btnAddRecord.Click += new System.EventHandler(this.btnAddRecord_Click);
            // 
            // txtComplications
            // 
            this.txtComplications.Location = new System.Drawing.Point(26, 206);
            this.txtComplications.Margin = new System.Windows.Forms.Padding(2);
            this.txtComplications.Multiline = true;
            this.txtComplications.Name = "txtComplications";
            this.txtComplications.Size = new System.Drawing.Size(522, 118);
            this.txtComplications.TabIndex = 22;
            // 
            // DTPBirthDate
            // 
            this.DTPBirthDate.Location = new System.Drawing.Point(328, 6);
            this.DTPBirthDate.Name = "DTPBirthDate";
            this.DTPBirthDate.Size = new System.Drawing.Size(200, 20);
            this.DTPBirthDate.TabIndex = 35;
            // 
            // lstHistory
            // 
            this.lstHistory.FormattingEnabled = true;
            this.lstHistory.Location = new System.Drawing.Point(539, 7);
            this.lstHistory.Margin = new System.Windows.Forms.Padding(2);
            this.lstHistory.Name = "lstHistory";
            this.lstHistory.Size = new System.Drawing.Size(105, 225);
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
            this.panel1.Location = new System.Drawing.Point(10, 93);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(644, 235);
            this.panel1.TabIndex = 37;
            // 
            // Patient_Information_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
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
            this.Padding = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.Size = new System.Drawing.Size(683, 334);
            this.ViewColour = System.Drawing.Color.Orchid;
            this.ViewDescription = "";
            this.ViewTitle = "Patient Information";
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
