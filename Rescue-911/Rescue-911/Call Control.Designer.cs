namespace Rescue_911
{
    partial class Call_Control
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
            this.segmented_Control1 = new Team_Project.Segmented_Control();
            this.lbTitle = new System.Windows.Forms.Label();
            this.panelSegments = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlOtherData = new System.Windows.Forms.Panel();
            this.lbpnlOtherData = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.txtLandmark = new System.Windows.Forms.TextBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.pnlEmergencyBtns = new System.Windows.Forms.Panel();
            this.btnLinkEmergency = new System.Windows.Forms.Button();
            this.btnAddEmer = new System.Windows.Forms.Button();
            this.pnlUpdateBtn = new System.Windows.Forms.Panel();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.pnlCaller = new System.Windows.Forms.Panel();
            this.lbpnlCaller = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCallerName = new System.Windows.Forms.TextBox();
            this.pnlCallInfo = new System.Windows.Forms.Panel();
            this.lbpnlCallInfo = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCallDateTime = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cboCallPriority = new System.Windows.Forms.ComboBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.numTeams = new System.Windows.Forms.NumericUpDown();
            this.panelAdd = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.panelSegments.SuspendLayout();
            this.pnlOtherData.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            this.pnlEmergencyBtns.SuspendLayout();
            this.pnlUpdateBtn.SuspendLayout();
            this.pnlCaller.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.pnlCallInfo.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTeams)).BeginInit();
            this.panelAdd.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.segmented_Control1);
            this.panel1.Controls.Add(this.lbTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 10);
            this.panel1.MinimumSize = new System.Drawing.Size(0, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 23);
            this.panel1.TabIndex = 16;
            // 
            // segmented_Control1
            // 
            this.segmented_Control1.AutoSize = true;
            this.segmented_Control1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.segmented_Control1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.segmented_Control1.Dock = System.Windows.Forms.DockStyle.Left;
            this.segmented_Control1.Location = new System.Drawing.Point(52, 0);
            this.segmented_Control1.Margin = new System.Windows.Forms.Padding(0);
            this.segmented_Control1.MaximumSize = new System.Drawing.Size(400, 23);
            this.segmented_Control1.MinimumSize = new System.Drawing.Size(200, 23);
            this.segmented_Control1.Name = "segmented_Control1";
            this.segmented_Control1.Segments = "Add/Edit/View";
            this.segmented_Control1.Size = new System.Drawing.Size(202, 23);
            this.segmented_Control1.TabIndex = 13;
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
            this.lbTitle.Size = new System.Drawing.Size(52, 24);
            this.lbTitle.TabIndex = 12;
            this.lbTitle.Text = "Call";
            // 
            // panelSegments
            // 
            this.panelSegments.AutoScroll = true;
            this.panelSegments.AutoSize = true;
            this.panelSegments.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelSegments.BackColor = System.Drawing.Color.Transparent;
            this.panelSegments.Controls.Add(this.panelAdd);
            this.panelSegments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSegments.Location = new System.Drawing.Point(0, 33);
            this.panelSegments.Margin = new System.Windows.Forms.Padding(3, 15, 3, 3);
            this.panelSegments.MaximumSize = new System.Drawing.Size(0, 2000);
            this.panelSegments.Name = "panelSegments";
            this.panelSegments.Size = new System.Drawing.Size(600, 460);
            this.panelSegments.TabIndex = 17;
            // 
            // pnlOtherData
            // 
            this.pnlOtherData.AutoSize = true;
            this.pnlOtherData.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlOtherData.Controls.Add(this.pnlUpdateBtn);
            this.pnlOtherData.Controls.Add(this.pnlEmergencyBtns);
            this.pnlOtherData.Controls.Add(this.panel9);
            this.pnlOtherData.Controls.Add(this.panel8);
            this.pnlOtherData.Controls.Add(this.panel7);
            this.pnlOtherData.Controls.Add(this.lbpnlOtherData);
            this.pnlOtherData.Location = new System.Drawing.Point(10, 262);
            this.pnlOtherData.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.pnlOtherData.MinimumSize = new System.Drawing.Size(290, 0);
            this.pnlOtherData.Name = "pnlOtherData";
            this.pnlOtherData.Padding = new System.Windows.Forms.Padding(5);
            this.pnlOtherData.Size = new System.Drawing.Size(290, 293);
            this.pnlOtherData.TabIndex = 3;
            // 
            // lbpnlOtherData
            // 
            this.lbpnlOtherData.AutoSize = true;
            this.lbpnlOtherData.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbpnlOtherData.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbpnlOtherData.ForeColor = System.Drawing.Color.DimGray;
            this.lbpnlOtherData.Location = new System.Drawing.Point(5, 5);
            this.lbpnlOtherData.Margin = new System.Windows.Forms.Padding(0);
            this.lbpnlOtherData.Name = "lbpnlOtherData";
            this.lbpnlOtherData.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.lbpnlOtherData.Size = new System.Drawing.Size(68, 31);
            this.lbpnlOtherData.TabIndex = 29;
            this.lbpnlOtherData.Text = "other data";
            // 
            // panel7
            // 
            this.panel7.AutoSize = true;
            this.panel7.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel7.Controls.Add(this.txtAddress);
            this.panel7.Controls.Add(this.label6);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(5, 36);
            this.panel7.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.panel7.MaximumSize = new System.Drawing.Size(280, 0);
            this.panel7.MinimumSize = new System.Drawing.Size(280, 25);
            this.panel7.Name = "panel7";
            this.panel7.Padding = new System.Windows.Forms.Padding(0, 0, 5, 10);
            this.panel7.Size = new System.Drawing.Size(280, 32);
            this.panel7.TabIndex = 31;
            // 
            // label6
            // 
            this.label6.Dock = System.Windows.Forms.DockStyle.Left;
            this.label6.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Margin = new System.Windows.Forms.Padding(0);
            this.label6.MaximumSize = new System.Drawing.Size(100, 23);
            this.label6.MinimumSize = new System.Drawing.Size(100, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 22);
            this.label6.TabIndex = 3;
            this.label6.Text = "Address";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtAddress
            // 
            this.txtAddress.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtAddress.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(100, 0);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.txtAddress.MaximumSize = new System.Drawing.Size(175, 0);
            this.txtAddress.MinimumSize = new System.Drawing.Size(175, 0);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(175, 22);
            this.txtAddress.TabIndex = 3;
            this.txtAddress.Leave += new System.EventHandler(this.txtAddress_Leave);
            // 
            // panel8
            // 
            this.panel8.AutoSize = true;
            this.panel8.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel8.Controls.Add(this.txtLandmark);
            this.panel8.Controls.Add(this.label7);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(5, 68);
            this.panel8.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.panel8.MaximumSize = new System.Drawing.Size(280, 0);
            this.panel8.MinimumSize = new System.Drawing.Size(280, 25);
            this.panel8.Name = "panel8";
            this.panel8.Padding = new System.Windows.Forms.Padding(0, 0, 5, 10);
            this.panel8.Size = new System.Drawing.Size(280, 32);
            this.panel8.TabIndex = 32;
            // 
            // label7
            // 
            this.label7.Dock = System.Windows.Forms.DockStyle.Left;
            this.label7.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DimGray;
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Margin = new System.Windows.Forms.Padding(0);
            this.label7.MaximumSize = new System.Drawing.Size(100, 23);
            this.label7.MinimumSize = new System.Drawing.Size(100, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 22);
            this.label7.TabIndex = 3;
            this.label7.Text = "Landmark";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtLandmark
            // 
            this.txtLandmark.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtLandmark.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLandmark.Location = new System.Drawing.Point(100, 0);
            this.txtLandmark.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.txtLandmark.MaximumSize = new System.Drawing.Size(175, 0);
            this.txtLandmark.MinimumSize = new System.Drawing.Size(175, 0);
            this.txtLandmark.Name = "txtLandmark";
            this.txtLandmark.Size = new System.Drawing.Size(175, 22);
            this.txtLandmark.TabIndex = 3;
            // 
            // panel9
            // 
            this.panel9.AutoSize = true;
            this.panel9.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel9.Controls.Add(this.txtDescription);
            this.panel9.Controls.Add(this.label8);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel9.Location = new System.Drawing.Point(5, 100);
            this.panel9.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.panel9.MaximumSize = new System.Drawing.Size(280, 0);
            this.panel9.MinimumSize = new System.Drawing.Size(280, 25);
            this.panel9.Name = "panel9";
            this.panel9.Padding = new System.Windows.Forms.Padding(0, 0, 5, 10);
            this.panel9.Size = new System.Drawing.Size(280, 110);
            this.panel9.TabIndex = 33;
            // 
            // label8
            // 
            this.label8.Dock = System.Windows.Forms.DockStyle.Left;
            this.label8.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(0, 0);
            this.label8.Margin = new System.Windows.Forms.Padding(0);
            this.label8.MaximumSize = new System.Drawing.Size(100, 23);
            this.label8.MinimumSize = new System.Drawing.Size(100, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 23);
            this.label8.TabIndex = 3;
            this.label8.Text = "Description";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtDescription
            // 
            this.txtDescription.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtDescription.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(100, 0);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.txtDescription.MaximumSize = new System.Drawing.Size(175, 0);
            this.txtDescription.MinimumSize = new System.Drawing.Size(175, 100);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(175, 100);
            this.txtDescription.TabIndex = 3;
            this.txtDescription.TextChanged += new System.EventHandler(this.txtDescription_TextChanged);
            // 
            // pnlEmergencyBtns
            // 
            this.pnlEmergencyBtns.AutoSize = true;
            this.pnlEmergencyBtns.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlEmergencyBtns.Controls.Add(this.btnAddEmer);
            this.pnlEmergencyBtns.Controls.Add(this.btnLinkEmergency);
            this.pnlEmergencyBtns.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlEmergencyBtns.Location = new System.Drawing.Point(5, 210);
            this.pnlEmergencyBtns.Margin = new System.Windows.Forms.Padding(0);
            this.pnlEmergencyBtns.Name = "pnlEmergencyBtns";
            this.pnlEmergencyBtns.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.pnlEmergencyBtns.Size = new System.Drawing.Size(280, 39);
            this.pnlEmergencyBtns.TabIndex = 4;
            // 
            // btnLinkEmergency
            // 
            this.btnLinkEmergency.Location = new System.Drawing.Point(4, 8);
            this.btnLinkEmergency.Name = "btnLinkEmergency";
            this.btnLinkEmergency.Size = new System.Drawing.Size(120, 23);
            this.btnLinkEmergency.TabIndex = 29;
            this.btnLinkEmergency.Text = "Link to Emergency";
            this.btnLinkEmergency.UseVisualStyleBackColor = true;
            this.btnLinkEmergency.Click += new System.EventHandler(this.btnLinkEmergency_Click);
            // 
            // btnAddEmer
            // 
            this.btnAddEmer.Location = new System.Drawing.Point(155, 8);
            this.btnAddEmer.Name = "btnAddEmer";
            this.btnAddEmer.Size = new System.Drawing.Size(120, 23);
            this.btnAddEmer.TabIndex = 30;
            this.btnAddEmer.Text = "Add New Emergency";
            this.btnAddEmer.UseVisualStyleBackColor = true;
            this.btnAddEmer.Click += new System.EventHandler(this.btnAddEmer_Click);
            // 
            // pnlUpdateBtn
            // 
            this.pnlUpdateBtn.AutoSize = true;
            this.pnlUpdateBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlUpdateBtn.Controls.Add(this.btnUpdate);
            this.pnlUpdateBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUpdateBtn.Location = new System.Drawing.Point(5, 249);
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
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // pnlCaller
            // 
            this.pnlCaller.AutoSize = true;
            this.pnlCaller.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlCaller.Controls.Add(this.panel6);
            this.pnlCaller.Controls.Add(this.panel5);
            this.pnlCaller.Controls.Add(this.lbpnlCaller);
            this.pnlCaller.Location = new System.Drawing.Point(10, 152);
            this.pnlCaller.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.pnlCaller.MinimumSize = new System.Drawing.Size(290, 0);
            this.pnlCaller.Name = "pnlCaller";
            this.pnlCaller.Padding = new System.Windows.Forms.Padding(5);
            this.pnlCaller.Size = new System.Drawing.Size(290, 105);
            this.pnlCaller.TabIndex = 2;
            // 
            // lbpnlCaller
            // 
            this.lbpnlCaller.AutoSize = true;
            this.lbpnlCaller.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbpnlCaller.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbpnlCaller.ForeColor = System.Drawing.Color.DimGray;
            this.lbpnlCaller.Location = new System.Drawing.Point(5, 5);
            this.lbpnlCaller.Margin = new System.Windows.Forms.Padding(0);
            this.lbpnlCaller.Name = "lbpnlCaller";
            this.lbpnlCaller.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.lbpnlCaller.Size = new System.Drawing.Size(43, 31);
            this.lbpnlCaller.TabIndex = 28;
            this.lbpnlCaller.Text = "caller";
            // 
            // panel5
            // 
            this.panel5.AutoSize = true;
            this.panel5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel5.Controls.Add(this.txtPhoneNumber);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(5, 36);
            this.panel5.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.panel5.MaximumSize = new System.Drawing.Size(280, 0);
            this.panel5.MinimumSize = new System.Drawing.Size(280, 25);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(0, 0, 5, 10);
            this.panel5.Size = new System.Drawing.Size(280, 32);
            this.panel5.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Left;
            this.label4.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.MaximumSize = new System.Drawing.Size(100, 23);
            this.label4.MinimumSize = new System.Drawing.Size(100, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Phone Number";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtPhoneNumber.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhoneNumber.Location = new System.Drawing.Point(100, 0);
            this.txtPhoneNumber.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.txtPhoneNumber.MaximumSize = new System.Drawing.Size(175, 0);
            this.txtPhoneNumber.MinimumSize = new System.Drawing.Size(175, 0);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(175, 22);
            this.txtPhoneNumber.TabIndex = 3;
            this.txtPhoneNumber.Leave += new System.EventHandler(this.txtPhoneNumber_Leave);
            // 
            // panel6
            // 
            this.panel6.AutoSize = true;
            this.panel6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel6.Controls.Add(this.txtCallerName);
            this.panel6.Controls.Add(this.label5);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(5, 68);
            this.panel6.Margin = new System.Windows.Forms.Padding(0);
            this.panel6.MaximumSize = new System.Drawing.Size(280, 0);
            this.panel6.MinimumSize = new System.Drawing.Size(280, 25);
            this.panel6.Name = "panel6";
            this.panel6.Padding = new System.Windows.Forms.Padding(0, 0, 5, 10);
            this.panel6.Size = new System.Drawing.Size(280, 32);
            this.panel6.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Left;
            this.label5.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Margin = new System.Windows.Forms.Padding(0);
            this.label5.MaximumSize = new System.Drawing.Size(100, 23);
            this.label5.MinimumSize = new System.Drawing.Size(100, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 22);
            this.label5.TabIndex = 3;
            this.label5.Text = "Caller Name";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCallerName
            // 
            this.txtCallerName.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtCallerName.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCallerName.Location = new System.Drawing.Point(100, 0);
            this.txtCallerName.Margin = new System.Windows.Forms.Padding(0);
            this.txtCallerName.MaximumSize = new System.Drawing.Size(175, 0);
            this.txtCallerName.MinimumSize = new System.Drawing.Size(175, 0);
            this.txtCallerName.Name = "txtCallerName";
            this.txtCallerName.Size = new System.Drawing.Size(175, 22);
            this.txtCallerName.TabIndex = 3;
            this.txtCallerName.Leave += new System.EventHandler(this.txtCallerName_Leave);
            // 
            // pnlCallInfo
            // 
            this.pnlCallInfo.AutoSize = true;
            this.pnlCallInfo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlCallInfo.Controls.Add(this.panel4);
            this.pnlCallInfo.Controls.Add(this.panel3);
            this.pnlCallInfo.Controls.Add(this.panel2);
            this.pnlCallInfo.Controls.Add(this.lbpnlCallInfo);
            this.pnlCallInfo.Location = new System.Drawing.Point(10, 10);
            this.pnlCallInfo.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.pnlCallInfo.MaximumSize = new System.Drawing.Size(300, 0);
            this.pnlCallInfo.MinimumSize = new System.Drawing.Size(290, 0);
            this.pnlCallInfo.Name = "pnlCallInfo";
            this.pnlCallInfo.Padding = new System.Windows.Forms.Padding(5);
            this.pnlCallInfo.Size = new System.Drawing.Size(290, 137);
            this.pnlCallInfo.TabIndex = 1;
            // 
            // lbpnlCallInfo
            // 
            this.lbpnlCallInfo.AutoSize = true;
            this.lbpnlCallInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbpnlCallInfo.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbpnlCallInfo.ForeColor = System.Drawing.Color.DimGray;
            this.lbpnlCallInfo.Location = new System.Drawing.Point(5, 5);
            this.lbpnlCallInfo.Margin = new System.Windows.Forms.Padding(0);
            this.lbpnlCallInfo.Name = "lbpnlCallInfo";
            this.lbpnlCallInfo.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.lbpnlCallInfo.Size = new System.Drawing.Size(57, 31);
            this.lbpnlCallInfo.TabIndex = 29;
            this.lbpnlCallInfo.Text = "call info";
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.Controls.Add(this.txtCallDateTime);
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
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Left;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.MaximumSize = new System.Drawing.Size(100, 23);
            this.label3.MinimumSize = new System.Drawing.Size(100, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Date/Time";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCallDateTime
            // 
            this.txtCallDateTime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCallDateTime.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtCallDateTime.Enabled = false;
            this.txtCallDateTime.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCallDateTime.Location = new System.Drawing.Point(100, 0);
            this.txtCallDateTime.Margin = new System.Windows.Forms.Padding(0);
            this.txtCallDateTime.MaximumSize = new System.Drawing.Size(175, 0);
            this.txtCallDateTime.MinimumSize = new System.Drawing.Size(175, 0);
            this.txtCallDateTime.Name = "txtCallDateTime";
            this.txtCallDateTime.ReadOnly = true;
            this.txtCallDateTime.Size = new System.Drawing.Size(175, 15);
            this.txtCallDateTime.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.AutoSize = true;
            this.panel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel3.Controls.Add(this.cboCallPriority);
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
            this.label1.Text = "Priority";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cboCallPriority
            // 
            this.cboCallPriority.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cboCallPriority.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCallPriority.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCallPriority.FormattingEnabled = true;
            this.cboCallPriority.Items.AddRange(new object[] {
            "1: Minor incident",
            "2: Stable case",
            "3: Serious case",
            "4: Critical trauma"});
            this.cboCallPriority.Location = new System.Drawing.Point(100, 0);
            this.cboCallPriority.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.cboCallPriority.MaximumSize = new System.Drawing.Size(175, 0);
            this.cboCallPriority.MinimumSize = new System.Drawing.Size(175, 0);
            this.cboCallPriority.Name = "cboCallPriority";
            this.cboCallPriority.Size = new System.Drawing.Size(175, 25);
            this.cboCallPriority.TabIndex = 2;
            this.cboCallPriority.SelectedIndexChanged += new System.EventHandler(this.cboCallPriority_SelectedIndexChanged);
            // 
            // panel4
            // 
            this.panel4.AutoSize = true;
            this.panel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel4.Controls.Add(this.numTeams);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(5, 96);
            this.panel4.Margin = new System.Windows.Forms.Padding(0);
            this.panel4.MaximumSize = new System.Drawing.Size(280, 0);
            this.panel4.MinimumSize = new System.Drawing.Size(280, 25);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(0, 0, 5, 10);
            this.panel4.Size = new System.Drawing.Size(280, 36);
            this.panel4.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.MaximumSize = new System.Drawing.Size(100, 23);
            this.label2.MinimumSize = new System.Drawing.Size(80, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Teams Requried";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numTeams
            // 
            this.numTeams.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numTeams.Location = new System.Drawing.Point(100, 4);
            this.numTeams.Margin = new System.Windows.Forms.Padding(0);
            this.numTeams.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numTeams.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numTeams.Name = "numTeams";
            this.numTeams.Size = new System.Drawing.Size(175, 22);
            this.numTeams.TabIndex = 4;
            this.numTeams.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // panelAdd
            // 
            this.panelAdd.AutoSize = true;
            this.panelAdd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelAdd.BackColor = System.Drawing.Color.Transparent;
            this.panelAdd.Controls.Add(this.pnlCallInfo);
            this.panelAdd.Controls.Add(this.pnlCaller);
            this.panelAdd.Controls.Add(this.pnlOtherData);
            this.panelAdd.Location = new System.Drawing.Point(0, 0);
            this.panelAdd.Margin = new System.Windows.Forms.Padding(0);
            this.panelAdd.MaximumSize = new System.Drawing.Size(800, 2000);
            this.panelAdd.Name = "panelAdd";
            this.panelAdd.Padding = new System.Windows.Forms.Padding(10);
            this.panelAdd.Size = new System.Drawing.Size(310, 570);
            this.panelAdd.TabIndex = 0;
            // 
            // Call_Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.panelSegments);
            this.Controls.Add(this.panel1);
            this.Name = "Call_Control";
            this.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.Size = new System.Drawing.Size(600, 493);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelSegments.ResumeLayout(false);
            this.panelSegments.PerformLayout();
            this.pnlOtherData.ResumeLayout(false);
            this.pnlOtherData.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.pnlEmergencyBtns.ResumeLayout(false);
            this.pnlUpdateBtn.ResumeLayout(false);
            this.pnlCaller.ResumeLayout(false);
            this.pnlCaller.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.pnlCallInfo.ResumeLayout(false);
            this.pnlCallInfo.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numTeams)).EndInit();
            this.panelAdd.ResumeLayout(false);
            this.panelAdd.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.FlowLayoutPanel panelSegments;
        private Team_Project.Segmented_Control segmented_Control1;
        private System.Windows.Forms.FlowLayoutPanel panelAdd;
        private System.Windows.Forms.Panel pnlCallInfo;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.NumericUpDown numTeams;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox cboCallPriority;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtCallDateTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbpnlCallInfo;
        private System.Windows.Forms.Panel pnlCaller;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox txtCallerName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbpnlCaller;
        private System.Windows.Forms.Panel pnlOtherData;
        private System.Windows.Forms.Panel pnlUpdateBtn;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Panel pnlEmergencyBtns;
        private System.Windows.Forms.Button btnAddEmer;
        private System.Windows.Forms.Button btnLinkEmergency;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TextBox txtLandmark;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbpnlOtherData;
    }
}
