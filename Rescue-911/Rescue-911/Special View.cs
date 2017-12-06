﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Rescue_911
{
    public partial class Special_View : UserControl
    {
        // DATA STRUCTURE
        //Primitives
        private bool MiddleAligned;
        private Color Colour;
        private string dTitle;
        private string dDesc;
        private object Status = false;

        //Relationships
        private Special_View Previous_View;
        private Button Assigned_Btn;

        //Event Handlers
        public event EventHandler StatusUpdate;
        //

        // CONSTRUCTORS
        //Reference: https://stackoverflow.com/questions/1216940/net-inherited-winforms-form-vs-designer-issue
        // NEW To-display the view.
        public Special_View(bool toDisplay, string xTitle, Color xColour, bool xMiddleAligned = false, string xDesc = "")
        {
            // if toDisplay is false, then do not draw the interface
            if (toDisplay == true)
                InitializeComponent();

            Colour = xColour;
            MiddleAligned = xMiddleAligned;

            this.BackColor = Color.Transparent;

            SetTitle(xTitle);
            if (xDesc != "")
            {
                SetDesc(xDesc);
            }
        }

        //For the designer
        private Special_View()
        {
            InitializeComponent();
        }
        //


        // FUNCTIONAL METHODS
        protected void SendStatusUpdate(bool xVisible, string xStatus = "", string xType = "")
        {
            Status = new object[] { xVisible, this.ToString(), xStatus, xType };

            StatusUpdate?.Invoke(Status, null);
        }

        public object GetStatus() { return Status; }

        public override string ToString()
        {
            return this.Text + " Page";
        }
        //


        // SET AND RECEIVE VALUES
        public void SetPrevious_View(Special_View xPrevious_View)
        {
            Previous_View = xPrevious_View;

            btnBack.Text = "< " + Previous_View.GetTitle().ToUpper();

            btnBack.Visible = true;
        }

        public void SetTitle(string xTitle)
        {
            dTitle = xTitle;

            if (lbTitle != null)
            {
                this.Text = xTitle;
                this.lbTitle.Text = xTitle;
                this.lbTitle.Visible = true;
            }
        }

        public void SetDesc(string xDesc)
        {
            dDesc = xDesc;

            if (lbDesc != null)
            {
                lbDesc.Text = xDesc;
                lbDesc.Visible = true;
            }
        }
        public void SetAssigned_Btn(ref Button xBtn) { Assigned_Btn = xBtn; }
        

        public bool GetMiddleAligned() { return MiddleAligned; }

        public Color GetColour() { return Colour; }

        public string GetTitle() { return dTitle; }

        public string GetDesc() { return dDesc; }

        public Special_View GetPrevious_View() { return Previous_View; }
        public Button GetAssigned_Btn() { return Assigned_Btn; }
        //

        private void btnBack_Click(object sender, EventArgs e)
        {
            ((Main_Form)this.Parent).View_Switch(Previous_View);

            this.Dispose();
        }
    }
}