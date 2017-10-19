namespace Rescue_911
{
    partial class Emergency_Form
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnCreateEmergency = new System.Windows.Forms.Button();
            this.btnLinkEmergency = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "EMERGENCY";
            // 
            // btnCreateEmergency
            // 
            this.btnCreateEmergency.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnCreateEmergency.FlatAppearance.BorderSize = 0;
            this.btnCreateEmergency.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateEmergency.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateEmergency.ForeColor = System.Drawing.Color.White;
            this.btnCreateEmergency.Location = new System.Drawing.Point(20, 87);
            this.btnCreateEmergency.Name = "btnCreateEmergency";
            this.btnCreateEmergency.Size = new System.Drawing.Size(218, 35);
            this.btnCreateEmergency.TabIndex = 3;
            this.btnCreateEmergency.Text = "Create Emergency";
            this.btnCreateEmergency.UseVisualStyleBackColor = false;
            // 
            // btnLinkEmergency
            // 
            this.btnLinkEmergency.BackColor = System.Drawing.Color.SlateGray;
            this.btnLinkEmergency.FlatAppearance.BorderSize = 0;
            this.btnLinkEmergency.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLinkEmergency.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLinkEmergency.ForeColor = System.Drawing.Color.White;
            this.btnLinkEmergency.Location = new System.Drawing.Point(20, 128);
            this.btnLinkEmergency.Name = "btnLinkEmergency";
            this.btnLinkEmergency.Size = new System.Drawing.Size(218, 35);
            this.btnLinkEmergency.TabIndex = 4;
            this.btnLinkEmergency.Text = "Link to Emergency";
            this.btnLinkEmergency.UseVisualStyleBackColor = false;
            this.btnLinkEmergency.Click += new System.EventHandler(this.btnLinkEmergency_Click);
            // 
            // Emergency_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(254, 232);
            this.Controls.Add(this.btnLinkEmergency);
            this.Controls.Add(this.btnCreateEmergency);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Emergency_Form";
            this.Text = "Emergency Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCreateEmergency;
        private System.Windows.Forms.Button btnLinkEmergency;
    }
}