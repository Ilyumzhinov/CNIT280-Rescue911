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
            this.lbCallState = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnLinkEmergency = new System.Windows.Forms.Button();
            this.lbAddress = new System.Windows.Forms.Label();
            this.lvemergencydecreption = new System.Windows.Forms.Label();
            this.lbemergencylocation = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.emergencyList = new Rescue_911.Emergency_List();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDescription
            // 
            this.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(107, 67);
            this.txtDescription.MinimumSize = new System.Drawing.Size(120, 20);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ReadOnly = true;
            this.txtDescription.Size = new System.Drawing.Size(456, 20);
            this.txtDescription.TabIndex = 42;
            // 
            // lbCallState
            // 
            this.lbCallState.AutoSize = true;
            this.lbCallState.ForeColor = System.Drawing.Color.SeaGreen;
            this.lbCallState.Location = new System.Drawing.Point(104, 96);
            this.lbCallState.Name = "lbCallState";
            this.lbCallState.Size = new System.Drawing.Size(30, 13);
            this.lbCallState.TabIndex = 40;
            this.lbCallState.Text = "state";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.DimGray;
            this.label12.Location = new System.Drawing.Point(5, 96);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 13);
            this.label12.TabIndex = 39;
            this.label12.Text = "Call State:";
            // 
            // btnLinkEmergency
            // 
            this.btnLinkEmergency.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnLinkEmergency.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnLinkEmergency.FlatAppearance.BorderSize = 0;
            this.btnLinkEmergency.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLinkEmergency.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLinkEmergency.ForeColor = System.Drawing.Color.White;
            this.btnLinkEmergency.Location = new System.Drawing.Point(428, 341);
            this.btnLinkEmergency.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.btnLinkEmergency.MaximumSize = new System.Drawing.Size(150, 35);
            this.btnLinkEmergency.MinimumSize = new System.Drawing.Size(150, 35);
            this.btnLinkEmergency.Name = "btnLinkEmergency";
            this.btnLinkEmergency.Size = new System.Drawing.Size(150, 35);
            this.btnLinkEmergency.TabIndex = 36;
            this.btnLinkEmergency.Text = "Link to emergency";
            this.btnLinkEmergency.UseVisualStyleBackColor = false;
            this.btnLinkEmergency.Visible = false;
            this.btnLinkEmergency.Click += new System.EventHandler(this.btnLinkEmergency_Click);
            // 
            // lbAddress
            // 
            this.lbAddress.AutoSize = true;
            this.lbAddress.Location = new System.Drawing.Point(104, 48);
            this.lbAddress.Name = "lbAddress";
            this.lbAddress.Size = new System.Drawing.Size(44, 13);
            this.lbAddress.TabIndex = 35;
            this.lbAddress.Text = "address";
            // 
            // lvemergencydecreption
            // 
            this.lvemergencydecreption.AutoSize = true;
            this.lvemergencydecreption.ForeColor = System.Drawing.Color.DimGray;
            this.lvemergencydecreption.Location = new System.Drawing.Point(5, 72);
            this.lvemergencydecreption.Name = "lvemergencydecreption";
            this.lvemergencydecreption.Size = new System.Drawing.Size(81, 13);
            this.lvemergencydecreption.TabIndex = 34;
            this.lvemergencydecreption.Text = "Call Descrption:";
            // 
            // lbemergencylocation
            // 
            this.lbemergencylocation.AutoSize = true;
            this.lbemergencylocation.ForeColor = System.Drawing.Color.DimGray;
            this.lbemergencylocation.Location = new System.Drawing.Point(5, 48);
            this.lbemergencylocation.Name = "lbemergencylocation";
            this.lbemergencylocation.Size = new System.Drawing.Size(68, 13);
            this.lbemergencylocation.TabIndex = 33;
            this.lbemergencylocation.Text = "Call Address:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lbAddress);
            this.panel1.Controls.Add(this.txtDescription);
            this.panel1.Controls.Add(this.lbemergencylocation);
            this.panel1.Controls.Add(this.lbCallState);
            this.panel1.Controls.Add(this.lvemergencydecreption);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(10, 94);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.panel1.Size = new System.Drawing.Size(568, 113);
            this.panel1.TabIndex = 44;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(4, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 24);
            this.label1.TabIndex = 43;
            this.label1.Text = "Logged Call";
            // 
            // emergencyList
            // 
            this.emergencyList.AutoSize = true;
            this.emergencyList.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.emergencyList.Dock = System.Windows.Forms.DockStyle.Top;
            this.emergencyList.Location = new System.Drawing.Point(10, 207);
            this.emergencyList.MinimumSize = new System.Drawing.Size(440, 0);
            this.emergencyList.Name = "emergencyList";
            this.emergencyList.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.emergencyList.Size = new System.Drawing.Size(568, 134);
            this.emergencyList.TabIndex = 45;
            // 
            // Emergency_Link_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnLinkEmergency);
            this.Controls.Add(this.emergencyList);
            this.Controls.Add(this.panel1);
            this.Name = "Emergency_Link_View";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Size = new System.Drawing.Size(588, 373);
            this.SizeChanged += new System.EventHandler(this.Emergency_Link_View_SizeChanged);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.emergencyList, 0);
            this.Controls.SetChildIndex(this.btnLinkEmergency, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lbCallState;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnLinkEmergency;
        private System.Windows.Forms.Label lbAddress;
        private System.Windows.Forms.Label lvemergencydecreption;
        private System.Windows.Forms.Label lbemergencylocation;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private Emergency_List emergencyList;
    }
}
