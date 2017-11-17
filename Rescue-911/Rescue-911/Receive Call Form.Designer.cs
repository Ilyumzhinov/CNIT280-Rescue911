namespace Rescue_911
{
    partial class Receive_Call_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbRT_ID = new System.Windows.Forms.Label();
            this.lb11 = new System.Windows.Forms.Label();
            this.lstEmergencies = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lbDecision = new System.Windows.Forms.Label();
            this.rbNo = new System.Windows.Forms.RadioButton();
            this.rbYes = new System.Windows.Forms.RadioButton();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbRT_ID
            // 
            this.lbRT_ID.AutoSize = true;
            this.lbRT_ID.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbRT_ID.Location = new System.Drawing.Point(120, 46);
            this.lbRT_ID.Name = "lbRT_ID";
            this.lbRT_ID.Size = new System.Drawing.Size(18, 13);
            this.lbRT_ID.TabIndex = 26;
            this.lbRT_ID.Text = "ID";
            // 
            // lb11
            // 
            this.lb11.AutoSize = true;
            this.lb11.ForeColor = System.Drawing.Color.DimGray;
            this.lb11.Location = new System.Drawing.Point(12, 46);
            this.lb11.Name = "lb11";
            this.lb11.Size = new System.Drawing.Size(102, 13);
            this.lb11.TabIndex = 25;
            this.lb11.Text = "Response Team ID:";
            // 
            // lstEmergencies
            // 
            this.lstEmergencies.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader2});
            this.lstEmergencies.GridLines = true;
            this.lstEmergencies.Location = new System.Drawing.Point(12, 78);
            this.lstEmergencies.Name = "lstEmergencies";
            this.lstEmergencies.ShowItemToolTips = true;
            this.lstEmergencies.Size = new System.Drawing.Size(560, 97);
            this.lstEmergencies.TabIndex = 27;
            this.lstEmergencies.UseCompatibleStateImageBehavior = false;
            this.lstEmergencies.View = System.Windows.Forms.View.Details;
            this.lstEmergencies.SelectedIndexChanged += new System.EventHandler(this.lstEmergencies_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Emergency ID";
            this.columnHeader1.Width = 83;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Time Recevied";
            this.columnHeader4.Width = 130;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "State";
            this.columnHeader5.Width = 72;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Description";
            this.columnHeader2.Width = 271;
            // 
            // lbDecision
            // 
            this.lbDecision.AutoSize = true;
            this.lbDecision.Location = new System.Drawing.Point(14, 224);
            this.lbDecision.Name = "lbDecision";
            this.lbDecision.Size = new System.Drawing.Size(67, 13);
            this.lbDecision.TabIndex = 30;
            this.lbDecision.Text = "Dispatched?";
            this.lbDecision.Visible = false;
            // 
            // rbNo
            // 
            this.rbNo.AutoSize = true;
            this.rbNo.Location = new System.Drawing.Point(77, 240);
            this.rbNo.Name = "rbNo";
            this.rbNo.Size = new System.Drawing.Size(39, 17);
            this.rbNo.TabIndex = 29;
            this.rbNo.TabStop = true;
            this.rbNo.Text = "No";
            this.rbNo.UseVisualStyleBackColor = true;
            this.rbNo.Visible = false;
            this.rbNo.CheckedChanged += new System.EventHandler(this.rbNo_CheckedChanged);
            // 
            // rbYes
            // 
            this.rbYes.AutoSize = true;
            this.rbYes.Location = new System.Drawing.Point(17, 240);
            this.rbYes.Name = "rbYes";
            this.rbYes.Size = new System.Drawing.Size(43, 17);
            this.rbYes.TabIndex = 28;
            this.rbYes.TabStop = true;
            this.rbYes.Text = "Yes";
            this.rbYes.UseVisualStyleBackColor = true;
            this.rbYes.Visible = false;
            this.rbYes.CheckedChanged += new System.EventHandler(this.rbYes_CheckedChanged);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(12, 307);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 31;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Receive_Call_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(677, 445);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lbDecision);
            this.Controls.Add(this.rbNo);
            this.Controls.Add(this.rbYes);
            this.Controls.Add(this.lstEmergencies);
            this.Controls.Add(this.lbRT_ID);
            this.Controls.Add(this.lb11);
            this.Name = "Receive_Call_Form";
            this.Text = "Receive Call Form";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Receive_Call_Form_FormClosing);
            this.Load += new System.EventHandler(this.Receive_Call_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbRT_ID;
        private System.Windows.Forms.Label lb11;
        private System.Windows.Forms.ListView lstEmergencies;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label lbDecision;
        private System.Windows.Forms.RadioButton rbNo;
        private System.Windows.Forms.RadioButton rbYes;
        private System.Windows.Forms.Button btnClose;
    }
}