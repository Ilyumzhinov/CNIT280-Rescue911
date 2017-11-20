namespace Rescue_911
{
    partial class Dispatch_Report_View
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
            this.lbEmergencyID = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lbCallID = new System.Windows.Forms.Label();
            this.lb11 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtBill = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chkVital = new System.Windows.Forms.CheckBox();
            this.txtHospital = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtProcedureDetails = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbEmergencyID
            // 
            this.lbEmergencyID.AutoSize = true;
            this.lbEmergencyID.ForeColor = System.Drawing.Color.SeaGreen;
            this.lbEmergencyID.Location = new System.Drawing.Point(96, 75);
            this.lbEmergencyID.Name = "lbEmergencyID";
            this.lbEmergencyID.Size = new System.Drawing.Size(30, 13);
            this.lbEmergencyID.TabIndex = 36;
            this.lbEmergencyID.Text = "state";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.DimGray;
            this.label12.Location = new System.Drawing.Point(13, 75);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(77, 13);
            this.label12.TabIndex = 35;
            this.label12.Text = "Emergency ID:";
            // 
            // lbCallID
            // 
            this.lbCallID.AutoSize = true;
            this.lbCallID.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbCallID.Location = new System.Drawing.Point(70, 62);
            this.lbCallID.Name = "lbCallID";
            this.lbCallID.Size = new System.Drawing.Size(18, 13);
            this.lbCallID.TabIndex = 34;
            this.lbCallID.Text = "ID";
            // 
            // lb11
            // 
            this.lb11.AutoSize = true;
            this.lb11.ForeColor = System.Drawing.Color.DimGray;
            this.lb11.Location = new System.Drawing.Point(14, 62);
            this.lb11.Name = "lb11";
            this.lb11.Size = new System.Drawing.Size(50, 13);
            this.lb11.TabIndex = 33;
            this.lb11.Text = "Caller ID:";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(512, 401);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 32;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtBill);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.chkVital);
            this.panel2.Controls.Add(this.txtHospital);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.txtProcedureDetails);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Location = new System.Drawing.Point(16, 104);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(390, 320);
            this.panel2.TabIndex = 31;
            // 
            // txtBill
            // 
            this.txtBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBill.Location = new System.Drawing.Point(127, 241);
            this.txtBill.MinimumSize = new System.Drawing.Size(120, 20);
            this.txtBill.Name = "txtBill";
            this.txtBill.Size = new System.Drawing.Size(252, 22);
            this.txtBill.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 244);
            this.label1.MinimumSize = new System.Drawing.Size(120, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 16);
            this.label1.TabIndex = 23;
            this.label1.Text = "Bill";
            // 
            // chkVital
            // 
            this.chkVital.AutoSize = true;
            this.chkVital.Location = new System.Drawing.Point(127, 217);
            this.chkVital.Name = "chkVital";
            this.chkVital.Size = new System.Drawing.Size(65, 17);
            this.chkVital.TabIndex = 22;
            this.chkVital.Text = "Normal?";
            this.chkVital.UseVisualStyleBackColor = true;
            // 
            // txtHospital
            // 
            this.txtHospital.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHospital.Location = new System.Drawing.Point(127, 32);
            this.txtHospital.MinimumSize = new System.Drawing.Size(120, 20);
            this.txtHospital.Name = "txtHospital";
            this.txtHospital.Size = new System.Drawing.Size(252, 22);
            this.txtHospital.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 35);
            this.label8.MinimumSize = new System.Drawing.Size(120, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 16);
            this.label8.TabIndex = 15;
            this.label8.Text = "Hospital";
            // 
            // txtProcedureDetails
            // 
            this.txtProcedureDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProcedureDetails.Location = new System.Drawing.Point(127, 64);
            this.txtProcedureDetails.MinimumSize = new System.Drawing.Size(120, 20);
            this.txtProcedureDetails.Multiline = true;
            this.txtProcedureDetails.Name = "txtProcedureDetails";
            this.txtProcedureDetails.Size = new System.Drawing.Size(252, 140);
            this.txtProcedureDetails.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(3, 67);
            this.label9.MinimumSize = new System.Drawing.Size(120, 13);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 16);
            this.label9.TabIndex = 17;
            this.label9.Text = "Procedure detail";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(3, 218);
            this.label10.MinimumSize = new System.Drawing.Size(120, 13);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(120, 16);
            this.label10.TabIndex = 19;
            this.label10.Text = "Vital Sign";
            // 
            // Dispatch_Report_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbEmergencyID);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lbCallID);
            this.Controls.Add(this.lb11);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.panel2);
            this.Name = "Dispatch_Report_View";
            this.Size = new System.Drawing.Size(594, 436);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.btnSubmit, 0);
            this.Controls.SetChildIndex(this.lb11, 0);
            this.Controls.SetChildIndex(this.lbCallID, 0);
            this.Controls.SetChildIndex(this.label12, 0);
            this.Controls.SetChildIndex(this.lbEmergencyID, 0);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbEmergencyID;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lbCallID;
        private System.Windows.Forms.Label lb11;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtBill;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkVital;
        private System.Windows.Forms.TextBox txtHospital;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtProcedureDetails;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}
