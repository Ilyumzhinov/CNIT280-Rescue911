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
            this.btnClose = new System.Windows.Forms.Button();
            this.lbDecision = new System.Windows.Forms.Label();
            this.rbNo = new System.Windows.Forms.RadioButton();
            this.rbYes = new System.Windows.Forms.RadioButton();
            this.lbRT_ID = new System.Windows.Forms.Label();
            this.lb11 = new System.Windows.Forms.Label();
            this.emergencyList = new Rescue_911.Emergency_List();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(2, 67);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 39;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // lbDecision
            // 
            this.lbDecision.AutoSize = true;
            this.lbDecision.Location = new System.Drawing.Point(4, 8);
            this.lbDecision.Name = "lbDecision";
            this.lbDecision.Size = new System.Drawing.Size(67, 13);
            this.lbDecision.TabIndex = 38;
            this.lbDecision.Text = "Dispatched?";
            this.lbDecision.Visible = false;
            // 
            // rbNo
            // 
            this.rbNo.AutoSize = true;
            this.rbNo.Location = new System.Drawing.Point(65, 34);
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
            this.rbYes.Location = new System.Drawing.Point(7, 34);
            this.rbYes.Name = "rbYes";
            this.rbYes.Size = new System.Drawing.Size(43, 17);
            this.rbYes.TabIndex = 36;
            this.rbYes.TabStop = true;
            this.rbYes.Text = "Yes";
            this.rbYes.UseVisualStyleBackColor = true;
            this.rbYes.Visible = false;
            // 
            // lbRT_ID
            // 
            this.lbRT_ID.AutoSize = true;
            this.lbRT_ID.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbRT_ID.Location = new System.Drawing.Point(111, 3);
            this.lbRT_ID.Name = "lbRT_ID";
            this.lbRT_ID.Size = new System.Drawing.Size(18, 13);
            this.lbRT_ID.TabIndex = 34;
            this.lbRT_ID.Text = "ID";
            // 
            // lb11
            // 
            this.lb11.AutoSize = true;
            this.lb11.ForeColor = System.Drawing.Color.DimGray;
            this.lb11.Location = new System.Drawing.Point(3, 3);
            this.lb11.Name = "lb11";
            this.lb11.Size = new System.Drawing.Size(102, 13);
            this.lb11.TabIndex = 33;
            this.lb11.Text = "Response Team ID:";
            // 
            // emergencyList
            // 
            this.emergencyList.AutoSize = true;
            this.emergencyList.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.emergencyList.Dock = System.Windows.Forms.DockStyle.Top;
            this.emergencyList.Location = new System.Drawing.Point(5, 111);
            this.emergencyList.MinimumSize = new System.Drawing.Size(440, 0);
            this.emergencyList.Name = "emergencyList";
            this.emergencyList.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.emergencyList.Size = new System.Drawing.Size(577, 134);
            this.emergencyList.TabIndex = 41;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lb11);
            this.panel1.Controls.Add(this.lbRT_ID);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(5, 89);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(577, 22);
            this.panel1.TabIndex = 42;
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.Controls.Add(this.rbYes);
            this.panel2.Controls.Add(this.rbNo);
            this.panel2.Controls.Add(this.lbDecision);
            this.panel2.Controls.Add(this.btnClose);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(475, 245);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(107, 106);
            this.panel2.TabIndex = 43;
            // 
            // Response_Team_Information_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.emergencyList);
            this.Controls.Add(this.panel1);
            this.Name = "Response_Team_Information_View";
            this.Size = new System.Drawing.Size(587, 356);
            this.SizeChanged += new System.EventHandler(this.Response_Team_Information_View_SizeChanged);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.emergencyList, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lbDecision;
        private System.Windows.Forms.RadioButton rbNo;
        private System.Windows.Forms.RadioButton rbYes;
        private System.Windows.Forms.Label lbRT_ID;
        private System.Windows.Forms.Label lb11;
        private Emergency_List emergencyList;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}
