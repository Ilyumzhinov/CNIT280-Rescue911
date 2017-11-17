namespace Rescue_911
{
    partial class Patient_Information_Form
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
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtBirthdate = new System.Windows.Forms.TextBox();
            this.txtBloodType = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblBloodType = new System.Windows.Forms.Label();
            this.lblBirthDate = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblComplications = new System.Windows.Forms.Label();
            this.txtComplications = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(217, 301);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(93, 26);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(81, 61);
            this.txtName.Margin = new System.Windows.Forms.Padding(2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(128, 20);
            this.txtName.TabIndex = 2;
            // 
            // txtBirthdate
            // 
            this.txtBirthdate.Location = new System.Drawing.Point(377, 61);
            this.txtBirthdate.Margin = new System.Windows.Forms.Padding(2);
            this.txtBirthdate.Name = "txtBirthdate";
            this.txtBirthdate.ReadOnly = true;
            this.txtBirthdate.Size = new System.Drawing.Size(116, 20);
            this.txtBirthdate.TabIndex = 3;
            this.txtBirthdate.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtBloodType
            // 
            this.txtBloodType.Location = new System.Drawing.Point(81, 151);
            this.txtBloodType.Margin = new System.Windows.Forms.Padding(2);
            this.txtBloodType.Name = "txtBloodType";
            this.txtBloodType.ReadOnly = true;
            this.txtBloodType.Size = new System.Drawing.Size(128, 20);
            this.txtBloodType.TabIndex = 4;
            this.txtBloodType.TextChanged += new System.EventHandler(this.txtBloodType_TextChanged);
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(366, 155);
            this.txtAge.Margin = new System.Windows.Forms.Padding(2);
            this.txtAge.Name = "txtAge";
            this.txtAge.ReadOnly = true;
            this.txtAge.Size = new System.Drawing.Size(116, 20);
            this.txtAge.TabIndex = 5;
            this.txtAge.TextChanged += new System.EventHandler(this.txtAge_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 64);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Name";
            // 
            // lblBloodType
            // 
            this.lblBloodType.AutoSize = true;
            this.lblBloodType.Location = new System.Drawing.Point(0, 155);
            this.lblBloodType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBloodType.Name = "lblBloodType";
            this.lblBloodType.Size = new System.Drawing.Size(61, 13);
            this.lblBloodType.TabIndex = 7;
            this.lblBloodType.Text = "Blood Type";
            // 
            // lblBirthDate
            // 
            this.lblBirthDate.AutoSize = true;
            this.lblBirthDate.Location = new System.Drawing.Point(318, 64);
            this.lblBirthDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBirthDate.Name = "lblBirthDate";
            this.lblBirthDate.Size = new System.Drawing.Size(54, 13);
            this.lblBirthDate.TabIndex = 8;
            this.lblBirthDate.Text = "Birth Date";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(327, 155);
            this.lblAge.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(26, 13);
            this.lblAge.TabIndex = 9;
            this.lblAge.Text = "Age";
            // 
            // lblComplications
            // 
            this.lblComplications.AutoSize = true;
            this.lblComplications.Location = new System.Drawing.Point(12, 201);
            this.lblComplications.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblComplications.Name = "lblComplications";
            this.lblComplications.Size = new System.Drawing.Size(72, 13);
            this.lblComplications.TabIndex = 10;
            this.lblComplications.Text = "Complications";
            // 
            // txtComplications
            // 
            this.txtComplications.Location = new System.Drawing.Point(14, 217);
            this.txtComplications.Margin = new System.Windows.Forms.Padding(2);
            this.txtComplications.Multiline = true;
            this.txtComplications.Name = "txtComplications";
            this.txtComplications.ReadOnly = true;
            this.txtComplications.Size = new System.Drawing.Size(480, 54);
            this.txtComplications.TabIndex = 11;
            this.txtComplications.TextChanged += new System.EventHandler(this.txtComplications_TextChanged);
            // 
            // Patient_Information_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 339);
            this.Controls.Add(this.txtComplications);
            this.Controls.Add(this.lblComplications);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.lblBirthDate);
            this.Controls.Add(this.lblBloodType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.txtBloodType);
            this.Controls.Add(this.txtBirthdate);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnSearch);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Patient_Information_Form";
            this.Text = "Patient Information Form";
            this.Load += new System.EventHandler(this.Patient_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtBirthdate;
        private System.Windows.Forms.TextBox txtBloodType;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblBloodType;
        private System.Windows.Forms.Label lblBirthDate;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblComplications;
        private System.Windows.Forms.TextBox txtComplications;
    }
}