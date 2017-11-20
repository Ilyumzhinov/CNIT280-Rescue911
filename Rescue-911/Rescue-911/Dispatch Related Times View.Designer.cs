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
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lstEmergencies = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btnRecordArrival
            // 
            this.btnRecordArrival.Location = new System.Drawing.Point(209, 261);
            this.btnRecordArrival.Name = "btnRecordArrival";
            this.btnRecordArrival.Size = new System.Drawing.Size(121, 23);
            this.btnRecordArrival.TabIndex = 24;
            this.btnRecordArrival.Text = "Record Arrival Time";
            this.btnRecordArrival.UseVisualStyleBackColor = true;
            this.btnRecordArrival.Click += new System.EventHandler(this.btnRecordArrival_Click);
            // 
            // btnDispatchTime
            // 
            this.btnDispatchTime.Location = new System.Drawing.Point(70, 261);
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
            this.dtPicker.Location = new System.Drawing.Point(102, 233);
            this.dtPicker.Name = "dtPicker";
            this.dtPicker.Size = new System.Drawing.Size(200, 20);
            this.dtPicker.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Operator Name:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(102, 73);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(116, 20);
            this.textBox1.TabIndex = 19;
            // 
            // lstEmergencies
            // 
            this.lstEmergencies.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader5,
            this.columnHeader4,
            this.columnHeader6});
            this.lstEmergencies.GridLines = true;
            this.lstEmergencies.Location = new System.Drawing.Point(17, 113);
            this.lstEmergencies.MultiSelect = false;
            this.lstEmergencies.Name = "lstEmergencies";
            this.lstEmergencies.ShowItemToolTips = true;
            this.lstEmergencies.Size = new System.Drawing.Size(501, 114);
            this.lstEmergencies.TabIndex = 18;
            this.lstEmergencies.UseCompatibleStateImageBehavior = false;
            this.lstEmergencies.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Emergency ID";
            this.columnHeader1.Width = 80;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Location";
            this.columnHeader5.Width = 97;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Time Dispatched";
            this.columnHeader4.Width = 130;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Arrival Time";
            this.columnHeader6.Width = 115;
            // 
            // Dispatch_Related_Times_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnRecordArrival);
            this.Controls.Add(this.btnDispatchTime);
            this.Controls.Add(this.dtPicker);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lstEmergencies);
            this.Name = "Dispatch_Related_Times_View";
            this.Size = new System.Drawing.Size(523, 289);
            this.Controls.SetChildIndex(this.lstEmergencies, 0);
            this.Controls.SetChildIndex(this.textBox1, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.dtPicker, 0);
            this.Controls.SetChildIndex(this.btnDispatchTime, 0);
            this.Controls.SetChildIndex(this.btnRecordArrival, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRecordArrival;
        private System.Windows.Forms.Button btnDispatchTime;
        private System.Windows.Forms.DateTimePicker dtPicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListView lstEmergencies;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader6;
    }
}
