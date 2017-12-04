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
            this.cmbState = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cmbStation = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
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
            this.lstRTs.Location = new System.Drawing.Point(0, 36);
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
            // cmbState
            // 
            this.cmbState.Dock = System.Windows.Forms.DockStyle.Left;
            this.cmbState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbState.Font = new System.Drawing.Font("Franklin Gothic Book", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbState.ForeColor = System.Drawing.Color.Black;
            this.cmbState.FormattingEnabled = true;
            this.cmbState.Location = new System.Drawing.Point(68, 0);
            this.cmbState.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.cmbState.Name = "cmbState";
            this.cmbState.Size = new System.Drawing.Size(121, 23);
            this.cmbState.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Book", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(5);
            this.label2.MinimumSize = new System.Drawing.Size(67, 0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.label2.Size = new System.Drawing.Size(68, 0);
            this.label2.TabIndex = 1;
            this.label2.Text = "with state";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel3
            // 
            this.panel3.AutoSize = true;
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 10);
            this.panel3.MinimumSize = new System.Drawing.Size(0, 26);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(440, 26);
            this.panel3.TabIndex = 16;
            // 
            // panel4
            // 
            this.panel4.AutoSize = true;
            this.panel4.Controls.Add(this.cmbStation);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(135, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(0);
            this.panel4.MinimumSize = new System.Drawing.Size(200, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(221, 26);
            this.panel4.TabIndex = 15;
            // 
            // cmbStation
            // 
            this.cmbStation.Dock = System.Windows.Forms.DockStyle.Left;
            this.cmbStation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStation.Font = new System.Drawing.Font("Franklin Gothic Book", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbStation.ForeColor = System.Drawing.Color.Black;
            this.cmbStation.FormattingEnabled = true;
            this.cmbStation.Location = new System.Drawing.Point(100, 0);
            this.cmbStation.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.cmbStation.Name = "cmbStation";
            this.cmbStation.Size = new System.Drawing.Size(121, 23);
            this.cmbStation.TabIndex = 2;
            this.cmbStation.SelectedIndexChanged += new System.EventHandler(this.cmbStation_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Left;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Book", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(5);
            this.label3.MinimumSize = new System.Drawing.Size(100, 0);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.label3.Size = new System.Drawing.Size(100, 26);
            this.label3.TabIndex = 1;
            this.label3.Text = "at Base Station";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Left;
            this.label4.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.label4.Size = new System.Drawing.Size(135, 24);
            this.label4.TabIndex = 12;
            this.label4.Text = "Response Teams";
            // 
            // Response_Teams_List
            // 
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lstRTs);
            this.Controls.Add(this.panel3);
            this.MinimumSize = new System.Drawing.Size(440, 0);
            this.Name = "Response_Teams_List";
            this.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.Size = new System.Drawing.Size(440, 136);
            this.SizeChanged += new System.EventHandler(this.Emergency_List_SizeChanged);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstRTs;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader BS;
        private System.Windows.Forms.ColumnHeader Grade;
        private System.Windows.Forms.ColumnHeader Status;
        private System.Windows.Forms.ComboBox cmbState;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox cmbStation;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}
