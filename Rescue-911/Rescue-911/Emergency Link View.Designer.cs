namespace Rescue_911
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
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lstEmergencies = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lbCallState = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnLinkEmergency = new System.Windows.Forms.Button();
            this.lbAddress = new System.Windows.Forms.Label();
            this.lvemergencydecreption = new System.Windows.Forms.Label();
            this.lbemergencylocation = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(12, 84);
            this.txtDescription.MinimumSize = new System.Drawing.Size(120, 20);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ReadOnly = true;
            this.txtDescription.Size = new System.Drawing.Size(560, 20);
            this.txtDescription.TabIndex = 42;
            // 
            // lstEmergencies
            // 
            this.lstEmergencies.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader2});
            this.lstEmergencies.GridLines = true;
            this.lstEmergencies.Location = new System.Drawing.Point(12, 114);
            this.lstEmergencies.MultiSelect = false;
            this.lstEmergencies.Name = "lstEmergencies";
            this.lstEmergencies.ShowItemToolTips = true;
            this.lstEmergencies.Size = new System.Drawing.Size(561, 228);
            this.lstEmergencies.TabIndex = 41;
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
            // lbCallState
            // 
            this.lbCallState.AutoSize = true;
            this.lbCallState.ForeColor = System.Drawing.Color.SeaGreen;
            this.lbCallState.Location = new System.Drawing.Point(85, 10);
            this.lbCallState.Name = "lbCallState";
            this.lbCallState.Size = new System.Drawing.Size(30, 13);
            this.lbCallState.TabIndex = 40;
            this.lbCallState.Text = "state";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.DimGray;
            this.label12.Location = new System.Drawing.Point(10, 10);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 13);
            this.label12.TabIndex = 39;
            this.label12.Text = "Call State:";
            // 
            // btnLinkEmergency
            // 
            this.btnLinkEmergency.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnLinkEmergency.FlatAppearance.BorderSize = 0;
            this.btnLinkEmergency.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLinkEmergency.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLinkEmergency.ForeColor = System.Drawing.Color.White;
            this.btnLinkEmergency.Location = new System.Drawing.Point(355, 348);
            this.btnLinkEmergency.Name = "btnLinkEmergency";
            this.btnLinkEmergency.Size = new System.Drawing.Size(218, 35);
            this.btnLinkEmergency.TabIndex = 36;
            this.btnLinkEmergency.Text = "Link to emergency";
            this.btnLinkEmergency.UseVisualStyleBackColor = false;
            this.btnLinkEmergency.Visible = false;
            this.btnLinkEmergency.Click += new System.EventHandler(this.btnLinkEmergency_Click);
            // 
            // lbAddress
            // 
            this.lbAddress.AutoSize = true;
            this.lbAddress.Location = new System.Drawing.Point(10, 49);
            this.lbAddress.Name = "lbAddress";
            this.lbAddress.Size = new System.Drawing.Size(44, 13);
            this.lbAddress.TabIndex = 35;
            this.lbAddress.Text = "address";
            // 
            // lvemergencydecreption
            // 
            this.lvemergencydecreption.AutoSize = true;
            this.lvemergencydecreption.ForeColor = System.Drawing.Color.DimGray;
            this.lvemergencydecreption.Location = new System.Drawing.Point(9, 65);
            this.lvemergencydecreption.Name = "lvemergencydecreption";
            this.lvemergencydecreption.Size = new System.Drawing.Size(81, 13);
            this.lvemergencydecreption.TabIndex = 34;
            this.lvemergencydecreption.Text = "Call Descrption:";
            // 
            // lbemergencylocation
            // 
            this.lbemergencylocation.AutoSize = true;
            this.lbemergencylocation.ForeColor = System.Drawing.Color.DimGray;
            this.lbemergencylocation.Location = new System.Drawing.Point(9, 33);
            this.lbemergencylocation.Name = "lbemergencylocation";
            this.lbemergencylocation.Size = new System.Drawing.Size(68, 13);
            this.lbemergencylocation.TabIndex = 33;
            this.lbemergencylocation.Text = "Call Address:";
            // 
            // Emergency_Link_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lstEmergencies);
            this.Controls.Add(this.lbCallState);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnLinkEmergency);
            this.Controls.Add(this.lbAddress);
            this.Controls.Add(this.lvemergencydecreption);
            this.Controls.Add(this.lbemergencylocation);
            this.Name = "Emergency_Link_View";
            this.Size = new System.Drawing.Size(588, 396);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.ListView lstEmergencies;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label lbCallState;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnLinkEmergency;
        private System.Windows.Forms.Label lbAddress;
        private System.Windows.Forms.Label lvemergencydecreption;
        private System.Windows.Forms.Label lbemergencylocation;
    }
}
