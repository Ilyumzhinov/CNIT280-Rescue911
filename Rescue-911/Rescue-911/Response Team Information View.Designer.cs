namespace Rescue_911
{
    partial class Response_Team_Information_View
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
            this.lstTeams = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnClose = new System.Windows.Forms.Button();
            this.lbDecision = new System.Windows.Forms.Label();
            this.rbNo = new System.Windows.Forms.RadioButton();
            this.rbYes = new System.Windows.Forms.RadioButton();
            this.lstEmergencies = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lbRT_ID = new System.Windows.Forms.Label();
            this.lb11 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstTeams
            // 
            this.lstTeams.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader6});
            this.lstTeams.GridLines = true;
            this.lstTeams.Location = new System.Drawing.Point(14, 210);
            this.lstTeams.MultiSelect = false;
            this.lstTeams.Name = "lstTeams";
            this.lstTeams.ShowItemToolTips = true;
            this.lstTeams.Size = new System.Drawing.Size(560, 100);
            this.lstTeams.TabIndex = 40;
            this.lstTeams.UseCompatibleStateImageBehavior = false;
            this.lstTeams.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Response Team ID";
            this.columnHeader3.Width = 212;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Grade";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(14, 388);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 39;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // lbDecision
            // 
            this.lbDecision.AutoSize = true;
            this.lbDecision.Location = new System.Drawing.Point(16, 329);
            this.lbDecision.Name = "lbDecision";
            this.lbDecision.Size = new System.Drawing.Size(67, 13);
            this.lbDecision.TabIndex = 38;
            this.lbDecision.Text = "Dispatched?";
            this.lbDecision.Visible = false;
            // 
            // rbNo
            // 
            this.rbNo.AutoSize = true;
            this.rbNo.Location = new System.Drawing.Point(77, 355);
            this.rbNo.Name = "rbNo";
            this.rbNo.Size = new System.Drawing.Size(39, 17);
            this.rbNo.TabIndex = 37;
            this.rbNo.TabStop = true;
            this.rbNo.Text = "No";
            this.rbNo.UseVisualStyleBackColor = true;
            this.rbNo.Visible = false;
            // 
            // rbYes
            // 
            this.rbYes.AutoSize = true;
            this.rbYes.Location = new System.Drawing.Point(19, 355);
            this.rbYes.Name = "rbYes";
            this.rbYes.Size = new System.Drawing.Size(43, 17);
            this.rbYes.TabIndex = 36;
            this.rbYes.TabStop = true;
            this.rbYes.Text = "Yes";
            this.rbYes.UseVisualStyleBackColor = true;
            this.rbYes.Visible = false;
            // 
            // lstEmergencies
            // 
            this.lstEmergencies.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader2});
            this.lstEmergencies.GridLines = true;
            this.lstEmergencies.Location = new System.Drawing.Point(14, 94);
            this.lstEmergencies.Name = "lstEmergencies";
            this.lstEmergencies.ShowItemToolTips = true;
            this.lstEmergencies.Size = new System.Drawing.Size(560, 97);
            this.lstEmergencies.TabIndex = 35;
            this.lstEmergencies.UseCompatibleStateImageBehavior = false;
            this.lstEmergencies.View = System.Windows.Forms.View.Details;
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
            // lbRT_ID
            // 
            this.lbRT_ID.AutoSize = true;
            this.lbRT_ID.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbRT_ID.Location = new System.Drawing.Point(122, 62);
            this.lbRT_ID.Name = "lbRT_ID";
            this.lbRT_ID.Size = new System.Drawing.Size(18, 13);
            this.lbRT_ID.TabIndex = 34;
            this.lbRT_ID.Text = "ID";
            // 
            // lb11
            // 
            this.lb11.AutoSize = true;
            this.lb11.ForeColor = System.Drawing.Color.DimGray;
            this.lb11.Location = new System.Drawing.Point(14, 62);
            this.lb11.Name = "lb11";
            this.lb11.Size = new System.Drawing.Size(102, 13);
            this.lb11.TabIndex = 33;
            this.lb11.Text = "Response Team ID:";
            // 
            // Response_Team_Information_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lstTeams);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lbDecision);
            this.Controls.Add(this.rbNo);
            this.Controls.Add(this.rbYes);
            this.Controls.Add(this.lstEmergencies);
            this.Controls.Add(this.lbRT_ID);
            this.Controls.Add(this.lb11);
            this.Name = "Response_Team_Information_View";
            this.Size = new System.Drawing.Size(587, 421);
            this.Controls.SetChildIndex(this.lb11, 0);
            this.Controls.SetChildIndex(this.lbRT_ID, 0);
            this.Controls.SetChildIndex(this.lstEmergencies, 0);
            this.Controls.SetChildIndex(this.rbYes, 0);
            this.Controls.SetChildIndex(this.rbNo, 0);
            this.Controls.SetChildIndex(this.lbDecision, 0);
            this.Controls.SetChildIndex(this.btnClose, 0);
            this.Controls.SetChildIndex(this.lstTeams, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstTeams;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lbDecision;
        private System.Windows.Forms.RadioButton rbNo;
        private System.Windows.Forms.RadioButton rbYes;
        private System.Windows.Forms.ListView lstEmergencies;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label lbRT_ID;
        private System.Windows.Forms.Label lb11;
    }
}
