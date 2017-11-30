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
    public partial class Statusbar : UserControl
    {
        public Statusbar()
        {
            InitializeComponent();
        }

        // GETs & SETs
        public void SetStatus(string senderName, string xStatus, string xType = "")
        {
            string message = "";

            switch (xType)
            {
                case "urgent": // Message has negative/urgent meaning.
                    this.BackColor = Color.OrangeRed;
                    message = "! ";
                    break;
                case "success": // Message has positive meaning.
                    this.BackColor = Color.MediumSeaGreen;
                    break;
                default: // Message is either normal/minor.
                    this.BackColor = Color.SlateGray;
                    break;
            }

            message = senderName + ": " + xStatus;
            Status.Text = message;
        }

        public string GetStatusText() { return Status.Text; }
        //
    }
}