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
            this.panel1 = new System.Windows.Forms.Panel();
            this.emergencyControl = new Rescue_911.Emergency_Control();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRecordArrival
            // 
            this.btnRecordArrival.BackColor = System.Drawing.Color.MediumPurple;
            this.btnRecordArrival.FlatAppearance.BorderSize = 0;
            this.btnRecordArrival.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecordArrival.Font = new System.Drawing.Font("Franklin Gothic Book", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecordArrival.ForeColor = System.Drawing.Color.White;
            this.btnRecordArrival.Location = new System.Drawing.Point(237, 34);
            this.btnRecordArrival.Name = "btnRecordArrival";
            this.btnRecordArrival.Size = new System.Drawing.Size(200, 23);
            this.btnRecordArrival.TabIndex = 24;
            this.btnRecordArrival.Text = "Record Arrival Time";
            this.btnRecordArrival.UseVisualStyleBackColor = false;
            this.btnRecordArrival.Click += new System.EventHandler(this.btnRecordArrival_Click);
            // 
            // btnDispatchTime
            // 
            this.btnDispatchTime.BackColor = System.Drawing.Color.MediumPurple;
            this.btnDispatchTime.FlatAppearance.BorderSize = 0;
            this.btnDispatchTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDispatchTime.Font = new System.Drawing.Font("Franklin Gothic Book", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDispatchTime.ForeColor = System.Drawing.Color.White;
            this.btnDispatchTime.Location = new System.Drawing.Point(3, 34);
            this.btnDispatchTime.Name = "btnDispatchTime";
            this.btnDispatchTime.Size = new System.Drawing.Size(200, 23);
            this.btnDispatchTime.TabIndex = 23;
            this.btnDispatchTime.Text = "Record Dispatch Time";
            this.btnDispatchTime.UseVisualStyleBackColor = false;
            this.btnDispatchTime.Click += new System.EventHandler(this.btnDispatchTime_Click);
            // 
            // dtPicker
            // 
            this.dtPicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtPicker.Location = new System.Drawing.Point(3, 8);
            this.dtPicker.Name = "dtPicker";
            this.dtPicker.Size = new System.Drawing.Size(200, 20);
            this.dtPicker.TabIndex = 22;
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.dtPicker);
            this.panel1.Controls.Add(this.btnRecordArrival);
            this.panel1.Controls.Add(this.btnDispatchTime);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(5, 650);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(440, 60);
            this.panel1.TabIndex = 25;
            // 
            // emergencyControl
            // 
            this.emergencyControl.AutoSize = true;
            this.emergencyControl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.emergencyControl.AvailableSegments = "f/f/f/t";
            this.emergencyControl.BackColor = System.Drawing.SystemColors.Window;
            this.emergencyControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.emergencyControl.Location = new System.Drawing.Point(5, 103);
            this.emergencyControl.Margin = new System.Windows.Forms.Padding(0);
            this.emergencyControl.Name = "emergencyControl";
            this.emergencyControl.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.emergencyControl.Size = new System.Drawing.Size(440, 547);
            this.emergencyControl.TabIndex = 26;
            // 
            // Dispatch_Related_Times_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.emergencyControl);
            this.MinimumSize = new System.Drawing.Size(450, 0);
            this.Name = "Dispatch_Related_Times_View";
            this.Size = new System.Drawing.Size(450, 715);
            this.ViewColour = System.Drawing.Color.MediumPurple;
            this.ViewDescription = "Record dispatch time by selecting an item from the list and clicking buttons";
            this.ViewTitle = "Dispatch Related Times";
            this.Controls.SetChildIndex(this.emergencyControl, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRecordArrival;
        private System.Windows.Forms.Button btnDispatchTime;
        private System.Windows.Forms.DateTimePicker dtPicker;
        private System.Windows.Forms.Panel panel1;
        private Emergency_Control emergencyControl;
    }
}
