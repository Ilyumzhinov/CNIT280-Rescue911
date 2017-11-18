namespace Rescue_911
{
    partial class Sidebar
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
            this.layoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbUser = new System.Windows.Forms.Label();
            this.lbAccessLevel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // layoutPanel
            // 
            this.layoutPanel.AutoSize = true;
            this.layoutPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.layoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.layoutPanel.Location = new System.Drawing.Point(5, 88);
            this.layoutPanel.Margin = new System.Windows.Forms.Padding(0, 30, 0, 50);
            this.layoutPanel.MinimumSize = new System.Drawing.Size(100, 50);
            this.layoutPanel.Name = "layoutPanel";
            this.layoutPanel.Size = new System.Drawing.Size(100, 50);
            this.layoutPanel.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(5, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "Access level:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(5, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Current user:";
            // 
            // lbUser
            // 
            this.lbUser.AutoSize = true;
            this.lbUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbUser.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUser.ForeColor = System.Drawing.Color.LightCoral;
            this.lbUser.Location = new System.Drawing.Point(5, 26);
            this.lbUser.Name = "lbUser";
            this.lbUser.Size = new System.Drawing.Size(20, 16);
            this.lbUser.TabIndex = 2;
            this.lbUser.Text = "> ";
            // 
            // lbAccessLevel
            // 
            this.lbAccessLevel.AutoSize = true;
            this.lbAccessLevel.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbAccessLevel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAccessLevel.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.lbAccessLevel.Location = new System.Drawing.Point(5, 58);
            this.lbAccessLevel.Name = "lbAccessLevel";
            this.lbAccessLevel.Size = new System.Drawing.Size(20, 16);
            this.lbAccessLevel.TabIndex = 15;
            this.lbAccessLevel.Text = "> ";
            // 
            // Sidebar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.layoutPanel);
            this.Controls.Add(this.lbAccessLevel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbUser);
            this.Controls.Add(this.label2);
            this.MinimumSize = new System.Drawing.Size(150, 0);
            this.Name = "Sidebar";
            this.Padding = new System.Windows.Forms.Padding(5, 10, 6, 0);
            this.Size = new System.Drawing.Size(150, 300);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.LinePaint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel layoutPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbUser;
        private System.Windows.Forms.Label lbAccessLevel;
    }
}
