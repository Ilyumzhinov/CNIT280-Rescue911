namespace Rescue_911
{
    partial class Emergency_Management_View
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
            this.btnSend = new System.Windows.Forms.Button();
            this.lstTeams = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.rbYes = new System.Windows.Forms.RadioButton();
            this.rbNo = new System.Windows.Forms.RadioButton();
            this.lbDecision = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.emergencyList = new Rescue_911.Emergency_List();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(572, 13);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(108, 23);
            this.btnSend.TabIndex = 12;
            this.btnSend.Text = "Send for approval";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnCreateDispatch_Click);
            // 
            // lstTeams
            // 
            this.lstTeams.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader6});
            this.lstTeams.Dock = System.Windows.Forms.DockStyle.Top;
            this.lstTeams.FullRowSelect = true;
            this.lstTeams.GridLines = true;
            this.lstTeams.Location = new System.Drawing.Point(5, 223);
            this.lstTeams.Margin = new System.Windows.Forms.Padding(5);
            this.lstTeams.MultiSelect = false;
            this.lstTeams.Name = "lstTeams";
            this.lstTeams.ShowItemToolTips = true;
            this.lstTeams.Size = new System.Drawing.Size(683, 97);
            this.lstTeams.TabIndex = 13;
            this.lstTeams.UseCompatibleStateImageBehavior = false;
            this.lstTeams.View = System.Windows.Forms.View.Details;
            this.lstTeams.SelectedIndexChanged += new System.EventHandler(this.lstTeams_SelectedIndexChanged);
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
            // rbYes
            // 
            this.rbYes.AutoSize = true;
            this.rbYes.Location = new System.Drawing.Point(469, 19);
            this.rbYes.Name = "rbYes";
            this.rbYes.Size = new System.Drawing.Size(43, 17);
            this.rbYes.TabIndex = 15;
            this.rbYes.TabStop = true;
            this.rbYes.Text = "Yes";
            this.rbYes.UseVisualStyleBackColor = true;
            this.rbYes.CheckedChanged += new System.EventHandler(this.rbYes_CheckedChanged);
            // 
            // rbNo
            // 
            this.rbNo.AutoSize = true;
            this.rbNo.Location = new System.Drawing.Point(527, 19);
            this.rbNo.Name = "rbNo";
            this.rbNo.Size = new System.Drawing.Size(39, 17);
            this.rbNo.TabIndex = 16;
            this.rbNo.TabStop = true;
            this.rbNo.Text = "No";
            this.rbNo.UseVisualStyleBackColor = true;
            this.rbNo.CheckedChanged += new System.EventHandler(this.rbNo_CheckedChanged);
            // 
            // lbDecision
            // 
            this.lbDecision.AutoSize = true;
            this.lbDecision.Location = new System.Drawing.Point(466, 3);
            this.lbDecision.Name = "lbDecision";
            this.lbDecision.Size = new System.Drawing.Size(67, 13);
            this.lbDecision.TabIndex = 31;
            this.lbDecision.Text = "Dispatched?";
            this.lbDecision.Visible = false;
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.Controls.Add(this.lbDecision);
            this.panel2.Controls.Add(this.btnSend);
            this.panel2.Controls.Add(this.rbNo);
            this.panel2.Controls.Add(this.rbYes);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(5, 320);
            this.panel2.Margin = new System.Windows.Forms.Padding(5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(683, 39);
            this.panel2.TabIndex = 34;
            // 
            // emergencyList
            // 
            this.emergencyList.AutoSize = true;
            this.emergencyList.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.emergencyList.Dock = System.Windows.Forms.DockStyle.Top;
            this.emergencyList.Location = new System.Drawing.Point(5, 89);
            this.emergencyList.Margin = new System.Windows.Forms.Padding(5);
            this.emergencyList.MinimumSize = new System.Drawing.Size(400, 0);
            this.emergencyList.Name = "emergencyList";
            this.emergencyList.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.emergencyList.Size = new System.Drawing.Size(683, 134);
            this.emergencyList.TabIndex = 32;
            // 
            // Emergency_Management_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lstTeams);
            this.Controls.Add(this.emergencyList);
            this.Name = "Emergency_Management_View";
            this.Size = new System.Drawing.Size(693, 366);
            this.SizeChanged += new System.EventHandler(this.Emergency_Management_View_SizeChanged);
            this.Controls.SetChildIndex(this.emergencyList, 0);
            this.Controls.SetChildIndex(this.lstTeams, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.ListView lstTeams;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.RadioButton rbYes;
        private System.Windows.Forms.RadioButton rbNo;
        private System.Windows.Forms.Label lbDecision;
        private System.Windows.Forms.Panel panel2;
        private Emergency_List emergencyList;
    }
}
