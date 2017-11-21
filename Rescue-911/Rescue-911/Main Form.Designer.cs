namespace Rescue_911
{
    partial class Main_Form
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbViewArea = new System.Windows.Forms.Label();
            this.sideBar = new Rescue_911.Sidebar();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Heavy", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 37);
            this.label1.TabIndex = 2;
            // 
            // lbViewArea
            // 
            this.lbViewArea.AutoSize = true;
            this.lbViewArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbViewArea.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.lbViewArea.Location = new System.Drawing.Point(289, 234);
            this.lbViewArea.Name = "lbViewArea";
            this.lbViewArea.Size = new System.Drawing.Size(397, 73);
            this.lbViewArea.TabIndex = 17;
            this.lbViewArea.Text = "VIEW AREA";
            this.lbViewArea.Visible = false;
            // 
            // sideBar
            // 
            this.sideBar.AutoScroll = true;
            this.sideBar.AutoSize = true;
            this.sideBar.BackColor = System.Drawing.Color.White;
            this.sideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sideBar.Location = new System.Drawing.Point(0, 0);
            this.sideBar.Margin = new System.Windows.Forms.Padding(3, 3, 50, 3);
            this.sideBar.MinimumSize = new System.Drawing.Size(150, 0);
            this.sideBar.Name = "sideBar";
            this.sideBar.Padding = new System.Windows.Forms.Padding(0, 10, 1, 0);
            this.sideBar.Size = new System.Drawing.Size(150, 562);
            this.sideBar.TabIndex = 1;
            this.sideBar.Visible = false;
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(884, 562);
            this.Controls.Add(this.lbViewArea);
            this.Controls.Add(this.sideBar);
            this.Controls.Add(this.label1);
            this.Name = "Main_Form";
            this.Text = "ERIS by Group 18";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_Form_FormClosing);
            this.Load += new System.EventHandler(this.Main_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private Sidebar sideBar;
        private System.Windows.Forms.Label lbViewArea;
    }
}

