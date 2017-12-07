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
            this.label1 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lbName = new System.Windows.Forms.Label();
            this.lbPassword = new System.Windows.Forms.Label();
            this.btnNewMain = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Location = new System.Drawing.Point(10, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Empoyee ID:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(97, 157);
            this.txtPassword.MaxLength = 100;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(143, 20);
            this.txtPassword.TabIndex = 2;
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(97, 113);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(143, 20);
            this.txtLogin.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label3.Location = new System.Drawing.Point(10, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Password:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnLogin
            // 
            this.btnLogin.AutoSize = true;
            this.btnLogin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogin.Location = new System.Drawing.Point(140, 210);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(0);
            this.btnLogin.MinimumSize = new System.Drawing.Size(100, 0);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(100, 30);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Log in";
            this.btnLogin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.ForeColor = System.Drawing.Color.Red;
            this.lbName.Location = new System.Drawing.Point(30, 131);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(52, 13);
            this.lbName.TabIndex = 6;
            this.lbName.Text = "not found";
            this.lbName.Visible = false;
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.ForeColor = System.Drawing.Color.Red;
            this.lbPassword.Location = new System.Drawing.Point(35, 175);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(47, 13);
            this.lbPassword.TabIndex = 7;
            this.lbPassword.Text = "try again";
            this.lbPassword.Visible = false;
            // 
            // btnNewMain
            // 
            this.btnNewMain.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNewMain.AutoSize = true;
            this.btnNewMain.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnNewMain.BackColor = System.Drawing.Color.Transparent;
            this.btnNewMain.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewMain.FlatAppearance.BorderColor = System.Drawing.Color.LightSlateGray;
            this.btnNewMain.FlatAppearance.BorderSize = 0;
            this.btnNewMain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewMain.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewMain.ForeColor = System.Drawing.Color.LightSlateGray;
            this.btnNewMain.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewMain.Location = new System.Drawing.Point(13, 210);
            this.btnNewMain.Margin = new System.Windows.Forms.Padding(0);
            this.btnNewMain.MinimumSize = new System.Drawing.Size(100, 0);
            this.btnNewMain.Name = "btnNewMain";
            this.btnNewMain.Size = new System.Drawing.Size(100, 30);
            this.btnNewMain.TabIndex = 8;
            this.btnNewMain.Text = "New Form";
            this.btnNewMain.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNewMain.UseVisualStyleBackColor = false;
            this.btnNewMain.Click += new System.EventHandler(this.btnNewMain_Click);
            // 
            // Login_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnNewMain);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtLogin);
            this.Name = "Login_View";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Size = new System.Drawing.Size(250, 250);
            this.ViewColour = System.Drawing.Color.MidnightBlue;
            this.ViewDescription = "Please authorize";
            this.ViewTitle = "Welcome";
            this.Controls.SetChildIndex(this.txtLogin, 0);
            this.Controls.SetChildIndex(this.txtPassword, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.btnLogin, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.lbName, 0);
            this.Controls.SetChildIndex(this.lbPassword, 0);
            this.Controls.SetChildIndex(this.btnNewMain, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.Button btnNewMain;
    }
}
