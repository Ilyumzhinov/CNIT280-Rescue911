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
            this.emergencyList = new Rescue_911.Emergency_List();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 51);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 36);
            this.button1.TabIndex = 1;
            this.button1.Text = "List for Emergency calls";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(146, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Supervisor/Operator Name:";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(129, 13);
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
            this.lstTeams.Dock = System.Windows.Forms.DockStyle.Top;
            this.lstTeams.GridLines = true;
            this.lstTeams.Location = new System.Drawing.Point(3, 233);
            this.lstTeams.MultiSelect = false;
            this.lstTeams.Name = "lstTeams";
            this.lstTeams.ShowItemToolTips = true;
            this.lstTeams.Size = new System.Drawing.Size(440, 97);
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
            this.lbResult.Location = new System.Drawing.Point(126, -3);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(46, 13);
            this.lbResult.TabIndex = 14;
            this.lbResult.Text = "success";
            this.lbResult.Visible = false;
            // 
            // rbYes
            // 
            this.rbYes.AutoSize = true;
            this.rbYes.Location = new System.Drawing.Point(6, 16);
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
            this.rbNo.Location = new System.Drawing.Point(64, 16);
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
            this.lbDecision.Location = new System.Drawing.Point(3, 0);
            this.lbDecision.Name = "lbDecision";
            this.lbDecision.Size = new System.Drawing.Size(67, 13);
            this.lbDecision.TabIndex = 31;
            this.lbDecision.Text = "Dispatched?";
            this.lbDecision.Visible = false;
            // 
            // emergencyList
            // 
            this.emergencyList.AutoSize = true;
            this.emergencyList.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.emergencyList.Dock = System.Windows.Forms.DockStyle.Top;
            this.emergencyList.Location = new System.Drawing.Point(3, 93);
            this.emergencyList.MinimumSize = new System.Drawing.Size(440, 0);
            this.emergencyList.Name = "emergencyList";
            this.emergencyList.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.emergencyList.Size = new System.Drawing.Size(440, 134);
            this.emergencyList.TabIndex = 32;
            this.emergencyList.Visible = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Controls.Add(this.button1);
            this.flowLayoutPanel1.Controls.Add(this.emergencyList);
            this.flowLayoutPanel1.Controls.Add(this.lstTeams);
            this.flowLayoutPanel1.Controls.Add(this.panel2);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(5, 89);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(802, 461);
            this.flowLayoutPanel1.TabIndex = 33;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(263, 42);
            this.panel1.TabIndex = 33;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbDecision);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.lbResult);
            this.panel2.Controls.Add(this.rbNo);
            this.panel2.Controls.Add(this.rbYes);
            this.panel2.Location = new System.Drawing.Point(3, 336);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(242, 100);
            this.panel2.TabIndex = 34;
            // 
            // Emergency_Management_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Emergency_Management_View";
            this.Size = new System.Drawing.Size(812, 555);
            this.SizeChanged += new System.EventHandler(this.Emergency_Management_View_SizeChanged);
            this.Controls.SetChildIndex(this.flowLayoutPanel1, 0);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private Emergency_List emergencyList;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}
