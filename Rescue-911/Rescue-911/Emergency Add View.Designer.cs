namespace Rescue_911
{
    partial class Emergency_Add_View
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SuspendLayout();
            // 
            // lvemergencydecreption
            // 
            this.lvemergencydecreption.AutoSize = true;
            this.lvemergencydecreption.Location = new System.Drawing.Point(2, 123);
            this.lvemergencydecreption.Name = "lvemergencydecreption";
            this.lvemergencydecreption.Size = new System.Drawing.Size(144, 16);
            this.lvemergencydecreption.TabIndex = 8;
            this.lvemergencydecreption.Text = "Emergency Descrption:";
            // 
            // lbemergencyid
            // 
            this.lbemergencyid.AutoSize = true;
            this.lbemergencyid.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbemergencyid.Location = new System.Drawing.Point(-3, 97);
            this.lbemergencyid.Name = "lbemergencyid";
            this.lbemergencyid.Size = new System.Drawing.Size(110, 18);
            this.lbemergencyid.TabIndex = 11;
            this.lbemergencyid.Text = "Emergency ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(160, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 12;
            // 
            // lbemergencyid1
            // 
            this.lbemergencyid1.AutoSize = true;
            this.lbemergencyid1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbemergencyid1.Location = new System.Drawing.Point(106, 97);
            this.lbemergencyid1.Name = "lbemergencyid1";
            this.lbemergencyid1.Size = new System.Drawing.Size(54, 19);
            this.lbemergencyid1.TabIndex = 16;
            this.lbemergencyid1.Text = "label2";
            // 
            // lbemergencystats
            // 
            this.lbemergencystats.AutoSize = true;
            this.lbemergencystats.Location = new System.Drawing.Point(2, 235);
            this.lbemergencystats.Name = "lbemergencystats";
            this.lbemergencystats.Size = new System.Drawing.Size(113, 16);
            this.lbemergencystats.TabIndex = 9;
            this.lbemergencystats.Text = "Emergency State:";
            // 
            // lbemergencylocation
            // 
            this.lbemergencylocation.AutoSize = true;
            this.lbemergencylocation.Location = new System.Drawing.Point(2, 219);
            this.lbemergencylocation.Name = "lbemergencylocation";
            this.lbemergencylocation.Size = new System.Drawing.Size(131, 16);
            this.lbemergencylocation.TabIndex = 7;
            this.lbemergencylocation.Text = "Emergency Location:";
            // 
            // lbel
            // 
            this.lbel.AutoSize = true;
            this.lbel.Location = new System.Drawing.Point(130, 219);
            this.lbel.Name = "lbel";
            this.lbel.Size = new System.Drawing.Size(42, 16);
            this.lbel.TabIndex = 18;
            this.lbel.Text = "label4";
            // 
            // lbes
            // 
            this.lbes.AutoSize = true;
            this.lbes.Location = new System.Drawing.Point(130, 235);
            this.lbes.Name = "lbes";
            this.lbes.Size = new System.Drawing.Size(42, 16);
            this.lbes.TabIndex = 19;
            this.lbes.Text = "label2";
            // 
            // btnCreateEmergency1
            // 
            this.btnCreateEmergency1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnCreateEmergency1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreateEmergency1.FlatAppearance.BorderSize = 0;
            this.btnCreateEmergency1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateEmergency1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateEmergency1.ForeColor = System.Drawing.Color.White;
            this.btnCreateEmergency1.Location = new System.Drawing.Point(345, 222);
            this.btnCreateEmergency1.Name = "btnCreateEmergency1";
            this.btnCreateEmergency1.Size = new System.Drawing.Size(218, 35);
            this.btnCreateEmergency1.TabIndex = 20;
            this.btnCreateEmergency1.Text = "Creat a emergency";
            this.btnCreateEmergency1.UseVisualStyleBackColor = false;
            this.btnCreateEmergency1.Click += new System.EventHandler(this.btnCreateEmergency1_Click);
            // 
            // txtemergencyd
            // 
            this.txtemergencyd.Location = new System.Drawing.Point(11, 142);
            this.txtemergencyd.Multiline = true;
            this.txtemergencyd.Name = "txtemergencyd";
            this.txtemergencyd.ReadOnly = true;
            this.txtemergencyd.Size = new System.Drawing.Size(552, 74);
            this.txtemergencyd.TabIndex = 22;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Emergency_Add_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
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
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Emergency_Add_View";
            this.Size = new System.Drawing.Size(571, 265);
            this.Controls.SetChildIndex(this.lbemergencylocation, 0);
            this.Controls.SetChildIndex(this.lvemergencydecreption, 0);
            this.Controls.SetChildIndex(this.lbemergencystats, 0);
            this.Controls.SetChildIndex(this.lbemergencyid, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.lbemergencyid1, 0);
            this.Controls.SetChildIndex(this.lbel, 0);
            this.Controls.SetChildIndex(this.lbes, 0);
            this.Controls.SetChildIndex(this.btnCreateEmergency1, 0);
            this.Controls.SetChildIndex(this.txtemergencyd, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}