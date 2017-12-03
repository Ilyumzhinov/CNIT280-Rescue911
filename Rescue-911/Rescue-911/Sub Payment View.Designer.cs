namespace Rescue_911
{
    partial class Sub_Payment_View
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
            this.numSubID = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPay = new System.Windows.Forms.Button();
            this.DTPExpiryDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCreditCardNumber = new System.Windows.Forms.TextBox();
            this.txtCVC = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numSubID)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // numSubID
            // 
            this.numSubID.Location = new System.Drawing.Point(64, 14);
            this.numSubID.Margin = new System.Windows.Forms.Padding(2);
            this.numSubID.Name = "numSubID";
            this.numSubID.Size = new System.Drawing.Size(60, 20);
            this.numSubID.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnPay);
            this.panel1.Controls.Add(this.DTPExpiryDate);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtCreditCardNumber);
            this.panel1.Controls.Add(this.txtCVC);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.numSubID);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(2, 87);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(310, 201);
            this.panel1.TabIndex = 5;
            // 
            // btnPay
            // 
            this.btnPay.AutoSize = true;
            this.btnPay.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPay.BackColor = System.Drawing.Color.Transparent;
            this.btnPay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPay.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnPay.FlatAppearance.BorderSize = 0;
            this.btnPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPay.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPay.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnPay.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPay.Location = new System.Drawing.Point(190, 119);
            this.btnPay.Margin = new System.Windows.Forms.Padding(0);
            this.btnPay.MinimumSize = new System.Drawing.Size(100, 0);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(100, 30);
            this.btnPay.TabIndex = 13;
            this.btnPay.Text = "PAY";
            this.btnPay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPay.UseVisualStyleBackColor = false;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // DTPExpiryDate
            // 
            this.DTPExpiryDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTPExpiryDate.Location = new System.Drawing.Point(102, 86);
            this.DTPExpiryDate.Margin = new System.Windows.Forms.Padding(2);
            this.DTPExpiryDate.Name = "DTPExpiryDate";
            this.DTPExpiryDate.Size = new System.Drawing.Size(102, 20);
            this.DTPExpiryDate.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 128);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "CVC:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 92);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Exp. Date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 58);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Credit Card #:";
            // 
            // txtCreditCardNumber
            // 
            this.txtCreditCardNumber.Location = new System.Drawing.Point(102, 55);
            this.txtCreditCardNumber.Margin = new System.Windows.Forms.Padding(2);
            this.txtCreditCardNumber.Name = "txtCreditCardNumber";
            this.txtCreditCardNumber.Size = new System.Drawing.Size(188, 20);
            this.txtCreditCardNumber.TabIndex = 8;
            // 
            // txtCVC
            // 
            this.txtCVC.Location = new System.Drawing.Point(102, 125);
            this.txtCVC.Margin = new System.Windows.Forms.Padding(2);
            this.txtCVC.Name = "txtCVC";
            this.txtCVC.Size = new System.Drawing.Size(52, 20);
            this.txtCVC.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Sub ID:";
            // 
            // Sub_Payment_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "Sub_Payment_View";
            this.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Size = new System.Drawing.Size(314, 291);
            this.Controls.SetChildIndex(this.panel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.numSubID)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numSubID;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker DTPExpiryDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCreditCardNumber;
        private System.Windows.Forms.TextBox txtCVC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPay;
    }
}
