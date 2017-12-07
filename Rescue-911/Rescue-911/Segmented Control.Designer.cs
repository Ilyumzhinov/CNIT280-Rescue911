using System.ComponentModel;

namespace Rescue_911
{
    partial class Segmented_Control
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise,A false.</param>
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
            this.lbPreview = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbPreview
            // 
            this.lbPreview.AutoSize = true;
            this.lbPreview.BackColor = System.Drawing.Color.Transparent;
            this.lbPreview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbPreview.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbPreview.Location = new System.Drawing.Point(0, 0);
            this.lbPreview.Name = "lbPreview";
            this.lbPreview.Size = new System.Drawing.Size(90, 13);
            this.lbPreview.TabIndex = 0;
            this.lbPreview.Text = "Segments Control";
            this.lbPreview.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Segmented_Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.lbPreview);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Margin = new System.Windows.Forms.Padding(0);
            this.MinimumSize = new System.Drawing.Size(75, 28);
            this.Name = "Segmented_Control";
            this.Size = new System.Drawing.Size(90, 28);
            this.SizeChanged += new System.EventHandler(this.Segmented_Control_SizeChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbPreview;
    }
}
