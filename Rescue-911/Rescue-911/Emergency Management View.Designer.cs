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
            this.lstEmergencies = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.lstTeams = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lbResult = new System.Windows.Forms.Label();
            this.rbYes = new System.Windows.Forms.RadioButton();
            this.rbNo = new System.Windows.Forms.RadioButton();
            this.lbDecision = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstEmergencies
            // 
            this.lstEmergencies.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader4,
            this.columnHeader7,
            this.columnHeader5,
            this.columnHeader2});
            this.lstEmergencies.GridLines = true;
            this.lstEmergencies.Location = new System.Drawing.Point(12, 193);
            this.lstEmergencies.MultiSelect = false;
            this.lstEmergencies.Name = "lstEmergencies";
            this.lstEmergencies.ShowItemToolTips = true;
            this.lstEmergencies.Size = new System.Drawing.Size(785, 97);
            this.lstEmergencies.TabIndex = 10;
            this.lstEmergencies.UseCompatibleStateImageBehavior = false;
            this.lstEmergencies.View = System.Windows.Forms.View.Details;
            this.lstEmergencies.Visible = false;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Emergency ID";
            this.columnHeader1.Width = 80;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Time Recevied";
            this.columnHeader4.Width = 130;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Priority";
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 132);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 36);
            this.button1.TabIndex = 1;
            this.button1.Text = "List for Emergency calls";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(145, 101);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Supervisor/Operator Name:";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(604, 459);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(108, 23);
            this.button3.TabIndex = 12;
            this.button3.Text = "Send for approval";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btnCreateDispatch_Click);
            // 
            // lstTeams
            // 
            this.lstTeams.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader6});
            this.lstTeams.GridLines = true;
            this.lstTeams.Location = new System.Drawing.Point(12, 325);
            this.lstTeams.MultiSelect = false;
            this.lstTeams.Name = "lstTeams";
            this.lstTeams.ShowItemToolTips = true;
            this.lstTeams.Size = new System.Drawing.Size(785, 97);
            this.lstTeams.TabIndex = 13;
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
            // lbResult
            // 
            this.lbResult.AutoSize = true;
            this.lbResult.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.lbResult.Location = new System.Drawing.Point(601, 443);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(46, 13);
            this.lbResult.TabIndex = 14;
            this.lbResult.Text = "success";
            this.lbResult.Visible = false;
            // 
            // rbYes
            // 
            this.rbYes.AutoSize = true;
            this.rbYes.Location = new System.Drawing.Point(481, 462);
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
            this.rbNo.Location = new System.Drawing.Point(539, 462);
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
            this.lbDecision.Location = new System.Drawing.Point(478, 446);
            this.lbDecision.Name = "lbDecision";
            this.lbDecision.Size = new System.Drawing.Size(67, 13);
            this.lbDecision.TabIndex = 31;
            this.lbDecision.Text = "Dispatched?";
            this.lbDecision.Visible = false;
            // 
            // Emergency_Management_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbDecision);
            this.Controls.Add(this.rbNo);
            this.Controls.Add(this.lstEmergencies);
            this.Controls.Add(this.rbYes);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbResult);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lstTeams);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Name = "Emergency_Management_View";
            this.Size = new System.Drawing.Size(812, 489);
            this.Controls.SetChildIndex(this.button3, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.lstTeams, 0);
            this.Controls.SetChildIndex(this.textBox1, 0);
            this.Controls.SetChildIndex(this.lbResult, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.rbYes, 0);
            this.Controls.SetChildIndex(this.lstEmergencies, 0);
            this.Controls.SetChildIndex(this.rbNo, 0);
            this.Controls.SetChildIndex(this.lbDecision, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstEmergencies;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListView lstTeams;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Label lbResult;
        private System.Windows.Forms.RadioButton rbYes;
        private System.Windows.Forms.RadioButton rbNo;
        private System.Windows.Forms.Label lbDecision;
    }
}
