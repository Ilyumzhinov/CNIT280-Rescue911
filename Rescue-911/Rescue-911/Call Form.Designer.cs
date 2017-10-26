namespace Rescue_911
{
    partial class CallForm
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
            this.btnSubmit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lb11 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtLandmark = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCallDateTime = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboCallPriority = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTeamsReq = new System.Windows.Forms.TextBox();
            this.lbCallID = new System.Windows.Forms.Label();
            this.lbCallState = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCallerName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.lstCallerNames = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCallerLastName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.pnCaller = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.btnLink = new System.Windows.Forms.Button();
            this.pnCaller.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(648, 393);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(150, 23);
            this.btnSubmit.TabIndex = 0;
            this.btnSubmit.Text = "Create New Emergency";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Heavy", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(333, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "CALL LOGGING FORM";
            // 
            // lb11
            // 
            this.lb11.AutoSize = true;
            this.lb11.ForeColor = System.Drawing.Color.DimGray;
            this.lb11.Location = new System.Drawing.Point(16, 48);
            this.lb11.Name = "lb11";
            this.lb11.Size = new System.Drawing.Size(50, 13);
            this.lb11.TabIndex = 2;
            this.lb11.Text = "Caller ID:";
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(127, 29);
            this.txtAddress.MinimumSize = new System.Drawing.Size(120, 20);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(252, 22);
            this.txtAddress.TabIndex = 16;
            this.txtAddress.Leave += new System.EventHandler(this.txtAddress_Leave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 35);
            this.label8.MinimumSize = new System.Drawing.Size(120, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 16);
            this.label8.TabIndex = 15;
            this.label8.Text = "Address";
            // 
            // txtLandmark
            // 
            this.txtLandmark.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLandmark.Location = new System.Drawing.Point(127, 63);
            this.txtLandmark.MinimumSize = new System.Drawing.Size(120, 20);
            this.txtLandmark.Name = "txtLandmark";
            this.txtLandmark.Size = new System.Drawing.Size(252, 22);
            this.txtLandmark.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DimGray;
            this.label9.Location = new System.Drawing.Point(4, 67);
            this.label9.MinimumSize = new System.Drawing.Size(120, 13);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 16);
            this.label9.TabIndex = 17;
            this.label9.Text = "Landmark";
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(127, 95);
            this.txtDescription.MinimumSize = new System.Drawing.Size(120, 20);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(252, 140);
            this.txtDescription.TabIndex = 20;
            this.txtDescription.Leave += new System.EventHandler(this.txtDescription_Leave);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(4, 101);
            this.label10.MinimumSize = new System.Drawing.Size(120, 13);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(120, 16);
            this.label10.TabIndex = 19;
            this.label10.Text = "Description";
            // 
            // txtCallDateTime
            // 
            this.txtCallDateTime.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCallDateTime.Location = new System.Drawing.Point(129, 29);
            this.txtCallDateTime.MinimumSize = new System.Drawing.Size(120, 20);
            this.txtCallDateTime.Name = "txtCallDateTime";
            this.txtCallDateTime.ReadOnly = true;
            this.txtCallDateTime.Size = new System.Drawing.Size(252, 22);
            this.txtCallDateTime.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 35);
            this.label2.MinimumSize = new System.Drawing.Size(120, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Date/Time";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 67);
            this.label3.MinimumSize = new System.Drawing.Size(120, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Priority";
            // 
            // cboCallPriority
            // 
            this.cboCallPriority.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCallPriority.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCallPriority.FormattingEnabled = true;
            this.cboCallPriority.Items.AddRange(new object[] {
            "Minor incident",
            "Stable case",
            "Serious case",
            "Critical trauma"});
            this.cboCallPriority.Location = new System.Drawing.Point(127, 61);
            this.cboCallPriority.Name = "cboCallPriority";
            this.cboCallPriority.Size = new System.Drawing.Size(253, 24);
            this.cboCallPriority.TabIndex = 6;
            this.cboCallPriority.SelectedIndexChanged += new System.EventHandler(this.cboCallPriority_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 101);
            this.label4.MinimumSize = new System.Drawing.Size(120, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Team req.";
            // 
            // txtTeamsReq
            // 
            this.txtTeamsReq.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTeamsReq.Location = new System.Drawing.Point(127, 95);
            this.txtTeamsReq.MinimumSize = new System.Drawing.Size(120, 20);
            this.txtTeamsReq.Name = "txtTeamsReq";
            this.txtTeamsReq.Size = new System.Drawing.Size(252, 22);
            this.txtTeamsReq.TabIndex = 10;
            this.txtTeamsReq.Text = "1";
            // 
            // lbCallID
            // 
            this.lbCallID.AutoSize = true;
            this.lbCallID.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbCallID.Location = new System.Drawing.Point(63, 48);
            this.lbCallID.Name = "lbCallID";
            this.lbCallID.Size = new System.Drawing.Size(18, 13);
            this.lbCallID.TabIndex = 24;
            this.lbCallID.Text = "ID";
            // 
            // lbCallState
            // 
            this.lbCallState.AutoSize = true;
            this.lbCallState.ForeColor = System.Drawing.Color.SeaGreen;
            this.lbCallState.Location = new System.Drawing.Point(191, 48);
            this.lbCallState.Name = "lbCallState";
            this.lbCallState.Size = new System.Drawing.Size(30, 13);
            this.lbCallState.TabIndex = 26;
            this.lbCallState.Text = "state";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.DimGray;
            this.label12.Location = new System.Drawing.Point(150, 48);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 13);
            this.label12.TabIndex = 25;
            this.label12.Text = "State:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 26);
            this.label5.MinimumSize = new System.Drawing.Size(120, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Phone Number";
            // 
            // txtCallerName
            // 
            this.txtCallerName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCallerName.Location = new System.Drawing.Point(128, 86);
            this.txtCallerName.MinimumSize = new System.Drawing.Size(120, 20);
            this.txtCallerName.Name = "txtCallerName";
            this.txtCallerName.Size = new System.Drawing.Size(253, 22);
            this.txtCallerName.TabIndex = 12;
            this.txtCallerName.Leave += new System.EventHandler(this.txtCallerName_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 92);
            this.label6.MinimumSize = new System.Drawing.Size(120, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Name";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhoneNumber.Location = new System.Drawing.Point(128, 25);
            this.txtPhoneNumber.MinimumSize = new System.Drawing.Size(120, 20);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(253, 22);
            this.txtPhoneNumber.TabIndex = 10;
            this.txtPhoneNumber.Leave += new System.EventHandler(this.txtPhoneNumber_Leave);
            // 
            // lstCallerNames
            // 
            this.lstCallerNames.ColumnWidth = 120;
            this.lstCallerNames.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstCallerNames.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lstCallerNames.FormattingEnabled = true;
            this.lstCallerNames.ItemHeight = 16;
            this.lstCallerNames.Location = new System.Drawing.Point(128, 54);
            this.lstCallerNames.MultiColumn = true;
            this.lstCallerNames.Name = "lstCallerNames";
            this.lstCallerNames.Size = new System.Drawing.Size(253, 20);
            this.lstCallerNames.TabIndex = 15;
            this.lstCallerNames.SelectedIndexChanged += new System.EventHandler(this.lstCallerNames_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DimGray;
            this.label7.Location = new System.Drawing.Point(3, 124);
            this.label7.MinimumSize = new System.Drawing.Size(120, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "Last Name";
            // 
            // txtCallerLastName
            // 
            this.txtCallerLastName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCallerLastName.Location = new System.Drawing.Point(128, 121);
            this.txtCallerLastName.MinimumSize = new System.Drawing.Size(120, 20);
            this.txtCallerLastName.Name = "txtCallerLastName";
            this.txtCallerLastName.Size = new System.Drawing.Size(253, 22);
            this.txtCallerLastName.TabIndex = 14;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.DimGray;
            this.label11.Location = new System.Drawing.Point(3, 60);
            this.label11.MinimumSize = new System.Drawing.Size(120, 13);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(120, 16);
            this.label11.TabIndex = 16;
            this.label11.Text = "Suggestions";
            // 
            // pnCaller
            // 
            this.pnCaller.Controls.Add(this.label13);
            this.pnCaller.Controls.Add(this.label11);
            this.pnCaller.Controls.Add(this.txtCallerLastName);
            this.pnCaller.Controls.Add(this.label7);
            this.pnCaller.Controls.Add(this.lstCallerNames);
            this.pnCaller.Controls.Add(this.txtPhoneNumber);
            this.pnCaller.Controls.Add(this.label6);
            this.pnCaller.Controls.Add(this.txtCallerName);
            this.pnCaller.Controls.Add(this.label5);
            this.pnCaller.Location = new System.Drawing.Point(12, 255);
            this.pnCaller.Name = "pnCaller";
            this.pnCaller.Size = new System.Drawing.Size(384, 160);
            this.pnCaller.TabIndex = 27;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.DimGray;
            this.label13.Location = new System.Drawing.Point(3, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(61, 20);
            this.label13.TabIndex = 28;
            this.label13.Text = "CALLER";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtTeamsReq);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cboCallPriority);
            this.panel1.Controls.Add(this.txtCallDateTime);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(12, 79);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(384, 155);
            this.panel1.TabIndex = 28;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.DimGray;
            this.label15.Location = new System.Drawing.Point(3, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(78, 20);
            this.label15.TabIndex = 29;
            this.label15.Text = "CALL INFO";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.txtDescription);
            this.panel2.Controls.Add(this.txtLandmark);
            this.panel2.Controls.Add(this.txtAddress);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Location = new System.Drawing.Point(408, 79);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(390, 250);
            this.panel2.TabIndex = 0;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.DimGray;
            this.label14.Location = new System.Drawing.Point(3, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(92, 20);
            this.label14.TabIndex = 29;
            this.label14.Text = "EMERGENCY";
            // 
            // btnLink
            // 
            this.btnLink.Location = new System.Drawing.Point(492, 393);
            this.btnLink.Name = "btnLink";
            this.btnLink.Size = new System.Drawing.Size(150, 23);
            this.btnLink.TabIndex = 29;
            this.btnLink.Text = "Link to Emergency";
            this.btnLink.UseVisualStyleBackColor = true;
            this.btnLink.Click += new System.EventHandler(this.btnLink_Click);
            // 
            // CallForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(814, 428);
            this.Controls.Add(this.btnLink);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbCallState);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lbCallID);
            this.Controls.Add(this.lb11);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.pnCaller);
            this.Name = "CallForm";
            this.Text = "Call Form";
            this.Load += new System.EventHandler(this.CallForm_Load);
            this.pnCaller.ResumeLayout(false);
            this.pnCaller.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb11;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtLandmark;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtCallDateTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboCallPriority;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTeamsReq;
        private System.Windows.Forms.Label lbCallID;
        private System.Windows.Forms.Label lbCallState;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCallerName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.ListBox lstCallerNames;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCallerLastName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel pnCaller;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnLink;
    }
}