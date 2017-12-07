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
            this.lblBloodType = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDOB = new System.Windows.Forms.TextBox();
            this.txtBloodType = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnAddRecord = new System.Windows.Forms.Button();
            this.txtComplications = new System.Windows.Forms.TextBox();
            this.lstHistory = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtPatientID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtInsuranceID = new System.Windows.Forms.TextBox();
            this.txtGender = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtlastname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnnew = new System.Windows.Forms.Button();
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
            this.lblAge.Location = new System.Drawing.Point(283, 36);
            this.lblAge.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(33, 13);
            this.lblAge.TabIndex = 20;
            this.lblAge.Text = "DOB:";
            // 
            // lblBloodType
            // 
            this.lblBloodType.AutoSize = true;
            this.lblBloodType.Location = new System.Drawing.Point(12, 36);
            this.lblBloodType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBloodType.Name = "lblBloodType";
            this.lblBloodType.Size = new System.Drawing.Size(64, 13);
            this.lblBloodType.TabIndex = 18;
            this.lblBloodType.Text = "Blood Type:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Name:";
            // 
            // txtDOB
            // 
            this.txtDOB.Location = new System.Drawing.Point(345, 33);
            this.txtDOB.Margin = new System.Windows.Forms.Padding(2);
            this.txtDOB.Name = "txtDOB";
            this.txtDOB.Size = new System.Drawing.Size(128, 20);
            this.txtDOB.TabIndex = 16;
            // 
            // txtBloodType
            // 
            this.txtBloodType.Location = new System.Drawing.Point(82, 33);
            this.txtBloodType.Margin = new System.Windows.Forms.Padding(2);
            this.txtBloodType.Name = "txtBloodType";
            this.txtBloodType.Size = new System.Drawing.Size(128, 20);
            this.txtBloodType.TabIndex = 15;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(82, 9);
            this.txtName.Margin = new System.Windows.Forms.Padding(2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(128, 20);
            this.txtName.TabIndex = 13;
            // 
            // btnAddRecord
            // 
            this.btnAddRecord.Location = new System.Drawing.Point(480, 64);
            this.btnAddRecord.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddRecord.Name = "btnAddRecord";
            this.btnAddRecord.Size = new System.Drawing.Size(55, 40);
            this.btnAddRecord.TabIndex = 24;
            this.btnAddRecord.Text = "Add Record";
            this.btnAddRecord.UseVisualStyleBackColor = true;
            this.btnAddRecord.Click += new System.EventHandler(this.btnAddRecord_Click);
            // 
            // txtComplications
            // 
            this.txtComplications.Location = new System.Drawing.Point(4, 108);
            this.txtComplications.Margin = new System.Windows.Forms.Padding(2);
            this.txtComplications.Multiline = true;
            this.txtComplications.Name = "txtComplications";
            this.txtComplications.Size = new System.Drawing.Size(522, 118);
            this.txtComplications.TabIndex = 22;
            // 
            // lstHistory
            // 
            this.lstHistory.FormattingEnabled = true;
            this.lstHistory.Location = new System.Drawing.Point(539, 2);
            this.lstHistory.Margin = new System.Windows.Forms.Padding(2);
            this.lstHistory.Name = "lstHistory";
            this.lstHistory.Size = new System.Drawing.Size(105, 225);
            this.lstHistory.TabIndex = 36;
            this.lstHistory.SelectedIndexChanged += new System.EventHandler(this.lstHistory_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.btnnew);
            this.panel1.Controls.Add(this.txtPatientID);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtInsuranceID);
            this.panel1.Controls.Add(this.txtGender);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtAddress);
            this.panel1.Controls.Add(this.btnAddRecord);
            this.panel1.Controls.Add(this.txtComplications);
            this.panel1.Controls.Add(this.txtlastname);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lstHistory);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.txtDOB);
            this.panel1.Controls.Add(this.lblAge);
            this.panel1.Controls.Add(this.lblBloodType);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtBloodType);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(10, 107);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(646, 229);
            this.panel1.TabIndex = 37;
            // 
            // txtPatientID
            // 
            this.txtPatientID.Location = new System.Drawing.Point(348, 85);
            this.txtPatientID.Margin = new System.Windows.Forms.Padding(2);
            this.txtPatientID.Name = "txtPatientID";
            this.txtPatientID.ReadOnly = true;
            this.txtPatientID.Size = new System.Drawing.Size(128, 20);
            this.txtPatientID.TabIndex = 45;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(278, 90);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 46;
            this.label3.Text = "PatientID:";
            // 
            // txtInsuranceID
            // 
            this.txtInsuranceID.Location = new System.Drawing.Point(82, 59);
            this.txtInsuranceID.Margin = new System.Windows.Forms.Padding(2);
            this.txtInsuranceID.Name = "txtInsuranceID";
            this.txtInsuranceID.Size = new System.Drawing.Size(128, 20);
            this.txtInsuranceID.TabIndex = 39;
            // 
            // txtGender
            // 
            this.txtGender.Location = new System.Drawing.Point(348, 59);
            this.txtGender.Margin = new System.Windows.Forms.Padding(2);
            this.txtGender.Name = "txtGender";
            this.txtGender.Size = new System.Drawing.Size(128, 20);
            this.txtGender.TabIndex = 41;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(278, 62);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 44;
            this.label4.Text = "Gender:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 88);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 43;
            this.label5.Text = "Address:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 64);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 42;
            this.label6.Text = "InsuranceID:";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(82, 83);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(2);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(128, 20);
            this.txtAddress.TabIndex = 40;
            // 
            // txtlastname
            // 
            this.txtlastname.Location = new System.Drawing.Point(345, 9);
            this.txtlastname.Margin = new System.Windows.Forms.Padding(2);
            this.txtlastname.Name = "txtlastname";
            this.txtlastname.Size = new System.Drawing.Size(128, 20);
            this.txtlastname.TabIndex = 37;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(275, 12);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 38;
            this.label2.Text = "Last Name:";
            // 
            // btnnew
            // 
            this.btnnew.Enabled = false;
            this.btnnew.Location = new System.Drawing.Point(480, 12);
            this.btnnew.Name = "btnnew";
            this.btnnew.Size = new System.Drawing.Size(54, 47);
            this.btnnew.TabIndex = 47;
            this.btnnew.Text = "New Patient";
            this.btnnew.UseVisualStyleBackColor = true;
            this.btnnew.Click += new System.EventHandler(this.btnnew_Click);
            // 
            // Patient_Information_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblComplications);
            this.Name = "Patient_Information_View";
            this.Padding = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.Size = new System.Drawing.Size(666, 345);
            this.ViewColour = System.Drawing.Color.Orchid;
            this.ViewDescription = "";
            this.ViewTitle = "Patient Information";
            this.Controls.SetChildIndex(this.lblComplications, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblComplications;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblBloodType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDOB;
        private System.Windows.Forms.TextBox txtBloodType;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnAddRecord;
        private System.Windows.Forms.TextBox txtComplications;
        private System.Windows.Forms.ListBox lstHistory;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtlastname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPatientID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtInsuranceID;
        private System.Windows.Forms.TextBox txtGender;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Button btnnew;
    }
}
