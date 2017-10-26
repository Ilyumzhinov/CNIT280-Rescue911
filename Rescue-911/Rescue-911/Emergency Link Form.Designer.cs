namespace Rescue_911
{
    partial class Emergency_Link_Form
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
            this.lvemergencydecreption = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbemergencylocation = new System.Windows.Forms.Label();
            this.lbAddress = new System.Windows.Forms.Label();
            this.btnLinkEmergency = new System.Windows.Forms.Button();
            this.lbCallState = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lbCallerID = new System.Windows.Forms.Label();
            this.lb11 = new System.Windows.Forms.Label();
            this.lstEmergencies = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(12, 9);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(292, 24);
            this.lbTitle.TabIndex = 2;
            this.lbTitle.Text = "LINK CALL TO EMERGENCY";
            // 
            // lvemergencydecreption
            // 
            this.lvemergencydecreption.AutoSize = true;
            this.lvemergencydecreption.ForeColor = System.Drawing.Color.DimGray;
            this.lvemergencydecreption.Location = new System.Drawing.Point(12, 90);
            this.lvemergencydecreption.Name = "lvemergencydecreption";
            this.lvemergencydecreption.Size = new System.Drawing.Size(100, 16);
            this.lvemergencydecreption.TabIndex = 8;
            this.lvemergencydecreption.Text = "Call Descrption:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(176, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 12;
            // 
            // lbemergencylocation
            // 
            this.lbemergencylocation.AutoSize = true;
            this.lbemergencylocation.ForeColor = System.Drawing.Color.DimGray;
            this.lbemergencylocation.Location = new System.Drawing.Point(12, 58);
            this.lbemergencylocation.Name = "lbemergencylocation";
            this.lbemergencylocation.Size = new System.Drawing.Size(85, 16);
            this.lbemergencylocation.TabIndex = 7;
            this.lbemergencylocation.Text = "Call Address:";
            // 
            // lbAddress
            // 
            this.lbAddress.AutoSize = true;
            this.lbAddress.Location = new System.Drawing.Point(13, 74);
            this.lbAddress.Name = "lbAddress";
            this.lbAddress.Size = new System.Drawing.Size(54, 16);
            this.lbAddress.TabIndex = 18;
            this.lbAddress.Text = "address";
            // 
            // btnLinkEmergency
            // 
            this.btnLinkEmergency.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnLinkEmergency.FlatAppearance.BorderSize = 0;
            this.btnLinkEmergency.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLinkEmergency.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLinkEmergency.ForeColor = System.Drawing.Color.White;
            this.btnLinkEmergency.Location = new System.Drawing.Point(359, 397);
            this.btnLinkEmergency.Name = "btnLinkEmergency";
            this.btnLinkEmergency.Size = new System.Drawing.Size(218, 35);
            this.btnLinkEmergency.TabIndex = 20;
            this.btnLinkEmergency.Text = "Link to emergency";
            this.btnLinkEmergency.UseVisualStyleBackColor = false;
            this.btnLinkEmergency.Visible = false;
            this.btnLinkEmergency.Click += new System.EventHandler(this.btnLinkEmergency_Click);
            // 
            // lbCallState
            // 
            this.lbCallState.AutoSize = true;
            this.lbCallState.ForeColor = System.Drawing.Color.SeaGreen;
            this.lbCallState.Location = new System.Drawing.Point(221, 33);
            this.lbCallState.Name = "lbCallState";
            this.lbCallState.Size = new System.Drawing.Size(37, 16);
            this.lbCallState.TabIndex = 30;
            this.lbCallState.Text = "state";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.DimGray;
            this.label12.Location = new System.Drawing.Point(146, 33);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 16);
            this.label12.TabIndex = 29;
            this.label12.Text = "Call State:";
            // 
            // lbCallerID
            // 
            this.lbCallerID.AutoSize = true;
            this.lbCallerID.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbCallerID.Location = new System.Drawing.Point(79, 33);
            this.lbCallerID.Name = "lbCallerID";
            this.lbCallerID.Size = new System.Drawing.Size(20, 16);
            this.lbCallerID.TabIndex = 28;
            this.lbCallerID.Text = "ID";
            // 
            // lb11
            // 
            this.lb11.AutoSize = true;
            this.lb11.ForeColor = System.Drawing.Color.DimGray;
            this.lb11.Location = new System.Drawing.Point(12, 33);
            this.lb11.Name = "lb11";
            this.lb11.Size = new System.Drawing.Size(61, 16);
            this.lb11.TabIndex = 27;
            this.lb11.Text = "Caller ID:";
            // 
            // lstEmergencies
            // 
            this.lstEmergencies.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader2});
            this.lstEmergencies.GridLines = true;
            this.lstEmergencies.Location = new System.Drawing.Point(16, 151);
            this.lstEmergencies.MultiSelect = false;
            this.lstEmergencies.Name = "lstEmergencies";
            this.lstEmergencies.ShowItemToolTips = true;
            this.lstEmergencies.Size = new System.Drawing.Size(561, 228);
            this.lstEmergencies.TabIndex = 31;
            this.lstEmergencies.UseCompatibleStateImageBehavior = false;
            this.lstEmergencies.View = System.Windows.Forms.View.Details;
            this.lstEmergencies.Visible = false;
            this.lstEmergencies.SelectedIndexChanged += new System.EventHandler(this.lstEmergencies_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Emergency ID";
            this.columnHeader1.Width = 80;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Time Recevied";
            this.columnHeader4.Width = 130;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "State";
            this.columnHeader5.Width = 72;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Description";
            this.columnHeader2.Width = 271;
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(15, 109);
            this.txtDescription.MinimumSize = new System.Drawing.Size(120, 20);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ReadOnly = true;
            this.txtDescription.Size = new System.Drawing.Size(560, 20);
            this.txtDescription.TabIndex = 32;
            // 
            // Emergency_Link_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(589, 444);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lstEmergencies);
            this.Controls.Add(this.lbCallState);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lbCallerID);
            this.Controls.Add(this.lb11);
            this.Controls.Add(this.btnLinkEmergency);
            this.Controls.Add(this.lbAddress);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lvemergencydecreption);
            this.Controls.Add(this.lbemergencylocation);
            this.Controls.Add(this.lbTitle);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Emergency_Link_Form";
            this.Text = "Emergency Link Form";
            this.Load += new System.EventHandler(this.Emergency_Link_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Label lvemergencydecreption;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbemergencylocation;
        private System.Windows.Forms.Label lbAddress;
        private System.Windows.Forms.Button btnLinkEmergency;
        private System.Windows.Forms.Label lbCallState;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lbCallerID;
        private System.Windows.Forms.Label lb11;
        private System.Windows.Forms.ListView lstEmergencies;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.TextBox txtDescription;
    }
}