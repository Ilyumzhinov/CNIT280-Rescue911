namespace Rescue_911
{
    partial class Emergency_Form
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
            this.btnCreateEmergency = new System.Windows.Forms.Button();
            this.btnLinkEmergency = new System.Windows.Forms.Button();
            this.lstEmergencies = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lbState = new System.Windows.Forms.Label();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(12, 9);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(142, 24);
            this.lbTitle.TabIndex = 2;
            this.lbTitle.Text = "EMERGENCY";
            // 
            // btnCreateEmergency
            // 
            this.btnCreateEmergency.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnCreateEmergency.FlatAppearance.BorderSize = 0;
            this.btnCreateEmergency.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateEmergency.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateEmergency.ForeColor = System.Drawing.Color.White;
            this.btnCreateEmergency.Location = new System.Drawing.Point(20, 87);
            this.btnCreateEmergency.Name = "btnCreateEmergency";
            this.btnCreateEmergency.Size = new System.Drawing.Size(218, 35);
            this.btnCreateEmergency.TabIndex = 3;
            this.btnCreateEmergency.Text = "Create Emergency";
            this.btnCreateEmergency.UseVisualStyleBackColor = false;
            this.btnCreateEmergency.Click += new System.EventHandler(this.btnCreateEmergency_Click);
            // 
            // btnLinkEmergency
            // 
            this.btnLinkEmergency.BackColor = System.Drawing.Color.SlateGray;
            this.btnLinkEmergency.FlatAppearance.BorderSize = 0;
            this.btnLinkEmergency.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLinkEmergency.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLinkEmergency.ForeColor = System.Drawing.Color.White;
            this.btnLinkEmergency.Location = new System.Drawing.Point(20, 128);
            this.btnLinkEmergency.Name = "btnLinkEmergency";
            this.btnLinkEmergency.Size = new System.Drawing.Size(218, 35);
            this.btnLinkEmergency.TabIndex = 4;
            this.btnLinkEmergency.Text = "Link to Emergency";
            this.btnLinkEmergency.UseVisualStyleBackColor = false;
            this.btnLinkEmergency.Click += new System.EventHandler(this.btnLinkEmergency_Click);
            // 
            // lstEmergencies
            // 
            this.lstEmergencies.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader2});
            this.lstEmergencies.GridLines = true;
            this.lstEmergencies.Location = new System.Drawing.Point(12, 169);
            this.lstEmergencies.Name = "lstEmergencies";
            this.lstEmergencies.ShowItemToolTips = true;
            this.lstEmergencies.Size = new System.Drawing.Size(560, 97);
            this.lstEmergencies.TabIndex = 5;
            this.lstEmergencies.UseCompatibleStateImageBehavior = false;
            this.lstEmergencies.View = System.Windows.Forms.View.Details;
            this.lstEmergencies.Visible = false;
            this.lstEmergencies.SelectedIndexChanged += new System.EventHandler(this.lstEmergencies_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Emergency ID";
            this.columnHeader1.Width = 96;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Time Recevied";
            this.columnHeader4.Width = 117;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "State";
            this.columnHeader5.Width = 72;
            // 
            // lbState
            // 
            this.lbState.AutoSize = true;
            this.lbState.Location = new System.Drawing.Point(17, 33);
            this.lbState.Name = "lbState";
            this.lbState.Size = new System.Drawing.Size(42, 16);
            this.lbState.TabIndex = 6;
            this.lbState.Text = "label1";
            this.lbState.Visible = false;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Description";
            this.columnHeader2.Width = 271;
            // 
            // Emergency_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(584, 366);
            this.Controls.Add(this.lbState);
            this.Controls.Add(this.lstEmergencies);
            this.Controls.Add(this.btnLinkEmergency);
            this.Controls.Add(this.btnCreateEmergency);
            this.Controls.Add(this.lbTitle);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Emergency_Form";
            this.Text = "Emergency Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Button btnCreateEmergency;
        private System.Windows.Forms.Button btnLinkEmergency;
        private System.Windows.Forms.ListView lstEmergencies;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Label lbState;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}