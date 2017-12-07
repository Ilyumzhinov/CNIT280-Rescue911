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
        private bool MiddleAligned;
        private Color mColour = Color.MidnightBlue;
        private string mTitle = "Title";
        private string mDesc = "Description";
        private object Status = false;

        //Relationships
        private Special_View Previous_View;
        private Button Assigned_Btn;

        //Event Handlers
        public event EventHandler StatusUpdate;

        //Public Data
        [Description("Set the Title for the View which will be displayed across the program."), Category("Data")]
        public string ViewTitle
        {
            get
            {
                return mTitle;
            }
            set
            {
                mTitle = value;

                SetTitle(ViewTitle);
            }
        }
        [Description("Set the Description for the View which will be displayed across the program."), Category("Data")]
        public string ViewDescription
        {
            get
            {
                return mDesc;
            }
            set
            {
                mDesc = value;

                SetDesc(ViewDescription);
            }
        }
        [Description("Set the Colour for the View which will be displayed across the program."), Category("Data")]
        public Color ViewColour
        {
            get
            {
                return mColour;
            }
            set
            {
                mColour = value;
            }
        }
        //

        // CONSTRUCTORS
        //Reference: https://stackoverflow.com/questions/1216940/net-inherited-winforms-form-vs-designer-issue
        // NEW To-display the view.
        public Special_View(bool toDisplay, bool xMiddleAligned = false)
        {
            // if toDisplay is false, then do not draw the interface
            if (toDisplay == true)
                InitializeComponent();

            MiddleAligned = xMiddleAligned;

            this.BackColor = Color.Transparent;
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
            return ViewTitle + " View";
        }
        //


        // SET AND RECEIVE VALUES
        public void SetPrevious_View(Special_View xPrevious_View)
        {
            Previous_View = xPrevious_View;

            btnBack.ForeColor = Previous_View.GetColour();
            btnBack.Text = "< " + Previous_View.GetTitle().ToUpper();

            btnBack.Visible = true;
        }

        public void SetTitle(string xTitle)
        {
            if (lbTitle != null)
            {
                this.lbTitle.Text = xTitle;
                this.lbTitle.Visible = true;
            }
        }

        public void SetDesc(string xDesc)
        {
            if (lbDesc != null)
            {
                lbDesc.Text = xDesc;
                lbDesc.Visible = true;
            }
        }
        public void SetAssigned_Btn(ref Button xBtn) { Assigned_Btn = xBtn; }
        

        public bool GetMiddleAligned() { return MiddleAligned; }

        public Color GetColour() { return ViewColour; }

        public string GetTitle() { return ViewTitle; }

        public string GetDesc() { return ViewDescription; }

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