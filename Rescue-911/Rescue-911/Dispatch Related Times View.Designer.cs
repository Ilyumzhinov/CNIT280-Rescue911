namespace Rescue_911
{
    partial class Dispatch_Related_Times_View
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
            this.btnRecordArrival = new System.Windows.Forms.Button();
            this.btnDispatchTime = new System.Windows.Forms.Button();
            this.dtPicker = new System.Windows.Forms.DateTimePicker();
            this.emergency_List1 = new Rescue_911.Emergency_List();
            this.SuspendLayout();
            // 
            // btnRecordArrival
            // 
            this.btnRecordArrival.Location = new System.Drawing.Point(135, 273);
            this.btnRecordArrival.Name = "btnRecordArrival";
            this.btnRecordArrival.Size = new System.Drawing.Size(121, 23);
            this.btnRecordArrival.TabIndex = 24;
            this.btnRecordArrival.Text = "Record Arrival Time";
            this.btnRecordArrival.UseVisualStyleBackColor = true;
            this.btnRecordArrival.Click += new System.EventHandler(this.btnRecordArrival_Click);
            // 
            // btnDispatchTime
            // 
            this.btnDispatchTime.Location = new System.Drawing.Point(8, 273);
            this.btnDispatchTime.Name = "btnDispatchTime";
            this.btnDispatchTime.Size = new System.Drawing.Size(121, 23);
            this.btnDispatchTime.TabIndex = 23;
            this.btnDispatchTime.Text = "Record Dispatch Time";
            this.btnDispatchTime.UseVisualStyleBackColor = true;
            this.btnDispatchTime.Click += new System.EventHandler(this.btnDispatchTime_Click);
            // 
            // dtPicker
            // 
            this.dtPicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtPicker.Location = new System.Drawing.Point(8, 247);
            this.dtPicker.Name = "dtPicker";
            this.dtPicker.Size = new System.Drawing.Size(200, 20);
            this.dtPicker.TabIndex = 22;
            // 
            // emergency_List1
            // 
            this.emergency_List1.AutoSize = true;
            this.emergency_List1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.emergency_List1.Location = new System.Drawing.Point(8, 107);
            this.emergency_List1.MinimumSize = new System.Drawing.Size(440, 0);
            this.emergency_List1.Name = "emergency_List1";
            this.emergency_List1.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.emergency_List1.Size = new System.Drawing.Size(440, 134);
            this.emergency_List1.TabIndex = 25;
            // 
            // Dispatch_Related_Times_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.emergency_List1);
            this.Controls.Add(this.btnRecordArrival);
            this.Controls.Add(this.btnDispatchTime);
            this.Controls.Add(this.dtPicker);
            this.Name = "Dispatch_Related_Times_View";
            this.Size = new System.Drawing.Size(456, 304);
            this.Controls.SetChildIndex(this.dtPicker, 0);
            this.Controls.SetChildIndex(this.btnDispatchTime, 0);
            this.Controls.SetChildIndex(this.btnRecordArrival, 0);
            this.Controls.SetChildIndex(this.emergency_List1, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRecordArrival;
        private System.Windows.Forms.Button btnDispatchTime;
        private System.Windows.Forms.DateTimePicker dtPicker;
        private Emergency_List emergency_List1;
    }
}
