namespace Rescue_911
{
    partial class EMT_Patient_Information
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
            this.lblInformation = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblBloodType = new System.Windows.Forms.Label();
            this.lblBirthDate = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtBirthdate = new System.Windows.Forms.TextBox();
            this.txtBloodType = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtComplications = new System.Windows.Forms.TextBox();
            this.lblPreviousComplications = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblInformation
            // 
            this.lblInformation.AutoSize = true;
            this.lblInformation.Font = new System.Drawing.Font("Franklin Gothic Heavy", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInformation.Location = new System.Drawing.Point(12, 9);
            this.lblInformation.Name = "lblInformation";
            this.lblInformation.Size = new System.Drawing.Size(448, 47);
            this.lblInformation.TabIndex = 1;
            this.lblInformation.Text = "PATIENT INFORMATION";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(31, 144);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(51, 19);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Name";
            // 
            // lblBloodType
            // 
            this.lblBloodType.AutoSize = true;
            this.lblBloodType.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBloodType.Location = new System.Drawing.Point(31, 235);
            this.lblBloodType.Name = "lblBloodType";
            this.lblBloodType.Size = new System.Drawing.Size(90, 19);
            this.lblBloodType.TabIndex = 3;
            this.lblBloodType.Text = "Blood Type";
            // 
            // lblBirthDate
            // 
            this.lblBirthDate.AutoSize = true;
            this.lblBirthDate.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBirthDate.Location = new System.Drawing.Point(617, 144);
            this.lblBirthDate.Name = "lblBirthDate";
            this.lblBirthDate.Size = new System.Drawing.Size(74, 19);
            this.lblBirthDate.TabIndex = 4;
            this.lblBirthDate.Text = "Birthdate";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAge.Location = new System.Drawing.Point(617, 235);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(38, 19);
            this.lblAge.TabIndex = 5;
            this.lblAge.Text = "Age";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(125, 143);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(264, 22);
            this.txtName.TabIndex = 6;
            this.txtName.TextChanged += new System.EventHandler(this.txtRecordDate_TextChanged);
            // 
            // txtBirthdate
            // 
            this.txtBirthdate.Location = new System.Drawing.Point(712, 141);
            this.txtBirthdate.Name = "txtBirthdate";
            this.txtBirthdate.ReadOnly = true;
            this.txtBirthdate.Size = new System.Drawing.Size(264, 22);
            this.txtBirthdate.TabIndex = 7;
            // 
            // txtBloodType
            // 
            this.txtBloodType.Location = new System.Drawing.Point(125, 237);
            this.txtBloodType.Name = "txtBloodType";
            this.txtBloodType.ReadOnly = true;
            this.txtBloodType.Size = new System.Drawing.Size(264, 22);
            this.txtBloodType.TabIndex = 8;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(712, 237);
            this.txtAge.Name = "txtAge";
            this.txtAge.ReadOnly = true;
            this.txtAge.Size = new System.Drawing.Size(264, 22);
            this.txtAge.TabIndex = 9;
            // 
            // txtComplications
            // 
            this.txtComplications.Location = new System.Drawing.Point(35, 366);
            this.txtComplications.Multiline = true;
            this.txtComplications.Name = "txtComplications";
            this.txtComplications.ReadOnly = true;
            this.txtComplications.Size = new System.Drawing.Size(956, 64);
            this.txtComplications.TabIndex = 10;
            // 
            // lblPreviousComplications
            // 
            this.lblPreviousComplications.AutoSize = true;
            this.lblPreviousComplications.Location = new System.Drawing.Point(32, 346);
            this.lblPreviousComplications.Name = "lblPreviousComplications";
            this.lblPreviousComplications.Size = new System.Drawing.Size(154, 17);
            this.lblPreviousComplications.TabIndex = 11;
            this.lblPreviousComplications.Text = "Previous Complications";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(484, 453);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 12;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // EMT_Patient_Information
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 497);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblPreviousComplications);
            this.Controls.Add(this.txtComplications);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.txtBloodType);
            this.Controls.Add(this.txtBirthdate);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.lblBirthDate);
            this.Controls.Add(this.lblBloodType);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblInformation);
            this.Name = "EMT_Patient_Information";
            this.Text = "EMT_Patient_Information";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInformation;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblBloodType;
        private System.Windows.Forms.Label lblBirthDate;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtBirthdate;
        private System.Windows.Forms.TextBox txtBloodType;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtComplications;
        private System.Windows.Forms.Label lblPreviousComplications;
        private System.Windows.Forms.Button btnSearch;
    }
}