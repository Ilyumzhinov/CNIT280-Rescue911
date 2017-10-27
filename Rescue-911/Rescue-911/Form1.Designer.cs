namespace Rescue_911
{
    partial class Form1
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
            this.btnWaitingCall = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnReceiveCall = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lbContext = new System.Windows.Forms.Label();
            this.btnBSRecord = new System.Windows.Forms.Button();
            this.btnDispatchTimes = new System.Windows.Forms.Button();
            this.emtlogformbuttom = new System.Windows.Forms.Button();
            this.btnDispatchReport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Teal;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(250, 164);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(300, 50);
            this.button1.TabIndex = 0;
            this.button1.Text = "Log call";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnWaitingCall
            // 
            this.btnWaitingCall.BackColor = System.Drawing.Color.IndianRed;
            this.btnWaitingCall.FlatAppearance.BorderColor = System.Drawing.Color.IndianRed;
            this.btnWaitingCall.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWaitingCall.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWaitingCall.ForeColor = System.Drawing.Color.White;
            this.btnWaitingCall.Location = new System.Drawing.Point(250, 236);
            this.btnWaitingCall.Name = "btnWaitingCall";
            this.btnWaitingCall.Size = new System.Drawing.Size(215, 50);
            this.btnWaitingCall.TabIndex = 1;
            this.btnWaitingCall.Text = "Emergency call";
            this.btnWaitingCall.UseVisualStyleBackColor = false;
            this.btnWaitingCall.Click += new System.EventHandler(this.btnWaitingCall_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Heavy", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(617, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "Emergency Response Information Team";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(12, 527);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Developers:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(12, 540);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(453, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Artem Ilyumzhinov, Muhammad Zeeshan Khalid, Shuai Zhang, Jordan Sexton";
            // 
            // btnReceiveCall
            // 
            this.btnReceiveCall.BackColor = System.Drawing.Color.SandyBrown;
            this.btnReceiveCall.FlatAppearance.BorderColor = System.Drawing.Color.SandyBrown;
            this.btnReceiveCall.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReceiveCall.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReceiveCall.ForeColor = System.Drawing.Color.White;
            this.btnReceiveCall.Location = new System.Drawing.Point(471, 236);
            this.btnReceiveCall.Name = "btnReceiveCall";
            this.btnReceiveCall.Size = new System.Drawing.Size(79, 50);
            this.btnReceiveCall.TabIndex = 5;
            this.btnReceiveCall.Text = "Receive Call";
            this.btnReceiveCall.UseVisualStyleBackColor = false;
            this.btnReceiveCall.Click += new System.EventHandler(this.btnReceiveCall_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(468, 524);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Current context:";
            // 
            // lbContext
            // 
            this.lbContext.AutoSize = true;
            this.lbContext.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbContext.ForeColor = System.Drawing.Color.LightCoral;
            this.lbContext.Location = new System.Drawing.Point(471, 540);
            this.lbContext.Name = "lbContext";
            this.lbContext.Size = new System.Drawing.Size(20, 16);
            this.lbContext.TabIndex = 7;
            this.lbContext.Text = "> ";
            // 
            // btnBSRecord
            // 
            this.btnBSRecord.BackColor = System.Drawing.Color.SteelBlue;
            this.btnBSRecord.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnBSRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBSRecord.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBSRecord.ForeColor = System.Drawing.Color.White;
            this.btnBSRecord.Location = new System.Drawing.Point(335, 308);
            this.btnBSRecord.Name = "btnBSRecord";
            this.btnBSRecord.Size = new System.Drawing.Size(215, 50);
            this.btnBSRecord.TabIndex = 9;
            this.btnBSRecord.Text = "Base Station Record";
            this.btnBSRecord.UseVisualStyleBackColor = false;
            this.btnBSRecord.Click += new System.EventHandler(this.btnBSRecord_Click);
            // 
            // btnDispatchTimes
            // 
            this.btnDispatchTimes.BackColor = System.Drawing.Color.MediumPurple;
            this.btnDispatchTimes.FlatAppearance.BorderColor = System.Drawing.Color.MediumPurple;
            this.btnDispatchTimes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDispatchTimes.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDispatchTimes.ForeColor = System.Drawing.Color.White;
            this.btnDispatchTimes.Location = new System.Drawing.Point(250, 380);
            this.btnDispatchTimes.Name = "btnDispatchTimes";
            this.btnDispatchTimes.Size = new System.Drawing.Size(215, 50);
            this.btnDispatchTimes.TabIndex = 10;
            this.btnDispatchTimes.Text = "Dispatch and arrival times";
            this.btnDispatchTimes.UseVisualStyleBackColor = false;
            this.btnDispatchTimes.Click += new System.EventHandler(this.btnDispatchTimes_Click);
            // 
            // emtlogformbuttom
            // 
            this.emtlogformbuttom.BackColor = System.Drawing.Color.Black;
            this.emtlogformbuttom.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.emtlogformbuttom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.emtlogformbuttom.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emtlogformbuttom.ForeColor = System.Drawing.Color.White;
            this.emtlogformbuttom.Location = new System.Drawing.Point(250, 308);
            this.emtlogformbuttom.Name = "emtlogformbuttom";
            this.emtlogformbuttom.Size = new System.Drawing.Size(79, 50);
            this.emtlogformbuttom.TabIndex = 8;
            this.emtlogformbuttom.Text = "EMT LOG";
            this.emtlogformbuttom.UseVisualStyleBackColor = false;
            this.emtlogformbuttom.Click += new System.EventHandler(this.emtlogformbuttom_Click);
            // 
            // btnDispatchReport
            // 
            this.btnDispatchReport.BackColor = System.Drawing.Color.PaleVioletRed;
            this.btnDispatchReport.FlatAppearance.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnDispatchReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDispatchReport.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDispatchReport.ForeColor = System.Drawing.Color.White;
            this.btnDispatchReport.Location = new System.Drawing.Point(471, 380);
            this.btnDispatchReport.Name = "btnDispatchReport";
            this.btnDispatchReport.Size = new System.Drawing.Size(79, 50);
            this.btnDispatchReport.TabIndex = 11;
            this.btnDispatchReport.Text = "Dispatch Report";
            this.btnDispatchReport.UseVisualStyleBackColor = false;
            this.btnDispatchReport.Click += new System.EventHandler(this.btnDispatchReport_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.btnDispatchReport);
            this.Controls.Add(this.btnDispatchTimes);
            this.Controls.Add(this.btnBSRecord);
            this.Controls.Add(this.emtlogformbuttom);
            this.Controls.Add(this.lbContext);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnReceiveCall);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnWaitingCall);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Rescue-911";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnWaitingCall;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnReceiveCall;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbContext;
        private System.Windows.Forms.Button btnBSRecord;
        private System.Windows.Forms.Button btnDispatchTimes;
        private System.Windows.Forms.Button emtlogformbuttom;
        private System.Windows.Forms.Button btnDispatchReport;
    }
}

