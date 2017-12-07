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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.emergencyControl = new Rescue_911.Emergency_Control();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // emergencyControl
            // 
            this.emergencyControl.AutoSize = true;
            this.emergencyControl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.emergencyControl.AvailableSegments = "t/f/f/f";
            this.emergencyControl.BackColor = System.Drawing.SystemColors.Window;
            this.emergencyControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.emergencyControl.Location = new System.Drawing.Point(5, 105);
            this.emergencyControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.emergencyControl.Name = "emergencyControl";
            this.emergencyControl.Padding = new System.Windows.Forms.Padding(0, 12, 0, 0);
            this.emergencyControl.Size = new System.Drawing.Size(390, 644);
            this.emergencyControl.TabIndex = 6;
            // 
            // Emergency_Add_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.emergencyControl);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(400, 0);
            this.Name = "Emergency_Add_View";
            this.Size = new System.Drawing.Size(400, 754);
            this.Controls.SetChildIndex(this.emergencyControl, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private Emergency_Control emergencyControl;
    }
}