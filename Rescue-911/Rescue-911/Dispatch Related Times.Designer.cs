namespace Rescue_911
{
    partial class Dispatch_Related_Times
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
            this.lbTitle = new System.Windows.Forms.Label();
            this.lstEmergencies = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.dtPicker = new System.Windows.Forms.DateTimePicker();
            this.btnDispatchTime = new System.Windows.Forms.Button();
            this.btnRecordArrival = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(12, 9);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(281, 24);
            this.lbTitle.TabIndex = 3;
            this.lbTitle.Text = "Dispatch and Arrival Times";
            // 
            // lstEmergencies
            // 
            this.lstEmergencies.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader5,
            this.columnHeader4,
            this.columnHeader6});
            this.lstEmergencies.GridLines = true;
            this.lstEmergencies.Location = new System.Drawing.Point(16, 97);
            this.lstEmergencies.MultiSelect = false;
            this.lstEmergencies.Name = "lstEmergencies";
            this.lstEmergencies.ShowItemToolTips = true;
            this.lstEmergencies.Size = new System.Drawing.Size(501, 114);
            this.lstEmergencies.TabIndex = 11;
            this.lstEmergencies.UseCompatibleStateImageBehavior = false;
            this.lstEmergencies.View = System.Windows.Forms.View.Details;
            this.lstEmergencies.SelectedIndexChanged += new System.EventHandler(this.lstEmergencies_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Emergency ID";
            this.columnHeader1.Width = 80;
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
            // columnHeader5
            // 
            this.columnHeader5.Text = "Location";
            this.columnHeader5.Width = 97;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Operator Name:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(101, 57);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(116, 20);
            this.textBox1.TabIndex = 12;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(442, 245);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 14;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dtPicker
            // 
            this.dtPicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtPicker.Location = new System.Drawing.Point(101, 217);
            this.dtPicker.Name = "dtPicker";
            this.dtPicker.Size = new System.Drawing.Size(200, 20);
            this.dtPicker.TabIndex = 15;
            // 
            // btnDispatchTime
            // 
            this.btnDispatchTime.Location = new System.Drawing.Point(69, 245);
            this.btnDispatchTime.Name = "btnDispatchTime";
            this.btnDispatchTime.Size = new System.Drawing.Size(121, 23);
            this.btnDispatchTime.TabIndex = 16;
            this.btnDispatchTime.Text = "Record Dispatch Time";
            this.btnDispatchTime.UseVisualStyleBackColor = true;
            this.btnDispatchTime.Click += new System.EventHandler(this.btnDispatchTime_Click);
            // 
            // btnRecordArrival
            // 
            this.btnRecordArrival.Location = new System.Drawing.Point(208, 245);
            this.btnRecordArrival.Name = "btnRecordArrival";
            this.btnRecordArrival.Size = new System.Drawing.Size(121, 23);
            this.btnRecordArrival.TabIndex = 17;
            this.btnRecordArrival.Text = "Record Arrival Time";
            this.btnRecordArrival.UseVisualStyleBackColor = true;
            this.btnRecordArrival.Click += new System.EventHandler(this.btnRecordArrival_Click);
            // 
            // Dispatch_Related_Times
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 290);
            this.Controls.Add(this.btnRecordArrival);
            this.Controls.Add(this.btnDispatchTime);
            this.Controls.Add(this.dtPicker);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lstEmergencies);
            this.Controls.Add(this.lbTitle);
            this.Name = "Dispatch_Related_Times";
            this.Text = "Dispatch_Related_Times";
            this.Load += new System.EventHandler(this.Dispatch_Related_Times_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.ListView lstEmergencies;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DateTimePicker dtPicker;
        private System.Windows.Forms.Button btnDispatchTime;
        private System.Windows.Forms.Button btnRecordArrival;
    }
}