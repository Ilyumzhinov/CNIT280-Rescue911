﻿namespace Rescue_911
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
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labemtid = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
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
            this.button1.Text = "SHIFT LOG IN";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.btnWaitingCall.Click += new System.EventHandler(this.btnWaitingCall_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "EMT ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(486, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Total Worked Hours:";
            // 
            // LBtotalworkedhours
            // 
            this.LBtotalworkedhours.AutoSize = true;
            this.LBtotalworkedhours.Location = new System.Drawing.Point(598, 6);
            this.LBtotalworkedhours.Name = "LBtotalworkedhours";
            this.LBtotalworkedhours.Size = new System.Drawing.Size(35, 13);
            this.LBtotalworkedhours.TabIndex = 6;
            this.LBtotalworkedhours.Text = "label3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "SHIFT TIME:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "CURRENT TIME:";
            // 
            // LBshifttime
            // 
            this.LBshifttime.AutoSize = true;
            this.LBshifttime.Location = new System.Drawing.Point(107, 27);
            this.LBshifttime.Name = "LBshifttime";
            this.LBshifttime.Size = new System.Drawing.Size(35, 13);
            this.LBshifttime.TabIndex = 9;
            this.LBshifttime.Text = "label5";
            // 
            // LBcurrenttime
            // 
            this.LBcurrenttime.AutoSize = true;
            this.LBcurrenttime.Location = new System.Drawing.Point(106, 6);
            this.LBcurrenttime.Name = "LBcurrenttime";
            this.LBcurrenttime.Size = new System.Drawing.Size(0, 13);
            this.LBcurrenttime.TabIndex = 10;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(504, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Response Team:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(598, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "label6";
            // 
            // labemtid
            // 
            this.labemtid.AutoSize = true;
            this.labemtid.Location = new System.Drawing.Point(108, 46);
            this.labemtid.Name = "labemtid";
            this.labemtid.Size = new System.Drawing.Size(35, 13);
            this.labemtid.TabIndex = 14;
            this.labemtid.Text = "label7";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(545, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Logtime:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(598, 46);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "NOT READY";
            // 
            // EMT_login_shift
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 521);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.labemtid);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
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
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labemtid;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}