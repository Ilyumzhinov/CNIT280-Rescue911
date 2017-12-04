namespace Rescue_911
{
    partial class Response_Teams_List
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
            this.lstRTs = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BS = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Grade = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lbTitle = new System.Windows.Forms.Label();
            this.cmbBStation = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstRTs
            // 
            this.lstRTs.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.BS,
            this.Grade,
            this.Status});
            this.lstRTs.Dock = System.Windows.Forms.DockStyle.Top;
            this.lstRTs.Font = new System.Drawing.Font("Franklin Gothic Book", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstRTs.FullRowSelect = true;
            this.lstRTs.GridLines = true;
            this.lstRTs.Location = new System.Drawing.Point(0, 40);
            this.lstRTs.Margin = new System.Windows.Forms.Padding(0);
            this.lstRTs.MinimumSize = new System.Drawing.Size(300, 100);
            this.lstRTs.MultiSelect = false;
            this.lstRTs.Name = "lstRTs";
            this.lstRTs.ShowItemToolTips = true;
            this.lstRTs.Size = new System.Drawing.Size(440, 100);
            this.lstRTs.TabIndex = 11;
            this.lstRTs.UseCompatibleStateImageBehavior = false;
            this.lstRTs.View = System.Windows.Forms.View.Details;
            this.lstRTs.SelectedIndexChanged += new System.EventHandler(this.lstRTs_SelectedIndexChanged);
            // 
            // ID
            // 
            this.ID.Text = "RT ID";
            this.ID.Width = 100;
            // 
            // BS
            // 
            this.BS.Text = "Base Station";
            this.BS.Width = 100;
            // 
            // Grade
            // 
            this.Grade.Text = "Grade";
            this.Grade.Width = 100;
            // 
            // Status
            // 
            this.Status.Text = "Status";
            this.Status.Width = 100;
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbTitle.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.Gray;
            this.lbTitle.Location = new System.Drawing.Point(0, 0);
            this.lbTitle.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(160, 30);
            this.lbTitle.TabIndex = 12;
            this.lbTitle.Text = "Response Teams";
            // 
            // cmbBStation
            // 
            this.cmbBStation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBStation.Font = new System.Drawing.Font("Franklin Gothic Book", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBStation.ForeColor = System.Drawing.Color.Black;
            this.cmbBStation.FormattingEnabled = true;
            this.cmbBStation.Location = new System.Drawing.Point(283, 2);
            this.cmbBStation.Margin = new System.Windows.Forms.Padding(0);
            this.cmbBStation.Name = "cmbBStation";
            this.cmbBStation.Size = new System.Drawing.Size(121, 26);
            this.cmbBStation.TabIndex = 13;
            this.cmbBStation.SelectedIndexChanged += new System.EventHandler(this.cmbState_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Book", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(170, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "at Base Station";
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.lbTitle);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cmbBStation);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(440, 30);
            this.panel1.TabIndex = 15;
            // 
            // Response_Teams_List
            // 
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.lstRTs);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(440, 0);
            this.Name = "Response_Teams_List";
            this.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.Size = new System.Drawing.Size(440, 140);
            this.SizeChanged += new System.EventHandler(this.Emergency_List_SizeChanged);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstRTs;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader BS;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.ComboBox cmbBStation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ColumnHeader Grade;
        private System.Windows.Forms.ColumnHeader Status;
    }
}
