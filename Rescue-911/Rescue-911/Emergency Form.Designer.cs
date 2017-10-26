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
            this.lbTitle = new System.Windows.Forms.Label();
            this.lvemergencydecreption = new System.Windows.Forms.Label();
            this.lbemergencyid = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbemergencyid1 = new System.Windows.Forms.Label();
            this.lbemergencystats = new System.Windows.Forms.Label();
            this.lbemergencylocation = new System.Windows.Forms.Label();
            this.lbel = new System.Windows.Forms.Label();
            this.lbes = new System.Windows.Forms.Label();
            this.btnCreateEmergency1 = new System.Windows.Forms.Button();
            this.txtemergencyd = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(12, 9);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(124, 24);
            this.lbTitle.TabIndex = 2;
            this.lbTitle.Text = "Emergency";
            // 
            // lvemergencydecreption
            // 
            this.lvemergencydecreption.AutoSize = true;
            this.lvemergencydecreption.Location = new System.Drawing.Point(25, 96);
            this.lvemergencydecreption.Name = "lvemergencydecreption";
            this.lvemergencydecreption.Size = new System.Drawing.Size(144, 16);
            this.lvemergencydecreption.TabIndex = 8;
            this.lvemergencydecreption.Text = "Emergency Descrption:";
            // 
            // lbemergencyid
            // 
            this.lbemergencyid.AutoSize = true;
            this.lbemergencyid.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbemergencyid.Location = new System.Drawing.Point(59, 66);
            this.lbemergencyid.Name = "lbemergencyid";
            this.lbemergencyid.Size = new System.Drawing.Size(110, 18);
            this.lbemergencyid.TabIndex = 11;
            this.lbemergencyid.Text = "Emergency ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(176, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 12;
            // 
            // lbemergencyid1
            // 
            this.lbemergencyid1.AutoSize = true;
            this.lbemergencyid1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbemergencyid1.Location = new System.Drawing.Point(171, 65);
            this.lbemergencyid1.Name = "lbemergencyid1";
            this.lbemergencyid1.Size = new System.Drawing.Size(54, 19);
            this.lbemergencyid1.TabIndex = 16;
            this.lbemergencyid1.Text = "label2";
            // 
            // lbemergencystats
            // 
            this.lbemergencystats.AutoSize = true;
            this.lbemergencystats.Location = new System.Drawing.Point(59, 209);
            this.lbemergencystats.Name = "lbemergencystats";
            this.lbemergencystats.Size = new System.Drawing.Size(113, 16);
            this.lbemergencystats.TabIndex = 9;
            this.lbemergencystats.Text = "Emergency State:";
            // 
            // lbemergencylocation
            // 
            this.lbemergencylocation.AutoSize = true;
            this.lbemergencylocation.Location = new System.Drawing.Point(41, 193);
            this.lbemergencylocation.Name = "lbemergencylocation";
            this.lbemergencylocation.Size = new System.Drawing.Size(131, 16);
            this.lbemergencylocation.TabIndex = 7;
            this.lbemergencylocation.Text = "Emergency Location:";
            // 
            // lbel
            // 
            this.lbel.AutoSize = true;
            this.lbel.Location = new System.Drawing.Point(176, 193);
            this.lbel.Name = "lbel";
            this.lbel.Size = new System.Drawing.Size(42, 16);
            this.lbel.TabIndex = 18;
            this.lbel.Text = "label4";
            // 
            // lbes
            // 
            this.lbes.AutoSize = true;
            this.lbes.Location = new System.Drawing.Point(178, 209);
            this.lbes.Name = "lbes";
            this.lbes.Size = new System.Drawing.Size(42, 16);
            this.lbes.TabIndex = 19;
            this.lbes.Text = "label2";
            // 
            // btnCreateEmergency1
            // 
            this.btnCreateEmergency1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnCreateEmergency1.FlatAppearance.BorderSize = 0;
            this.btnCreateEmergency1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateEmergency1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateEmergency1.ForeColor = System.Drawing.Color.White;
            this.btnCreateEmergency1.Location = new System.Drawing.Point(354, 292);
            this.btnCreateEmergency1.Name = "btnCreateEmergency1";
            this.btnCreateEmergency1.Size = new System.Drawing.Size(218, 35);
            this.btnCreateEmergency1.TabIndex = 20;
            this.btnCreateEmergency1.Text = "Creat a emergency";
            this.btnCreateEmergency1.UseVisualStyleBackColor = false;
            this.btnCreateEmergency1.Click += new System.EventHandler(this.btnCreateEmergency1_Click);
            // 
            // txtemergencyd
            // 
            this.txtemergencyd.Location = new System.Drawing.Point(12, 115);
            this.txtemergencyd.Multiline = true;
            this.txtemergencyd.Name = "txtemergencyd";
            this.txtemergencyd.ReadOnly = true;
            this.txtemergencyd.Size = new System.Drawing.Size(552, 74);
            this.txtemergencyd.TabIndex = 22;
            // 
            // Emergency_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(597, 405);
            this.Controls.Add(this.txtemergencyd);
            this.Controls.Add(this.btnCreateEmergency1);
            this.Controls.Add(this.lbes);
            this.Controls.Add(this.lbel);
            this.Controls.Add(this.lbemergencyid1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbemergencyid);
            this.Controls.Add(this.lbemergencystats);
            this.Controls.Add(this.lvemergencydecreption);
            this.Controls.Add(this.lbemergencylocation);
            this.Controls.Add(this.lbTitle);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Emergency_Form";
            this.Text = "Emergency Form";
            this.Load += new System.EventHandler(this.Emergency_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Label lvemergencydecreption;
        private System.Windows.Forms.Label lbemergencyid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbemergencyid1;
        private System.Windows.Forms.Label lbemergencystats;
        private System.Windows.Forms.Label lbemergencylocation;
        private System.Windows.Forms.Label lbel;
        private System.Windows.Forms.Label lbes;
        private System.Windows.Forms.Button btnCreateEmergency1;
        private System.Windows.Forms.TextBox txtemergencyd;
    }
}