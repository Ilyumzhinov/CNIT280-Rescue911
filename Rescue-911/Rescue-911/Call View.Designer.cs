namespace Rescue_911
{
    partial class Call_View
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
            this.callControl = new Rescue_911.Call_Control();
            this.SuspendLayout();
            // 
            // callControl
            // 
            this.callControl.AutoScroll = true;
            this.callControl.AutoSize = true;
            this.callControl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.callControl.AvailableSegments = "t/t/t";
            this.callControl.BackColor = System.Drawing.Color.Transparent;
            this.callControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.callControl.Location = new System.Drawing.Point(5, 103);
            this.callControl.Margin = new System.Windows.Forms.Padding(0);
            this.callControl.Name = "callControl";
            this.callControl.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.callControl.Size = new System.Drawing.Size(769, 735);
            this.callControl.TabIndex = 4;
            // 
            // Call_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.callControl);
            this.Name = "Call_View";
            this.Size = new System.Drawing.Size(779, 843);
            this.ViewColour = System.Drawing.Color.Teal;
            this.ViewDescription = "When all information is filled in, either add or link the Call to an Emergency";
            this.ViewTitle = "Call Management";
            this.Controls.SetChildIndex(this.callControl, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Call_Control callControl;
    }
}
