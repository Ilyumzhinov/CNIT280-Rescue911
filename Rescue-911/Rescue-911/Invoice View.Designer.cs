namespace Rescue_911
{
    partial class Invoice_View
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
            this.DTPRenewalDate = new System.Windows.Forms.DateTimePicker();
            this.lstInvoice = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnGenerate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMonthlyFee = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.NUDSubID = new System.Windows.Forms.NumericUpDown();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDSubID)).BeginInit();
            this.SuspendLayout();
            // 
            // DTPRenewalDate
            // 
            this.DTPRenewalDate.Location = new System.Drawing.Point(90, 43);
            this.DTPRenewalDate.Name = "DTPRenewalDate";
            this.DTPRenewalDate.Size = new System.Drawing.Size(200, 20);
            this.DTPRenewalDate.TabIndex = 34;
            // 
            // lstInvoice
            // 
            this.lstInvoice.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader5,
            this.columnHeader4});
            this.lstInvoice.GridLines = true;
            this.lstInvoice.Location = new System.Drawing.Point(7, 120);
            this.lstInvoice.MultiSelect = false;
            this.lstInvoice.Name = "lstInvoice";
            this.lstInvoice.ShowItemToolTips = true;
            this.lstInvoice.Size = new System.Drawing.Size(440, 114);
            this.lstInvoice.TabIndex = 31;
            this.lstInvoice.UseCompatibleStateImageBehavior = false;
            this.lstInvoice.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Sub ID";
            this.columnHeader1.Width = 97;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Fee $";
            this.columnHeader5.Width = 76;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Renewal Date";
            this.columnHeader4.Width = 154;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(374, 59);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(75, 23);
            this.btnGenerate.TabIndex = 30;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Renewal Date:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Monthly Fee:";
            // 
            // txtMonthlyFee
            // 
            this.txtMonthlyFee.Location = new System.Drawing.Point(90, 77);
            this.txtMonthlyFee.Name = "txtMonthlyFee";
            this.txtMonthlyFee.Size = new System.Drawing.Size(100, 20);
            this.txtMonthlyFee.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Subscriber ID:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.NUDSubID);
            this.panel1.Controls.Add(this.txtMonthlyFee);
            this.panel1.Controls.Add(this.DTPRenewalDate);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lstInvoice);
            this.panel1.Controls.Add(this.btnGenerate);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(10, 105);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(470, 365);
            this.panel1.TabIndex = 35;
            // 
            // NUDSubID
            // 
            this.NUDSubID.Location = new System.Drawing.Point(90, 13);
            this.NUDSubID.Margin = new System.Windows.Forms.Padding(2);
            this.NUDSubID.Name = "NUDSubID";
            this.NUDSubID.Size = new System.Drawing.Size(60, 20);
            this.NUDSubID.TabIndex = 35;
            // 
            // Invoice_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "Invoice_View";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Size = new System.Drawing.Size(490, 480);
            this.ViewColour = System.Drawing.Color.DeepPink;
            this.ViewDescription = "";
            this.ViewTitle = "Invoice";
            this.Controls.SetChildIndex(this.panel1, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDSubID)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker DTPRenewalDate;
        private System.Windows.Forms.ListView lstInvoice;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMonthlyFee;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown NUDSubID;
    }
}
