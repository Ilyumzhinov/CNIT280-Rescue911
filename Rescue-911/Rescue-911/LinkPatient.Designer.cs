namespace Rescue_911
{
    partial class LinkPatient
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.lstsubs = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtSub = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtType = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtProvider = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lb1 = new System.Windows.Forms.Label();
            this.lb3 = new System.Windows.Forms.Label();
            this.lb2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(220, 211);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Non sub";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(220, 297);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Indirec sub";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(220, 254);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Sub";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // lstsubs
            // 
            this.lstsubs.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader5,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader6});
            this.lstsubs.GridLines = true;
            this.lstsubs.Location = new System.Drawing.Point(12, 49);
            this.lstsubs.MultiSelect = false;
            this.lstsubs.Name = "lstsubs";
            this.lstsubs.ShowItemToolTips = true;
            this.lstsubs.Size = new System.Drawing.Size(555, 144);
            this.lstsubs.TabIndex = 12;
            this.lstsubs.UseCompatibleStateImageBehavior = false;
            this.lstsubs.View = System.Windows.Forms.View.Details;
            this.lstsubs.SelectedIndexChanged += new System.EventHandler(this.lstsubs_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "First name Last name";
            this.columnHeader1.Width = 114;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Subscription Staus";
            this.columnHeader5.Width = 107;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "SUB ID";
            this.columnHeader2.Width = 49;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Provider ID";
            this.columnHeader3.Width = 66;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Provider Type";
            this.columnHeader4.Width = 84;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Patient ID";
            // 
            // txtSub
            // 
            this.txtSub.Location = new System.Drawing.Point(84, 19);
            this.txtSub.Name = "txtSub";
            this.txtSub.Size = new System.Drawing.Size(100, 20);
            this.txtSub.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "SUB ID";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSub);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(6, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(190, 45);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SUB";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtType);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtProvider);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Location = new System.Drawing.Point(12, 199);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(202, 122);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Indirec Sub";
            // 
            // txtType
            // 
            this.txtType.Location = new System.Drawing.Point(90, 93);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(100, 20);
            this.txtType.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Provider Type";
            // 
            // txtProvider
            // 
            this.txtProvider.Location = new System.Drawing.Point(90, 67);
            this.txtProvider.Name = "txtProvider";
            this.txtProvider.Size = new System.Drawing.Size(100, 20);
            this.txtProvider.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Provider ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(432, 273);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "SUB COUNT:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(405, 288);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "NON-SUB COUNT:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(385, 305);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "INDIREC-SUB COUNT:";
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Location = new System.Drawing.Point(511, 273);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(35, 13);
            this.lb1.TabIndex = 28;
            this.lb1.Text = "label7";
            // 
            // lb3
            // 
            this.lb3.AutoSize = true;
            this.lb3.Location = new System.Drawing.Point(511, 305);
            this.lb3.Name = "lb3";
            this.lb3.Size = new System.Drawing.Size(35, 13);
            this.lb3.TabIndex = 29;
            this.lb3.Text = "label8";
            // 
            // lb2
            // 
            this.lb2.AutoSize = true;
            this.lb2.Location = new System.Drawing.Point(511, 289);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(35, 13);
            this.lb2.TabIndex = 30;
            this.lb2.Text = "label9";
            // 
            // LinkPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 355);
            this.Controls.Add(this.lb2);
            this.Controls.Add(this.lb3);
            this.Controls.Add(this.lb1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.lstsubs);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "LinkPatient";
            this.Text = this.Text;
            this.Load += new System.EventHandler(this.Linkepatientandsub_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListView lstsubs;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.TextBox txtSub;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtProvider;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.Label lb3;
        private System.Windows.Forms.Label lb2;
    }
}