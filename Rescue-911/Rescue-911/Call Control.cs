using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rescue_911
{
    public partial class Call_Control : UserControl
    {
        private string availableSegments = "f/f/f";
        [Description("Set access to segments. Use 't' for granting the access to a view or 'f' to block it. Use / to separate elements"), Category("Data")]
        public string AvailableSegments
        {
            get
            {
                return availableSegments;
            }
            set
            {
                availableSegments = value;
                segmented_Control1.Visible = true;
                segmented_Control1.SetAvailableSegments(AvailableSegments);
                segmented_Control1.SegmentBtn_Click -= new EventHandler(Change_Segment);
                segmented_Control1.SegmentBtn_Click += new EventHandler(Change_Segment);
            }
        }

        public Call_Control()
        {
            InitializeComponent();

            // Change this
            Button btnTemp = new Button();
            btnTemp.Text = "Add";
            Change_Segment(btnTemp, null);
        }

        private void Change_Segment(object sender, EventArgs e)
        {
            if (((Button)sender).Text == "Add")
            {
                panelEdit.Visible = false;
                panelView.Visible = false;
                panelAdd.Visible = true;
            }
            else if (((Button)sender).Text == "Edit")
            {
                panelEdit.Visible = false;
                panelView.Visible = false;
                panelAdd.Visible = true;
            }
            else if (((Button)sender).Text == "View")
            {
                panelAdd.Visible = false;
                panelEdit.Visible = false;
                panelView.Visible = true;
            }
        }
    }
}
