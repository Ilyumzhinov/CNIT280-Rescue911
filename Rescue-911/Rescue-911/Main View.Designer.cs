namespace Rescue_911
{
    partial class Main_View
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.lbDevelopers = new System.Windows.Forms.Label();
            this.eMPLOYEEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panelForSpecials = new System.Windows.Forms.FlowLayoutPanel();
            this.specialPanel = new Rescue_911.Special_Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.specialPanelEC = new Rescue_911.Special_Panel();
            this.specialPanelActiveRTs = new Rescue_911.Special_Panel();
            this.specialPanelPatients = new Rescue_911.Special_Panel();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLOYEEBindingSource)).BeginInit();
            this.panelForSpecials.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(5, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Developers:";
            // 
            // lbDevelopers
            // 
            this.lbDevelopers.AutoSize = true;
            this.lbDevelopers.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDevelopers.ForeColor = System.Drawing.Color.DimGray;
            this.lbDevelopers.Location = new System.Drawing.Point(5, 34);
            this.lbDevelopers.Name = "lbDevelopers";
            this.lbDevelopers.Size = new System.Drawing.Size(117, 112);
            this.lbDevelopers.TabIndex = 4;
            this.lbDevelopers.Text = "Artem Ilyumzhinov,\r\n\r\nZeeshan Khalid,\r\n\r\nShuai Zhang,\r\n\r\nJordan Sexton";
            // 
            // panelForSpecials
            // 
            this.panelForSpecials.AutoSize = true;
            this.panelForSpecials.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelForSpecials.Controls.Add(this.specialPanel);
            this.panelForSpecials.Controls.Add(this.specialPanelPatients);
            this.panelForSpecials.Controls.Add(this.specialPanelEC);
            this.panelForSpecials.Controls.Add(this.specialPanelActiveRTs);
            this.panelForSpecials.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelForSpecials.Location = new System.Drawing.Point(5, 103);
            this.panelForSpecials.Margin = new System.Windows.Forms.Padding(0);
            this.panelForSpecials.Name = "panelForSpecials";
            this.panelForSpecials.Size = new System.Drawing.Size(320, 320);
            this.panelForSpecials.TabIndex = 8;
            // 
            // specialPanel
            // 
            this.specialPanel.BackColor = System.Drawing.Color.LightCoral;
            this.specialPanel.Location = new System.Drawing.Point(5, 5);
            this.specialPanel.Margin = new System.Windows.Forms.Padding(5);
            this.specialPanel.MaximumSize = new System.Drawing.Size(100, 100);
            this.specialPanel.MinimumSize = new System.Drawing.Size(150, 150);
            this.specialPanel.Name = "specialPanel";
            this.specialPanel.Number = null;
            this.specialPanel.Padding = new System.Windows.Forms.Padding(5);
            this.specialPanel.Size = new System.Drawing.Size(150, 150);
            this.specialPanel.TabIndex = 0;
            this.specialPanel.Title = "Current number of online users";
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lbDevelopers);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(5, 423);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(320, 146);
            this.panel1.TabIndex = 9;
            // 
            // specialPanelEC
            // 
            this.specialPanelEC.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.specialPanelEC.Location = new System.Drawing.Point(5, 165);
            this.specialPanelEC.Margin = new System.Windows.Forms.Padding(5);
            this.specialPanelEC.MaximumSize = new System.Drawing.Size(100, 100);
            this.specialPanelEC.MinimumSize = new System.Drawing.Size(150, 150);
            this.specialPanelEC.Name = "specialPanelEC";
            this.specialPanelEC.Number = "0";
            this.specialPanelEC.Padding = new System.Windows.Forms.Padding(5);
            this.specialPanelEC.Size = new System.Drawing.Size(150, 150);
            this.specialPanelEC.TabIndex = 1;
            this.specialPanelEC.Title = "Current number of Emergency Calls";
            // 
            // specialPanelActiveRTs
            // 
            this.specialPanelActiveRTs.BackColor = System.Drawing.Color.SandyBrown;
            this.specialPanelActiveRTs.Location = new System.Drawing.Point(165, 165);
            this.specialPanelActiveRTs.Margin = new System.Windows.Forms.Padding(5);
            this.specialPanelActiveRTs.MaximumSize = new System.Drawing.Size(100, 100);
            this.specialPanelActiveRTs.MinimumSize = new System.Drawing.Size(150, 150);
            this.specialPanelActiveRTs.Name = "specialPanelActiveRTs";
            this.specialPanelActiveRTs.Number = "0";
            this.specialPanelActiveRTs.Padding = new System.Windows.Forms.Padding(5);
            this.specialPanelActiveRTs.Size = new System.Drawing.Size(150, 150);
            this.specialPanelActiveRTs.TabIndex = 2;
            this.specialPanelActiveRTs.Title = "Current number of active Response Teams";
            // 
            // specialPanelPatients
            // 
            this.specialPanelPatients.BackColor = System.Drawing.Color.SteelBlue;
            this.specialPanelPatients.Location = new System.Drawing.Point(165, 5);
            this.specialPanelPatients.Margin = new System.Windows.Forms.Padding(5);
            this.specialPanelPatients.MaximumSize = new System.Drawing.Size(100, 100);
            this.specialPanelPatients.MinimumSize = new System.Drawing.Size(150, 150);
            this.specialPanelPatients.Name = "specialPanelPatients";
            this.specialPanelPatients.Number = "0";
            this.specialPanelPatients.Padding = new System.Windows.Forms.Padding(5);
            this.specialPanelPatients.Size = new System.Drawing.Size(150, 150);
            this.specialPanelPatients.TabIndex = 3;
            this.specialPanelPatients.Title = "Current number of Patients";
            // 
            // Main_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelForSpecials);
            this.Name = "Main_View";
            this.Size = new System.Drawing.Size(330, 574);
            this.ViewColour = System.Drawing.Color.LightCoral;
            this.ViewDescription = "";
            this.ViewTitle = "Main View";
            this.Controls.SetChildIndex(this.panelForSpecials, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.eMPLOYEEBindingSource)).EndInit();
            this.panelForSpecials.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbDevelopers;
        private System.Windows.Forms.BindingSource eMPLOYEEBindingSource;
        private System.Windows.Forms.FlowLayoutPanel panelForSpecials;
        private System.Windows.Forms.Panel panel1;
        private Special_Panel specialPanel;
        private Special_Panel specialPanelEC;
        private Special_Panel specialPanelActiveRTs;
        private Special_Panel specialPanelPatients;
    }
}
