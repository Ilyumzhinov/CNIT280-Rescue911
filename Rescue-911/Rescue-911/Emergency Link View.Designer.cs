namespace Rescue_911
{
    partial class Emergency_Link_View
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
            this.btnLinkEmergency = new System.Windows.Forms.Button();
            this.callControlOverview = new Rescue_911.Call_Control();
            this.emergencyControl = new Rescue_911.Emergency_Control();
            this.SuspendLayout();
            // 
            // btnLinkEmergency
            // 
            this.btnLinkEmergency.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnLinkEmergency.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnLinkEmergency.FlatAppearance.BorderSize = 0;
            this.btnLinkEmergency.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLinkEmergency.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLinkEmergency.ForeColor = System.Drawing.Color.White;
            this.btnLinkEmergency.Location = new System.Drawing.Point(5, 1048);
            this.btnLinkEmergency.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.btnLinkEmergency.MaximumSize = new System.Drawing.Size(150, 35);
            this.btnLinkEmergency.MinimumSize = new System.Drawing.Size(150, 35);
            this.btnLinkEmergency.Name = "btnLinkEmergency";
            this.btnLinkEmergency.Size = new System.Drawing.Size(150, 35);
            this.btnLinkEmergency.TabIndex = 36;
            this.btnLinkEmergency.Text = "Link to emergency";
            this.btnLinkEmergency.UseVisualStyleBackColor = false;
            this.btnLinkEmergency.Visible = false;
            this.btnLinkEmergency.Click += new System.EventHandler(this.btnLinkEmergency_Click);
            // 
            // callControlOverview
            // 
            this.callControlOverview.AutoSize = true;
            this.callControlOverview.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.callControlOverview.AvailableSegments = "f/f/t";
            this.callControlOverview.BackColor = System.Drawing.SystemColors.Window;
            this.callControlOverview.Dock = System.Windows.Forms.DockStyle.Top;
            this.callControlOverview.Location = new System.Drawing.Point(5, 103);
            this.callControlOverview.Margin = new System.Windows.Forms.Padding(0);
            this.callControlOverview.Name = "callControlOverview";
            this.callControlOverview.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.callControlOverview.Size = new System.Drawing.Size(323, 399);
            this.callControlOverview.TabIndex = 46;
            // 
            // emergencyControl
            // 
            this.emergencyControl.AutoSize = true;
            this.emergencyControl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.emergencyControl.AvailableSegments = "f/f/f/t";
            this.emergencyControl.BackColor = System.Drawing.SystemColors.Window;
            this.emergencyControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.emergencyControl.Location = new System.Drawing.Point(5, 502);
            this.emergencyControl.Margin = new System.Windows.Forms.Padding(0);
            this.emergencyControl.Name = "emergencyControl";
            this.emergencyControl.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.emergencyControl.Size = new System.Drawing.Size(323, 546);
            this.emergencyControl.TabIndex = 47;
            // 
            // Emergency_Link_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnLinkEmergency);
            this.Controls.Add(this.emergencyControl);
            this.Controls.Add(this.callControlOverview);
            this.MinimumSize = new System.Drawing.Size(350, 0);
            this.Name = "Emergency_Link_View";
            this.Size = new System.Drawing.Size(333, 980);
            this.ViewColour = System.Drawing.Color.Green;
            this.ViewDescription = "Select the emergency";
            this.ViewTitle = "Link to Emergency";
            this.Controls.SetChildIndex(this.callControlOverview, 0);
            this.Controls.SetChildIndex(this.emergencyControl, 0);
            this.Controls.SetChildIndex(this.btnLinkEmergency, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnLinkEmergency;
        private Call_Control callControlOverview;
        private Emergency_Control emergencyControl;
    }
}
