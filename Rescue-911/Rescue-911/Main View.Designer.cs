﻿namespace Rescue_911
{
    partial class Main_View
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.lbDevelopers = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbUsers = new System.Windows.Forms.Label();
            this.lbTime = new System.Windows.Forms.Label();
            this.eMPLOYEEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.eMPLOYEEBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(26, 392);
            this.label1.Margin = new System.Windows.Forms.Padding(10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Developers:";
            // 
            // lbDevelopers
            // 
            this.lbDevelopers.AutoSize = true;
            this.lbDevelopers.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDevelopers.ForeColor = System.Drawing.Color.DimGray;
            this.lbDevelopers.Location = new System.Drawing.Point(26, 433);
            this.lbDevelopers.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbDevelopers.Name = "lbDevelopers";
            this.lbDevelopers.Size = new System.Drawing.Size(229, 217);
            this.lbDevelopers.TabIndex = 4;
            this.lbDevelopers.Text = "Artem Ilyumzhinov,\r\n\r\nZeeshan Khalid,\r\n\r\nShuai Zhang,\r\n\r\nJordan Sexton";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 200);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Current # of users:";
            // 
            // lbUsers
            // 
            this.lbUsers.AutoSize = true;
            this.lbUsers.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.lbUsers.Location = new System.Drawing.Point(216, 200);
            this.lbUsers.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbUsers.Name = "lbUsers";
            this.lbUsers.Size = new System.Drawing.Size(24, 25);
            this.lbUsers.TabIndex = 6;
            this.lbUsers.Text = "#";
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.ForeColor = System.Drawing.Color.Silver;
            this.lbTime.Location = new System.Drawing.Point(16, 225);
            this.lbTime.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(86, 25);
            this.lbTime.TabIndex = 7;
            this.lbTime.Text = "at TIME";
            // 
            // Main_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbTime);
            this.Controls.Add(this.lbUsers);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbDevelopers);
            this.Name = "Main_View";
            this.Padding = new System.Windows.Forms.Padding(20, 19, 20, 19);
            this.Size = new System.Drawing.Size(717, 883);
            this.Controls.SetChildIndex(this.lbDevelopers, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.lbUsers, 0);
            this.Controls.SetChildIndex(this.lbTime, 0);
            ((System.ComponentModel.ISupportInitialize)(this.eMPLOYEEBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbDevelopers;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbUsers;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.BindingSource eMPLOYEEBindingSource;
    }
}
