namespace Rescue_911
{
    partial class Emergency_Control
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.segmentMain = new Rescue_911.Segmented_Control();
            this.lbTitle = new System.Windows.Forms.Label();
            this.panelSegments = new System.Windows.Forms.FlowLayoutPanel();
            this.panelAdd = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlSpecs = new System.Windows.Forms.Panel();
            this.pnlUpdateBtn = new System.Windows.Forms.Panel();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.pnlAddEmergencyBtn = new System.Windows.Forms.Panel();
            this.btnAddEmer = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cboEmergencyType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtEmergencyID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbpnlSpecs = new System.Windows.Forms.Label();
            this.pnlRelatedData = new System.Windows.Forms.Panel();
            this.callControlView = new Rescue_911.Call_Control();
            this.lbpnlRelatedCalls = new System.Windows.Forms.Label();
            this.panelList = new System.Windows.Forms.Panel();
            this.lstEmergencies = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TeamsRequired = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Priority = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.State = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Description = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lbpnlEmergencyList = new System.Windows.Forms.Label();
            this.pnlParameters = new System.Windows.Forms.Panel();
            this.pnlList_Params = new System.Windows.Forms.Panel();
            this.cmbState = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panelSegments.SuspendLayout();
            this.panelAdd.SuspendLayout();
            this.pnlSpecs.SuspendLayout();
            this.pnlUpdateBtn.SuspendLayout();
            this.pnlAddEmergencyBtn.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlRelatedData.SuspendLayout();
            this.panelList.SuspendLayout();
            this.pnlParameters.SuspendLayout();
            this.pnlList_Params.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.segmentMain);
            this.panel1.Controls.Add(this.lbTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 10);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.MinimumSize = new System.Drawing.Size(0, 33);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.panel1.Size = new System.Drawing.Size(1010, 33);
            this.panel1.TabIndex = 16;
            // 
            // segmentMain
            // 
            this.segmentMain.AutoSize = true;
            this.segmentMain.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.segmentMain.AvailableSegments = "t/t/t/t";
            this.segmentMain.Cursor = System.Windows.Forms.Cursors.Hand;
            this.segmentMain.Dock = System.Windows.Forms.DockStyle.Left;
            this.segmentMain.Location = new System.Drawing.Point(100, 0);
            this.segmentMain.Margin = new System.Windows.Forms.Padding(0);
            this.segmentMain.MaximumSize = new System.Drawing.Size(0, 23);
            this.segmentMain.MinimumSize = new System.Drawing.Size(75, 23);
            this.segmentMain.Name = "segmentMain";
            this.segmentMain.Segments = "Add/Edit/View/List";
            this.segmentMain.Size = new System.Drawing.Size(75, 23);
            this.segmentMain.TabIndex = 13;
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbTitle.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.Gray;
            this.lbTitle.Location = new System.Drawing.Point(0, 0);
            this.lbTitle.Margin = new System.Windows.Forms.Padding(0);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Padding = new System.Windows.Forms.Padding(5, 0, 10, 0);
            this.lbTitle.Size = new System.Drawing.Size(100, 24);
            this.lbTitle.TabIndex = 12;
            this.lbTitle.Text = "Emergency";
            // 
            // panelSegments
            // 
            this.panelSegments.AutoScroll = true;
            this.panelSegments.AutoSize = true;
            this.panelSegments.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelSegments.BackColor = System.Drawing.Color.Transparent;
            this.panelSegments.Controls.Add(this.panelAdd);
            this.panelSegments.Controls.Add(this.panelList);
            this.panelSegments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSegments.Location = new System.Drawing.Point(0, 76);
            this.panelSegments.Margin = new System.Windows.Forms.Padding(3, 15, 3, 3);
            this.panelSegments.MaximumSize = new System.Drawing.Size(0, 2000);
            this.panelSegments.Name = "panelSegments";
            this.panelSegments.Size = new System.Drawing.Size(1010, 564);
            this.panelSegments.TabIndex = 17;
            // 
            // panelAdd
            // 
            this.panelAdd.AutoSize = true;
            this.panelAdd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelAdd.BackColor = System.Drawing.Color.Transparent;
            this.panelAdd.Controls.Add(this.pnlSpecs);
            this.panelAdd.Controls.Add(this.pnlRelatedData);
            this.panelAdd.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAdd.Location = new System.Drawing.Point(0, 0);
            this.panelAdd.Margin = new System.Windows.Forms.Padding(0);
            this.panelAdd.MaximumSize = new System.Drawing.Size(800, 2000);
            this.panelAdd.Name = "panelAdd";
            this.panelAdd.Size = new System.Drawing.Size(620, 564);
            this.panelAdd.TabIndex = 0;
            // 
            // pnlSpecs
            // 
            this.pnlSpecs.AutoSize = true;
            this.pnlSpecs.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlSpecs.Controls.Add(this.pnlUpdateBtn);
            this.pnlSpecs.Controls.Add(this.pnlAddEmergencyBtn);
            this.pnlSpecs.Controls.Add(this.panel3);
            this.pnlSpecs.Controls.Add(this.panel2);
            this.pnlSpecs.Controls.Add(this.lbpnlSpecs);
            this.pnlSpecs.Location = new System.Drawing.Point(0, 0);
            this.pnlSpecs.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.pnlSpecs.MaximumSize = new System.Drawing.Size(300, 0);
            this.pnlSpecs.MinimumSize = new System.Drawing.Size(290, 0);
            this.pnlSpecs.Name = "pnlSpecs";
            this.pnlSpecs.Padding = new System.Windows.Forms.Padding(5);
            this.pnlSpecs.Size = new System.Drawing.Size(290, 179);
            this.pnlSpecs.TabIndex = 1;
            // 
            // pnlUpdateBtn
            // 
            this.pnlUpdateBtn.AutoSize = true;
            this.pnlUpdateBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlUpdateBtn.Controls.Add(this.btnUpdate);
            this.pnlUpdateBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUpdateBtn.Location = new System.Drawing.Point(5, 135);
            this.pnlUpdateBtn.Margin = new System.Windows.Forms.Padding(0);
            this.pnlUpdateBtn.Name = "pnlUpdateBtn";
            this.pnlUpdateBtn.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.pnlUpdateBtn.Size = new System.Drawing.Size(280, 39);
            this.pnlUpdateBtn.TabIndex = 30;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(4, 8);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(271, 23);
            this.btnUpdate.TabIndex = 30;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // pnlAddEmergencyBtn
            // 
            this.pnlAddEmergencyBtn.AutoSize = true;
            this.pnlAddEmergencyBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlAddEmergencyBtn.Controls.Add(this.btnAddEmer);
            this.pnlAddEmergencyBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlAddEmergencyBtn.Location = new System.Drawing.Point(5, 96);
            this.pnlAddEmergencyBtn.Margin = new System.Windows.Forms.Padding(0);
            this.pnlAddEmergencyBtn.Name = "pnlAddEmergencyBtn";
            this.pnlAddEmergencyBtn.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.pnlAddEmergencyBtn.Size = new System.Drawing.Size(280, 39);
            this.pnlAddEmergencyBtn.TabIndex = 4;
            // 
            // btnAddEmer
            // 
            this.btnAddEmer.Location = new System.Drawing.Point(4, 8);
            this.btnAddEmer.Name = "btnAddEmer";
            this.btnAddEmer.Size = new System.Drawing.Size(271, 23);
            this.btnAddEmer.TabIndex = 30;
            this.btnAddEmer.Text = "Add Emergency";
            this.btnAddEmer.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.AutoSize = true;
            this.panel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel3.Controls.Add(this.cboEmergencyType);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(5, 61);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.MaximumSize = new System.Drawing.Size(280, 0);
            this.panel3.MinimumSize = new System.Drawing.Size(280, 25);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(0, 0, 5, 10);
            this.panel3.Size = new System.Drawing.Size(280, 35);
            this.panel3.TabIndex = 31;
            // 
            // cboEmergencyType
            // 
            this.cboEmergencyType.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cboEmergencyType.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboEmergencyType.FormattingEnabled = true;
            this.cboEmergencyType.Items.AddRange(new object[] {
            "1: Minor incident",
            "2: Stable case",
            "3: Serious case",
            "4: Critical trauma"});
            this.cboEmergencyType.Location = new System.Drawing.Point(100, 0);
            this.cboEmergencyType.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.cboEmergencyType.MaximumSize = new System.Drawing.Size(175, 0);
            this.cboEmergencyType.MinimumSize = new System.Drawing.Size(175, 0);
            this.cboEmergencyType.Name = "cboEmergencyType";
            this.cboEmergencyType.Size = new System.Drawing.Size(175, 25);
            this.cboEmergencyType.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.MaximumSize = new System.Drawing.Size(100, 23);
            this.label1.MinimumSize = new System.Drawing.Size(100, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Type";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.Controls.Add(this.txtEmergencyID);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(5, 36);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.MaximumSize = new System.Drawing.Size(280, 0);
            this.panel2.MinimumSize = new System.Drawing.Size(280, 25);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(0, 0, 5, 10);
            this.panel2.Size = new System.Drawing.Size(280, 25);
            this.panel2.TabIndex = 4;
            // 
            // txtEmergencyID
            // 
            this.txtEmergencyID.BackColor = System.Drawing.Color.White;
            this.txtEmergencyID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmergencyID.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtEmergencyID.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmergencyID.Location = new System.Drawing.Point(100, 0);
            this.txtEmergencyID.Margin = new System.Windows.Forms.Padding(0);
            this.txtEmergencyID.MaximumSize = new System.Drawing.Size(175, 22);
            this.txtEmergencyID.MinimumSize = new System.Drawing.Size(175, 22);
            this.txtEmergencyID.Name = "txtEmergencyID";
            this.txtEmergencyID.ReadOnly = true;
            this.txtEmergencyID.Size = new System.Drawing.Size(175, 15);
            this.txtEmergencyID.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Left;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.MaximumSize = new System.Drawing.Size(100, 23);
            this.label3.MinimumSize = new System.Drawing.Size(100, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "ID";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbpnlSpecs
            // 
            this.lbpnlSpecs.AutoSize = true;
            this.lbpnlSpecs.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbpnlSpecs.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbpnlSpecs.ForeColor = System.Drawing.Color.DimGray;
            this.lbpnlSpecs.Location = new System.Drawing.Point(5, 5);
            this.lbpnlSpecs.Margin = new System.Windows.Forms.Padding(0);
            this.lbpnlSpecs.Name = "lbpnlSpecs";
            this.lbpnlSpecs.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.lbpnlSpecs.Size = new System.Drawing.Size(92, 31);
            this.lbpnlSpecs.TabIndex = 29;
            this.lbpnlSpecs.Text = "specifications";
            // 
            // pnlRelatedData
            // 
            this.pnlRelatedData.AutoSize = true;
            this.pnlRelatedData.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlRelatedData.Controls.Add(this.callControlView);
            this.pnlRelatedData.Controls.Add(this.lbpnlRelatedCalls);
            this.pnlRelatedData.Location = new System.Drawing.Point(300, 0);
            this.pnlRelatedData.Margin = new System.Windows.Forms.Padding(0);
            this.pnlRelatedData.MaximumSize = new System.Drawing.Size(320, 0);
            this.pnlRelatedData.MinimumSize = new System.Drawing.Size(320, 0);
            this.pnlRelatedData.Name = "pnlRelatedData";
            this.pnlRelatedData.Padding = new System.Windows.Forms.Padding(5);
            this.pnlRelatedData.Size = new System.Drawing.Size(320, 564);
            this.pnlRelatedData.TabIndex = 2;
            // 
            // callControlView
            // 
            this.callControlView.AutoSize = true;
            this.callControlView.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.callControlView.AvailableSegments = "f/f/t";
            this.callControlView.BackColor = System.Drawing.SystemColors.Window;
            this.callControlView.Dock = System.Windows.Forms.DockStyle.Top;
            this.callControlView.Location = new System.Drawing.Point(5, 36);
            this.callControlView.Margin = new System.Windows.Forms.Padding(0);
            this.callControlView.MinimumSize = new System.Drawing.Size(310, 0);
            this.callControlView.Name = "callControlView";
            this.callControlView.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.callControlView.Size = new System.Drawing.Size(310, 523);
            this.callControlView.TabIndex = 31;
            // 
            // lbpnlRelatedCalls
            // 
            this.lbpnlRelatedCalls.AutoSize = true;
            this.lbpnlRelatedCalls.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbpnlRelatedCalls.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbpnlRelatedCalls.ForeColor = System.Drawing.Color.DimGray;
            this.lbpnlRelatedCalls.Location = new System.Drawing.Point(5, 5);
            this.lbpnlRelatedCalls.Margin = new System.Windows.Forms.Padding(0);
            this.lbpnlRelatedCalls.Name = "lbpnlRelatedCalls";
            this.lbpnlRelatedCalls.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.lbpnlRelatedCalls.Size = new System.Drawing.Size(82, 31);
            this.lbpnlRelatedCalls.TabIndex = 29;
            this.lbpnlRelatedCalls.Text = "related calls";
            // 
            // panelList
            // 
            this.panelList.AutoSize = true;
            this.panelList.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelList.Controls.Add(this.lstEmergencies);
            this.panelList.Controls.Add(this.lbpnlEmergencyList);
            this.panelList.Location = new System.Drawing.Point(620, 0);
            this.panelList.Margin = new System.Windows.Forms.Padding(0);
            this.panelList.MinimumSize = new System.Drawing.Size(390, 0);
            this.panelList.Name = "panelList";
            this.panelList.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.panelList.Size = new System.Drawing.Size(390, 136);
            this.panelList.TabIndex = 3;
            this.panelList.SizeChanged += new System.EventHandler(this.pnlList_SizeChanged);
            // 
            // lstEmergencies
            // 
            this.lstEmergencies.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Type,
            this.TeamsRequired,
            this.Priority,
            this.State,
            this.Description});
            this.lstEmergencies.Dock = System.Windows.Forms.DockStyle.Top;
            this.lstEmergencies.Font = new System.Drawing.Font("Franklin Gothic Book", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstEmergencies.FullRowSelect = true;
            this.lstEmergencies.GridLines = true;
            this.lstEmergencies.Location = new System.Drawing.Point(0, 31);
            this.lstEmergencies.Margin = new System.Windows.Forms.Padding(0);
            this.lstEmergencies.MinimumSize = new System.Drawing.Size(300, 100);
            this.lstEmergencies.MultiSelect = false;
            this.lstEmergencies.Name = "lstEmergencies";
            this.lstEmergencies.ShowItemToolTips = true;
            this.lstEmergencies.Size = new System.Drawing.Size(390, 100);
            this.lstEmergencies.TabIndex = 12;
            this.lstEmergencies.UseCompatibleStateImageBehavior = false;
            this.lstEmergencies.View = System.Windows.Forms.View.Details;
            // 
            // ID
            // 
            this.ID.Text = "Emergency ID";
            this.ID.Width = 80;
            // 
            // Type
            // 
            this.Type.Text = "Type";
            this.Type.Width = 80;
            // 
            // TeamsRequired
            // 
            this.TeamsRequired.Text = "Teams Req.";
            // 
            // Priority
            // 
            this.Priority.Text = "Priority";
            this.Priority.Width = 80;
            // 
            // State
            // 
            this.State.Text = "State";
            this.State.Width = 80;
            // 
            // Description
            // 
            this.Description.Text = "Description";
            this.Description.Width = 100;
            // 
            // lbpnlEmergencyList
            // 
            this.lbpnlEmergencyList.AutoSize = true;
            this.lbpnlEmergencyList.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbpnlEmergencyList.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbpnlEmergencyList.ForeColor = System.Drawing.Color.DimGray;
            this.lbpnlEmergencyList.Location = new System.Drawing.Point(0, 0);
            this.lbpnlEmergencyList.Margin = new System.Windows.Forms.Padding(0);
            this.lbpnlEmergencyList.Name = "lbpnlEmergencyList";
            this.lbpnlEmergencyList.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.lbpnlEmergencyList.Size = new System.Drawing.Size(28, 31);
            this.lbpnlEmergencyList.TabIndex = 30;
            this.lbpnlEmergencyList.Text = "list";
            // 
            // pnlParameters
            // 
            this.pnlParameters.Controls.Add(this.pnlList_Params);
            this.pnlParameters.Controls.Add(this.label9);
            this.pnlParameters.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlParameters.Location = new System.Drawing.Point(0, 43);
            this.pnlParameters.Name = "pnlParameters";
            this.pnlParameters.Padding = new System.Windows.Forms.Padding(10, 5, 0, 10);
            this.pnlParameters.Size = new System.Drawing.Size(1010, 33);
            this.pnlParameters.TabIndex = 14;
            // 
            // pnlList_Params
            // 
            this.pnlList_Params.AutoSize = true;
            this.pnlList_Params.Controls.Add(this.cmbState);
            this.pnlList_Params.Controls.Add(this.label2);
            this.pnlList_Params.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlList_Params.Location = new System.Drawing.Point(87, 5);
            this.pnlList_Params.Margin = new System.Windows.Forms.Padding(0);
            this.pnlList_Params.MinimumSize = new System.Drawing.Size(200, 23);
            this.pnlList_Params.Name = "pnlList_Params";
            this.pnlList_Params.Size = new System.Drawing.Size(200, 23);
            this.pnlList_Params.TabIndex = 16;
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
            this.cmbState.SelectedIndexChanged += new System.EventHandler(this.cmbState_SelectedIndexChanged);
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
            this.label2.Size = new System.Drawing.Size(68, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "with state";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Left;
            this.label9.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Gray;
            this.label9.Location = new System.Drawing.Point(10, 5);
            this.label9.Margin = new System.Windows.Forms.Padding(0);
            this.label9.Name = "label9";
            this.label9.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.label9.Size = new System.Drawing.Size(77, 17);
            this.label9.TabIndex = 13;
            this.label9.Text = "parameters:";
            // 
            // Emergency_Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.panelSegments);
            this.Controls.Add(this.pnlParameters);
            this.Controls.Add(this.panel1);
            this.Name = "Emergency_Control";
            this.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.Size = new System.Drawing.Size(1010, 640);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelSegments.ResumeLayout(false);
            this.panelSegments.PerformLayout();
            this.panelAdd.ResumeLayout(false);
            this.panelAdd.PerformLayout();
            this.pnlSpecs.ResumeLayout(false);
            this.pnlSpecs.PerformLayout();
            this.pnlUpdateBtn.ResumeLayout(false);
            this.pnlAddEmergencyBtn.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnlRelatedData.ResumeLayout(false);
            this.pnlRelatedData.PerformLayout();
            this.panelList.ResumeLayout(false);
            this.panelList.PerformLayout();
            this.pnlParameters.ResumeLayout(false);
            this.pnlParameters.PerformLayout();
            this.pnlList_Params.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.FlowLayoutPanel panelSegments;
        private Rescue_911.Segmented_Control segmentMain;
        private System.Windows.Forms.FlowLayoutPanel panelAdd;
        private System.Windows.Forms.Panel pnlSpecs;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox cboEmergencyType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtEmergencyID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbpnlSpecs;
        private System.Windows.Forms.Panel pnlRelatedData;
        private System.Windows.Forms.Panel pnlUpdateBtn;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Panel pnlAddEmergencyBtn;
        private System.Windows.Forms.Button btnAddEmer;
        private System.Windows.Forms.Label lbpnlRelatedCalls;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel pnlParameters;
        private Call_Control callControlView;
        private System.Windows.Forms.Panel pnlList_Params;
        private System.Windows.Forms.ComboBox cmbState;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelList;
        private System.Windows.Forms.ListView lstEmergencies;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Type;
        private System.Windows.Forms.ColumnHeader TeamsRequired;
        private System.Windows.Forms.ColumnHeader Priority;
        private System.Windows.Forms.ColumnHeader State;
        private System.Windows.Forms.ColumnHeader Description;
        private System.Windows.Forms.Label lbpnlEmergencyList;
    }
}
