namespace Rescue_911
{
    partial class EMT_login_shift
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.btnWaitingCall = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LBtotalworkedhours = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LBshifttime = new System.Windows.Forms.Label();
            this.LBcurrenttime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(178, 181);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(300, 50);
            this.button1.TabIndex = 1;
            this.button1.Text = "Enter";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnWaitingCall
            // 
            this.btnWaitingCall.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnWaitingCall.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnWaitingCall.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWaitingCall.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWaitingCall.ForeColor = System.Drawing.Color.White;
            this.btnWaitingCall.Location = new System.Drawing.Point(178, 247);
            this.btnWaitingCall.Name = "btnWaitingCall";
            this.btnWaitingCall.Size = new System.Drawing.Size(300, 50);
            this.btnWaitingCall.TabIndex = 2;
            this.btnWaitingCall.Text = "SHIFT LOG OUT";
            this.btnWaitingCall.UseVisualStyleBackColor = false;
            this.btnWaitingCall.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "EMT ID:";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(522, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Total Worked Hours:";
            this.label2.Visible = false;
            // 
            // LBtotalworkedhours
            // 
            this.LBtotalworkedhours.AutoSize = true;
            this.LBtotalworkedhours.Location = new System.Drawing.Point(634, 9);
            this.LBtotalworkedhours.Name = "LBtotalworkedhours";
            this.LBtotalworkedhours.Size = new System.Drawing.Size(35, 13);
            this.LBtotalworkedhours.TabIndex = 6;
            this.LBtotalworkedhours.Text = "label3";
            this.LBtotalworkedhours.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "SHIFT TIME:";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "CURRENT TIME:";
            this.label4.Visible = false;
            // 
            // LBshifttime
            // 
            this.LBshifttime.AutoSize = true;
            this.LBshifttime.Location = new System.Drawing.Point(107, 27);
            this.LBshifttime.Name = "LBshifttime";
            this.LBshifttime.Size = new System.Drawing.Size(35, 13);
            this.LBshifttime.TabIndex = 9;
            this.LBshifttime.Text = "label5";
            this.LBshifttime.Visible = false;
            // 
            // LBcurrenttime
            // 
            this.LBcurrenttime.AutoSize = true;
            this.LBcurrenttime.Location = new System.Drawing.Point(106, 6);
            this.LBcurrenttime.Name = "LBcurrenttime";
            this.LBcurrenttime.Size = new System.Drawing.Size(0, 13);
            this.LBcurrenttime.TabIndex = 10;
            this.LBcurrenttime.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(107, 44);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 11;
            this.comboBox1.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(540, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Response Team:";
            this.label5.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(634, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "label6";
            this.label6.Visible = false;
            // 
            // EMT_login_shift
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 521);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.LBcurrenttime);
            this.Controls.Add(this.LBshifttime);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LBtotalworkedhours);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnWaitingCall);
            this.Controls.Add(this.button1);
            this.Name = "EMT_login_shift";
            this.Load += new System.EventHandler(this.EMT_login_shift_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnWaitingCall;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LBtotalworkedhours;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LBshifttime;
        private System.Windows.Forms.Label LBcurrenttime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}