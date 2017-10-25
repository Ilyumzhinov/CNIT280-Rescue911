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
            this.btnWaitingCall.Text = "Waiting call";
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 562);
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
    }
}

