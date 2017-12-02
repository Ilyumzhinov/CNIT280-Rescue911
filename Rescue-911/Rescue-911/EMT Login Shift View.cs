using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rescue_911
{
    public partial class EMT_Login_Shift_View : Special_View
    {
        private EMT[] emts;

        // CONSTRUCTORS
        //To-setup the view.
        public EMT_Login_Shift_View(bool toDisplay, ref Special_List<EMT> xEmts) : this(toDisplay)
        {
            
            timer1.Enabled = true;
            timer1.Interval = 1000;

            emts = xEmts.ToArray();


            if (emts[1].getstatus() == "STARTED")
            {
                LBshifttime.Text = emts[1].getshifttime();
                LBtotalworkedhours.Text = emts[1].getTotalShiftTime().ToString().Substring(0, 8);
                lbrt.Text = emts[1].GetResponseTeam().GetID().ToString();
                labemtid.Text = emts[1].GetEmployee_ID().ToString();
                lblogtime.Text = emts[1].getstatus();
            } else if (DateTime.Now.Hour.ToString() == "21")
            {
                LBshifttime.Text = emts[1].getshifttime();
                LBtotalworkedhours.Text = emts[1].getTotalShiftTime().ToString().Substring(0, 8);
                lbrt.Text = emts[1].GetResponseTeam().GetID().ToString();
                labemtid.Text = emts[1].GetEmployee_ID().ToString();
                lblogtime.Text = "READY";
                btnWaitingCall.Enabled = false;
            }
            else {
                LBshifttime.Text = emts[1].getshifttime();
                LBtotalworkedhours.Text = emts[1].getTotalShiftTime().ToString().Substring(0, 8);
                lbrt.Text = emts[1].GetResponseTeam().GetID().ToString();
                labemtid.Text = emts[1].GetEmployee_ID().ToString();
                lblogtime.Text = " NOT READY";
                btnWaitingCall.Enabled = false;
            } 
            
        }

        //To-display the view.
        public EMT_Login_Shift_View(bool toDisplay) : base(toDisplay, "EMT Shift Login", Color.DarkGray)
        {
            if (toDisplay)
                InitializeComponent();
        }
        //

    


      

        private void button1_Click(object sender, EventArgs e)
        {
            emts[1].setShiftLoginTime(DateTime.Now);
            lblogtime.Text = "STARTED";
            emts[1].setstatus("STARTED");
            btnWaitingCall.Enabled = true;
        }

        private void btnWaitingCall_Click(object sender, EventArgs e)
        {
            DateTime TEMP = DateTime.Now;

            TimeSpan temp2 = TEMP.Subtract(emts[1].getshiftlogintime());

            emts[1].updatetotaolshifttime(temp2);
            btnWaitingCall.Enabled = false;
            LBtotalworkedhours.Text = emts[1].getTotalShiftTime().ToString().Substring(0, 8);
            lblogtime.Text = "End";
            emts[1].setstatus("End");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LBcurrenttime.Text = DateTime.Now.ToLongTimeString();
        }
    }
}