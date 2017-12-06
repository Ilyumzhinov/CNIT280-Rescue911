﻿namespace Rescue_911
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
            this.emergencyList = new Rescue_911.Emergency_List();
            this.callControlOverview = new Rescue_911.Call_Control();
            this.SuspendLayout();
            // 
            // btnLinkEmergency
            // 
            this.btnLinkEmergency.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnLinkEmergency.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnLinkEmergency.FlatAppearance.BorderSize = 0;
            this.btnLinkEmergency.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLinkEmergency.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLinkEmergency.ForeColor = System.Drawing.Color.White;
            this.btnLinkEmergency.Location = new System.Drawing.Point(196, 763);
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
            // emergencyList
            // 
            this.emergencyList.AutoSize = true;
            this.emergencyList.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.emergencyList.Dock = System.Windows.Forms.DockStyle.Top;
            this.emergencyList.Location = new System.Drawing.Point(4, 627);
            this.emergencyList.MinimumSize = new System.Drawing.Size(440, 0);
            this.emergencyList.Name = "emergencyList";
            this.emergencyList.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.emergencyList.Size = new System.Drawing.Size(440, 136);
            this.emergencyList.TabIndex = 45;
            // 
            // callControlOverview
            // 
            this.callControlOverview.AutoSize = true;
            this.callControlOverview.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.callControlOverview.AvailableSegments = "f/f/t";
            this.callControlOverview.BackColor = System.Drawing.SystemColors.Window;
            this.callControlOverview.Dock = System.Windows.Forms.DockStyle.Top;
            this.callControlOverview.Location = new System.Drawing.Point(4, 104);
            this.callControlOverview.Name = "callControlOverview";
            this.callControlOverview.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.callControlOverview.Size = new System.Drawing.Size(342, 523);
            this.callControlOverview.TabIndex = 46;
            // 
            // Emergency_Link_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnLinkEmergency);
            this.Controls.Add(this.emergencyList);
            this.Controls.Add(this.callControlOverview);
            this.MinimumSize = new System.Drawing.Size(350, 0);
            this.Name = "Emergency_Link_View";
            this.Padding = new System.Windows.Forms.Padding(4);
            this.Size = new System.Drawing.Size(350, 767);
            this.SizeChanged += new System.EventHandler(this.Emergency_Link_View_SizeChanged);
            this.Controls.SetChildIndex(this.callControlOverview, 0);
            this.Controls.SetChildIndex(this.emergencyList, 0);
            this.Controls.SetChildIndex(this.btnLinkEmergency, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnLinkEmergency;
        private Emergency_List emergencyList;
        private Call_Control callControlOverview;
    }
}
