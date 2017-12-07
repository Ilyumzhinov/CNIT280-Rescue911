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
            this.rbYes = new System.Windows.Forms.RadioButton();
            this.rbNo = new System.Windows.Forms.RadioButton();
            this.lbDecision = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.RTList = new Rescue_911.Response_Teams_List();
            this.emergencyList = new Rescue_911.Emergency_List();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSend
            // 
            this.btnSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSend.Location = new System.Drawing.Point(324, 15);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(108, 23);
            this.btnSend.TabIndex = 12;
            this.btnSend.Text = "Send for approval";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnCreateDispatch_Click);
            // 
            // rbYes
            // 
            this.rbYes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.rbYes.AutoSize = true;
            this.rbYes.Enabled = false;
            this.rbYes.Location = new System.Drawing.Point(217, 21);
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
            this.rbNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.rbNo.AutoSize = true;
            this.rbNo.Enabled = false;
            this.rbNo.Location = new System.Drawing.Point(275, 21);
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
            this.lbDecision.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbDecision.AutoSize = true;
            this.lbDecision.Location = new System.Drawing.Point(218, 5);
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
            this.panel2.Controls.Add(this.RTList);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(7, 237);
            this.panel2.Margin = new System.Windows.Forms.Padding(5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(436, 134);
            this.panel2.TabIndex = 34;
            // 
            // RTList
            // 
            this.RTList.AutoSize = true;
            this.RTList.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.RTList.BackColor = System.Drawing.Color.White;
            this.RTList.Dock = System.Windows.Forms.DockStyle.Top;
            this.RTList.Location = new System.Drawing.Point(0, 0);
            this.RTList.Margin = new System.Windows.Forms.Padding(2);
            this.RTList.MinimumSize = new System.Drawing.Size(330, 0);
            this.RTList.Name = "RTList";
            this.RTList.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.RTList.Size = new System.Drawing.Size(436, 134);
            this.RTList.TabIndex = 32;
            // 
            // emergencyList
            // 
            this.emergencyList.AutoSize = true;
            this.emergencyList.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.emergencyList.Dock = System.Windows.Forms.DockStyle.Top;
            this.emergencyList.Location = new System.Drawing.Point(7, 101);
            this.emergencyList.Margin = new System.Windows.Forms.Padding(5);
            this.emergencyList.MinimumSize = new System.Drawing.Size(400, 0);
            this.emergencyList.Name = "emergencyList";
            this.emergencyList.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.emergencyList.Size = new System.Drawing.Size(436, 136);
            this.emergencyList.TabIndex = 32;
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.lbDecision);
            this.panel1.Controls.Add(this.rbYes);
            this.panel1.Controls.Add(this.btnSend);
            this.panel1.Controls.Add(this.rbNo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(7, 371);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.MinimumSize = new System.Drawing.Size(330, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(436, 41);
            this.panel1.TabIndex = 35;
            // 
            // Emergency_Management_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.emergencyList);
            this.MinimumSize = new System.Drawing.Size(450, 0);
            this.Name = "Emergency_Management_View";
            this.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Size = new System.Drawing.Size(450, 418);
            this.ViewColour = System.Drawing.Color.IndianRed;
            this.ViewDescription = "Select Emergency and a RT to create dispatch";
            this.ViewTitle = "Emergency Management";
            this.SizeChanged += new System.EventHandler(this.Emergency_Management_View_SizeChanged);
            this.Controls.SetChildIndex(this.emergencyList, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.RadioButton rbYes;
        private System.Windows.Forms.RadioButton rbNo;
        private System.Windows.Forms.Label lbDecision;
        private System.Windows.Forms.Panel panel2;
        private Emergency_List emergencyList;
        private Response_Teams_List RTList;
        private System.Windows.Forms.Panel panel1;
    }
}
