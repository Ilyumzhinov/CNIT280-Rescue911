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
            this.call_Control1 = new Rescue_911.Call_Control();
            this.SuspendLayout();
            // 
            // call_Control1
            // 
            this.call_Control1.AvailableSegments = "t/f/t";
            this.call_Control1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.call_Control1.Location = new System.Drawing.Point(5, 89);
            this.call_Control1.Name = "call_Control1";
            this.call_Control1.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.call_Control1.Size = new System.Drawing.Size(769, 749);
            this.call_Control1.TabIndex = 4;
            // 
            // Call_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.call_Control1);
            this.Name = "Call_View";
            this.Size = new System.Drawing.Size(779, 843);
            this.Controls.SetChildIndex(this.call_Control1, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Call_Control call_Control1;
    }
}
