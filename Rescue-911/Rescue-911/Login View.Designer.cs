namespace Rescue_911
{
    partial class Login_View
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
            System.Windows.Forms.PictureBox pictureBox1;
            this.paneCredentials = new System.Windows.Forms.Panel();
            this.pnlPassword = new System.Windows.Forms.Panel();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlLogin = new System.Windows.Forms.Panel();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnNewMain = new System.Windows.Forms.Button();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).BeginInit();
            this.paneCredentials.SuspendLayout();
            this.pnlPassword.SuspendLayout();
            this.pnlLogin.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            pictureBox1.Image = global::Rescue_911.Properties.Resources.ERIS_png_icon;
            pictureBox1.Location = new System.Drawing.Point(205, 0);
            pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            pictureBox1.MaximumSize = new System.Drawing.Size(75, 75);
            pictureBox1.MinimumSize = new System.Drawing.Size(75, 75);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Padding = new System.Windows.Forms.Padding(20);
            pictureBox1.Size = new System.Drawing.Size(75, 75);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 32;
            pictureBox1.TabStop = false;
            // 
            // paneCredentials
            // 
            this.paneCredentials.AutoSize = true;
            this.paneCredentials.BackColor = System.Drawing.Color.White;
            this.paneCredentials.Controls.Add(this.pnlPassword);
            this.paneCredentials.Controls.Add(this.pnlLogin);
            this.paneCredentials.Controls.Add(this.panel2);
            this.paneCredentials.Dock = System.Windows.Forms.DockStyle.Top;
            this.paneCredentials.Location = new System.Drawing.Point(10, 108);
            this.paneCredentials.Margin = new System.Windows.Forms.Padding(0);
            this.paneCredentials.MaximumSize = new System.Drawing.Size(280, 0);
            this.paneCredentials.Name = "paneCredentials";
            this.paneCredentials.Padding = new System.Windows.Forms.Padding(20, 20, 20, 15);
            this.paneCredentials.Size = new System.Drawing.Size(280, 127);
            this.paneCredentials.TabIndex = 9;
            // 
            // pnlPassword
            // 
            this.pnlPassword.AutoSize = true;
            this.pnlPassword.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlPassword.BackColor = System.Drawing.Color.Transparent;
            this.pnlPassword.Controls.Add(this.txtPassword);
            this.pnlPassword.Controls.Add(this.label1);
            this.pnlPassword.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlPassword.Location = new System.Drawing.Point(20, 52);
            this.pnlPassword.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.pnlPassword.MaximumSize = new System.Drawing.Size(240, 0);
            this.pnlPassword.MinimumSize = new System.Drawing.Size(240, 25);
            this.pnlPassword.Name = "pnlPassword";
            this.pnlPassword.Padding = new System.Windows.Forms.Padding(0, 0, 5, 10);
            this.pnlPassword.Size = new System.Drawing.Size(240, 32);
            this.pnlPassword.TabIndex = 31;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.White;
            this.txtPassword.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtPassword.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(100, 0);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.txtPassword.MaximumSize = new System.Drawing.Size(135, 4);
            this.txtPassword.MinimumSize = new System.Drawing.Size(135, 22);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(135, 22);
            this.txtPassword.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.MaximumSize = new System.Drawing.Size(100, 23);
            this.label1.MinimumSize = new System.Drawing.Size(100, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "Password:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlLogin
            // 
            this.pnlLogin.AutoSize = true;
            this.pnlLogin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlLogin.BackColor = System.Drawing.Color.Transparent;
            this.pnlLogin.Controls.Add(this.txtLogin);
            this.pnlLogin.Controls.Add(this.label4);
            this.pnlLogin.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogin.Location = new System.Drawing.Point(20, 20);
            this.pnlLogin.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.pnlLogin.MaximumSize = new System.Drawing.Size(240, 0);
            this.pnlLogin.MinimumSize = new System.Drawing.Size(240, 25);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Padding = new System.Windows.Forms.Padding(0, 0, 5, 10);
            this.pnlLogin.Size = new System.Drawing.Size(240, 32);
            this.pnlLogin.TabIndex = 30;
            // 
            // txtLogin
            // 
            this.txtLogin.BackColor = System.Drawing.Color.White;
            this.txtLogin.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtLogin.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLogin.Location = new System.Drawing.Point(100, 0);
            this.txtLogin.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.txtLogin.MaximumSize = new System.Drawing.Size(135, 4);
            this.txtLogin.MinimumSize = new System.Drawing.Size(135, 22);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(135, 22);
            this.txtLogin.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Dock = System.Windows.Forms.DockStyle.Left;
            this.label4.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.MaximumSize = new System.Drawing.Size(100, 23);
            this.label4.MinimumSize = new System.Drawing.Size(100, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Employee ID:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.btnLogin);
            this.panel2.Controls.Add(this.btnNewMain);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(20, 84);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.MinimumSize = new System.Drawing.Size(0, 28);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(240, 28);
            this.panel2.TabIndex = 9;
            // 
            // btnLogin
            // 
            this.btnLogin.AutoSize = true;
            this.btnLogin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnLogin.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnLogin.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLogin.Location = new System.Drawing.Point(187, 0);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(10);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(53, 28);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Log in";
            this.btnLogin.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnNewMain
            // 
            this.btnNewMain.AutoSize = true;
            this.btnNewMain.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnNewMain.BackColor = System.Drawing.Color.Transparent;
            this.btnNewMain.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewMain.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnNewMain.FlatAppearance.BorderColor = System.Drawing.Color.LightSlateGray;
            this.btnNewMain.FlatAppearance.BorderSize = 0;
            this.btnNewMain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewMain.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewMain.ForeColor = System.Drawing.Color.LightSlateGray;
            this.btnNewMain.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewMain.Location = new System.Drawing.Point(0, 0);
            this.btnNewMain.Margin = new System.Windows.Forms.Padding(10);
            this.btnNewMain.Name = "btnNewMain";
            this.btnNewMain.Size = new System.Drawing.Size(75, 28);
            this.btnNewMain.TabIndex = 8;
            this.btnNewMain.Text = "New Form";
            this.btnNewMain.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNewMain.UseVisualStyleBackColor = false;
            this.btnNewMain.Click += new System.EventHandler(this.btnNewMain_Click);
            // 
            // Login_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Controls.Add(this.paneCredentials);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Black;
            this.MinimumSize = new System.Drawing.Size(300, 2);
            this.Name = "Login_View";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Size = new System.Drawing.Size(300, 245);
            this.ViewColour = System.Drawing.Color.RoyalBlue;
            this.ViewDescription = "Please, authorize";
            this.ViewTitle = "Welcome";
            this.Controls.SetChildIndex(this.paneCredentials, 0);
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).EndInit();
            this.paneCredentials.ResumeLayout(false);
            this.paneCredentials.PerformLayout();
            this.pnlPassword.ResumeLayout(false);
            this.pnlPassword.PerformLayout();
            this.pnlLogin.ResumeLayout(false);
            this.pnlLogin.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel paneCredentials;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnNewMain;
        private System.Windows.Forms.Panel pnlLogin;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pnlPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label1;
    }
}
