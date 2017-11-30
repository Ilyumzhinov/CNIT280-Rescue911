using System;
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
        protected Shared_Data SD;
        private bool MiddleAligned;
        private Color Colour;
        private string dTitle;
        private string dDesc;

        //Relationships
        private Special_View Previous_View;

        //Event Handlers
        public event EventHandler StatusUpdate;
        //

        // CONSTRUCTORS
        //Reference: https://stackoverflow.com/questions/1216940/net-inherited-winforms-form-vs-designer-issue
        //To-display the view.
        public Special_View(ref Shared_Data xSD, string xTitle, bool xMiddleAligned, Color xColour, string xDesc = "") : this()
        {
            InitializeComponent();

            SD = xSD;
            MiddleAligned = xMiddleAligned;
            Colour = xColour;

            this.BackColor = Color.Transparent;

            SetTitle(xTitle);
            if (xDesc != "")
            {
                SetDesc(xDesc);
            }
        }

        //To-instantiate
        public Special_View(string xTitle, bool xMiddleAligned, Color xColour, string xDesc = "")
        {
            MiddleAligned = xMiddleAligned;
            Colour = xColour;

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
            object[] Sender = { xVisible, this.ToString(), xStatus, xType };

            StatusUpdate?.Invoke(Sender, null);
        }

        public override string ToString()
        {
            return this.Text + " View";
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
            lbDesc.Text = xDesc;
            lbDesc.Visible = true;
        }

        public bool GetMiddleAligned() { return MiddleAligned; }

        public Color GetColour() { return Colour; }

        public string GetTitle() { return dTitle; }

        public string GetDesc() { return dDesc; }

        public Special_View GetPrevious_View() { return Previous_View; }
        //

        private void btnBack_Click(object sender, EventArgs e)
        {
            ((Main_Form)this.Parent).View_Switch(Previous_View);

            this.Dispose();
        }
    }
}