namespace Rescue_911
{
    partial class Call_View
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
            this.txtTeamsReq = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboCallPriority = new System.Windows.Forms.ComboBox();
            this.txtCallDateTime = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lstCallerNames = new System.Windows.Forms.ListBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCallerName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtLandmark = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnAddEmer = new System.Windows.Forms.Button();
            this.btnLinkEmergency = new System.Windows.Forms.Button();
            this.layoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.layoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTeamsReq
            // 
            this.txtTeamsReq.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTeamsReq.Location = new System.Drawing.Point(103, 98);
            this.txtTeamsReq.MinimumSize = new System.Drawing.Size(120, 20);
            this.txtTeamsReq.Name = "txtTeamsReq";
            this.txtTeamsReq.Size = new System.Drawing.Size(251, 22);
            this.txtTeamsReq.TabIndex = 1;
            this.txtTeamsReq.Text = "1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 29;
            this.label1.Text = "CALL INFO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 101);
            this.label2.MinimumSize = new System.Drawing.Size(120, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Team req.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 35);
            this.label3.MinimumSize = new System.Drawing.Size(120, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Date/Time";
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
            this.cboCallPriority.Location = new System.Drawing.Point(103, 64);
            this.cboCallPriority.Name = "cboCallPriority";
            this.cboCallPriority.Size = new System.Drawing.Size(251, 24);
            this.cboCallPriority.TabIndex = 2;
            this.cboCallPriority.SelectedIndexChanged += new System.EventHandler(this.cboCallPriority_SelectedIndexChanged);
            // 
            // txtCallDateTime
            // 
            this.txtCallDateTime.Enabled = false;
            this.txtCallDateTime.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCallDateTime.Location = new System.Drawing.Point(104, 32);
            this.txtCallDateTime.MinimumSize = new System.Drawing.Size(120, 20);
            this.txtCallDateTime.Name = "txtCallDateTime";
            this.txtCallDateTime.ReadOnly = true;
            this.txtCallDateTime.Size = new System.Drawing.Size(250, 22);
            this.txtCallDateTime.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 67);
            this.label4.MinimumSize = new System.Drawing.Size(120, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Priority";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtTeamsReq);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cboCallPriority);
            this.panel1.Controls.Add(this.txtCallDateTime);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(367, 155);
            this.panel1.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 20);
            this.label5.TabIndex = 28;
            this.label5.Text = "CALLER";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(4, 58);
            this.label6.MinimumSize = new System.Drawing.Size(120, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 16);
            this.label6.TabIndex = 16;
            this.label6.Text = "Suggested Patient";
            // 
            // lstCallerNames
            // 
            this.lstCallerNames.ColumnWidth = 120;
            this.lstCallerNames.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstCallerNames.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lstCallerNames.FormattingEnabled = true;
            this.lstCallerNames.ItemHeight = 16;
            this.lstCallerNames.Location = new System.Drawing.Point(104, 54);
            this.lstCallerNames.MultiColumn = true;
            this.lstCallerNames.Name = "lstCallerNames";
            this.lstCallerNames.Size = new System.Drawing.Size(250, 20);
            this.lstCallerNames.TabIndex = 2;
            this.lstCallerNames.SelectedIndexChanged += new System.EventHandler(this.lstCallerNames_SelectedIndexChanged);
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhoneNumber.Location = new System.Drawing.Point(104, 26);
            this.txtPhoneNumber.MinimumSize = new System.Drawing.Size(120, 20);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(250, 22);
            this.txtPhoneNumber.TabIndex = 1;
            this.txtPhoneNumber.Leave += new System.EventHandler(this.txtPhoneNumber_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(4, 89);
            this.label7.MinimumSize = new System.Drawing.Size(120, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 16);
            this.label7.TabIndex = 11;
            this.label7.Text = "Name";
            // 
            // txtCallerName
            // 
            this.txtCallerName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCallerName.Location = new System.Drawing.Point(104, 86);
            this.txtCallerName.MinimumSize = new System.Drawing.Size(120, 20);
            this.txtCallerName.Name = "txtCallerName";
            this.txtCallerName.Size = new System.Drawing.Size(250, 22);
            this.txtCallerName.TabIndex = 3;
            this.txtCallerName.Leave += new System.EventHandler(this.txtCallerName_Leave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 26);
            this.label8.MinimumSize = new System.Drawing.Size(120, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 16);
            this.label8.TabIndex = 9;
            this.label8.Text = "Phone Number";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.lstCallerNames);
            this.panel2.Controls.Add(this.txtPhoneNumber);
            this.panel2.Controls.Add(this.txtCallerName);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Location = new System.Drawing.Point(376, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(367, 116);
            this.panel2.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DimGray;
            this.label9.Location = new System.Drawing.Point(3, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 20);
            this.label9.TabIndex = 29;
            this.label9.Text = "EMERGENCY";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(3, 32);
            this.label10.MinimumSize = new System.Drawing.Size(120, 13);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(120, 16);
            this.label10.TabIndex = 15;
            this.label10.Text = "Address";
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(107, 107);
            this.txtDescription.MinimumSize = new System.Drawing.Size(120, 20);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(247, 140);
            this.txtDescription.TabIndex = 3;
            this.txtDescription.Leave += new System.EventHandler(this.txtDescription_Leave);
            // 
            // txtLandmark
            // 
            this.txtLandmark.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLandmark.Location = new System.Drawing.Point(107, 64);
            this.txtLandmark.MinimumSize = new System.Drawing.Size(120, 20);
            this.txtLandmark.Name = "txtLandmark";
            this.txtLandmark.Size = new System.Drawing.Size(247, 22);
            this.txtLandmark.TabIndex = 2;
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(107, 29);
            this.txtAddress.MinimumSize = new System.Drawing.Size(120, 20);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(247, 22);
            this.txtAddress.TabIndex = 1;
            this.txtAddress.Leave += new System.EventHandler(this.txtAddress_Leave);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.DimGray;
            this.label11.Location = new System.Drawing.Point(4, 67);
            this.label11.MinimumSize = new System.Drawing.Size(120, 13);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(120, 16);
            this.label11.TabIndex = 17;
            this.label11.Text = "Landmark";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(4, 101);
            this.label12.MinimumSize = new System.Drawing.Size(120, 13);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(120, 16);
            this.label12.TabIndex = 19;
            this.label12.Text = "Description";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnAddEmer);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.btnLinkEmergency);
            this.panel3.Controls.Add(this.txtDescription);
            this.panel3.Controls.Add(this.txtLandmark);
            this.panel3.Controls.Add(this.txtAddress);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Location = new System.Drawing.Point(3, 164);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(365, 280);
            this.panel3.TabIndex = 3;
            // 
            // btnAddEmer
            // 
            this.btnAddEmer.Location = new System.Drawing.Point(162, 253);
            this.btnAddEmer.Name = "btnAddEmer";
            this.btnAddEmer.Size = new System.Drawing.Size(192, 23);
            this.btnAddEmer.TabIndex = 30;
            this.btnAddEmer.Text = "Add New Emergency";
            this.btnAddEmer.UseVisualStyleBackColor = true;
            this.btnAddEmer.Click += new System.EventHandler(this.btnAddEmer_Click);
            // 
            // btnLinkEmergency
            // 
            this.btnLinkEmergency.Location = new System.Drawing.Point(6, 253);
            this.btnLinkEmergency.Name = "btnLinkEmergency";
            this.btnLinkEmergency.Size = new System.Drawing.Size(150, 23);
            this.btnLinkEmergency.TabIndex = 29;
            this.btnLinkEmergency.Text = "Link to Emergency";
            this.btnLinkEmergency.UseVisualStyleBackColor = true;
            this.btnLinkEmergency.Click += new System.EventHandler(this.btnLinkEmergency_Click);
            // 
            // layoutPanel
            // 
            this.layoutPanel.AutoScroll = true;
            this.layoutPanel.AutoSize = true;
            this.layoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.layoutPanel.Controls.Add(this.panel1);
            this.layoutPanel.Controls.Add(this.panel2);
            this.layoutPanel.Controls.Add(this.panel3);
            this.layoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutPanel.Location = new System.Drawing.Point(5, 89);
            this.layoutPanel.Margin = new System.Windows.Forms.Padding(3, 15, 3, 3);
            this.layoutPanel.MaximumSize = new System.Drawing.Size(800, 2000);
            this.layoutPanel.Name = "layoutPanel";
            this.layoutPanel.Size = new System.Drawing.Size(769, 749);
            this.layoutPanel.TabIndex = 4;
            // 
            // Call_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutPanel);
            this.Name = "Call_View";
            this.Size = new System.Drawing.Size(779, 843);
            this.Controls.SetChildIndex(this.layoutPanel, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.layoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTeamsReq;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboCallPriority;
        private System.Windows.Forms.TextBox txtCallDateTime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox lstCallerNames;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCallerName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtLandmark;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnLinkEmergency;
        private System.Windows.Forms.Button btnAddEmer;
        private System.Windows.Forms.FlowLayoutPanel layoutPanel;
    }
}
