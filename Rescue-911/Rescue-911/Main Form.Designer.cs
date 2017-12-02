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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Form));
            this.label1 = new System.Windows.Forms.Label();
            this.lbViewArea = new System.Windows.Forms.Label();
            this.statusBar = new Rescue_911.Statusbar();
            this.sideBar = new Rescue_911.Sidebar();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Heavy", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 47);
            this.label1.TabIndex = 2;
            // 
            // lbViewArea
            // 
            this.lbViewArea.AutoSize = true;
            this.lbViewArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbViewArea.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.lbViewArea.Location = new System.Drawing.Point(385, 288);
            this.lbViewArea.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbViewArea.Name = "lbViewArea";
            this.lbViewArea.Size = new System.Drawing.Size(490, 91);
            this.lbViewArea.TabIndex = 17;
            this.lbViewArea.Text = "VIEW AREA";
            this.lbViewArea.Visible = false;
            // 
            // statusBar
            // 
            this.statusBar.AutoSize = true;
            this.statusBar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.statusBar.BackColor = System.Drawing.Color.SlateGray;
            this.statusBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.statusBar.ForeColor = System.Drawing.Color.White;
            this.statusBar.Location = new System.Drawing.Point(200, 659);
            this.statusBar.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.statusBar.Name = "statusBar";
            this.statusBar.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.statusBar.Size = new System.Drawing.Size(979, 33);
            this.statusBar.TabIndex = 18;
            // 
            // sideBar
            // 
            this.sideBar.AutoScroll = true;
            this.sideBar.AutoSize = true;
            this.sideBar.BackColor = System.Drawing.Color.White;
            this.sideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sideBar.Location = new System.Drawing.Point(0, 0);
            this.sideBar.Margin = new System.Windows.Forms.Padding(4, 4, 67, 4);
            this.sideBar.MinimumSize = new System.Drawing.Size(200, 0);
            this.sideBar.Name = "sideBar";
            this.sideBar.Padding = new System.Windows.Forms.Padding(0, 12, 1, 0);
            this.sideBar.Size = new System.Drawing.Size(200, 692);
            this.sideBar.TabIndex = 1;
            this.sideBar.Visible = false;
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1179, 692);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.lbViewArea);
            this.Controls.Add(this.sideBar);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private Statusbar statusBar;
    }
}

