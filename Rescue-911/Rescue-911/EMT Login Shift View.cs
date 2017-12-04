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
    public partial class EMT_Login_Shift_View : Special_View,IUserDependent
    {
        private EMT[] emts;
        private EMT CurrentEMT;
        
       
        // CONSTRUCTORS
        //To-setup the view.
        public EMT_Login_Shift_View(bool toDisplay, ref Special_List<EMT> xEmts,Employee xEmployee) : this(toDisplay)
        {
            if (xEmployee is EMT)
            {
                CurrentEMT = (EMT)xEmployee;
            }
            else return;
            timer1.Enabled = true;
            timer1.Interval = 1000;
            emts = xEmts.ToArray();
           
            if (CurrentEMT.getstatus() == "STARTED")
            {
                LBshifttime.Text = CurrentEMT.getshifttime();
                LBtotalworkedhours.Text = CurrentEMT.getTotalShiftTime().ToString().Substring(0, 8);
                lbrt.Text = CurrentEMT.GetResponseTeam().GetID().ToString();
                labemtid.Text = CurrentEMT.GetEmployee_ID().ToString();
                lblogtime.Text = CurrentEMT.getstatus();
                button1.Enabled = false;
                btnWaitingCall.Enabled = true;
            } else if (DateTime.Now.Hour.ToString() ==  CurrentEMT.getshifttime().Substring(0,2)){
                LBshifttime.Text = CurrentEMT.getshifttime();
                LBtotalworkedhours.Text = CurrentEMT.getTotalShiftTime().ToString().Substring(0, 8);
                lbrt.Text = CurrentEMT.GetResponseTeam().GetID().ToString();
                labemtid.Text = CurrentEMT.GetEmployee_ID().ToString();
                lblogtime.Text = "READY";
                button1.Enabled = true;
                btnWaitingCall.Enabled = false;
            }
            else if(DateTime.Now.Hour.ToString() != CurrentEMT.getshifttime().Substring(0, 2)) {
                LBshifttime.Text = CurrentEMT.getshifttime();
                LBtotalworkedhours.Text = CurrentEMT.getTotalShiftTime().ToString().Substring(0, 8);
                lbrt.Text = CurrentEMT.GetResponseTeam().GetID().ToString();
                labemtid.Text = CurrentEMT.GetEmployee_ID().ToString();
                lblogtime.Text = "NOT READY";
                btnWaitingCall.Enabled = false;
                button1.Enabled = false;
            } 
            
        }

        //To-display the view.
        public EMT_Login_Shift_View(bool toDisplay) : base(toDisplay, "EMT Shift Login", Color.DarkGray)
        {
            if (toDisplay)
                InitializeComponent();
        }
        //

        public void SendUser(Person xUser)
        {
            if (xUser is EMT == false)
            {
                btnWaitingCall.Enabled = false;
                button1.Enabled = false;
                SendStatusUpdate(true, "To access, you must have EMT access level!", "urgent");
            }
            return;
        }




        private void button1_Click(object sender, EventArgs e)
        {
            CurrentEMT.setShiftLoginTime(DateTime.Now);
            CurrentEMT.GetResponseTeam().SetStatusByEmt(true, CurrentEMT.GetTeamNumber());
            lblogtime.Text = "STARTED";
            CurrentEMT.setstatus("STARTED");
            
            button1.Enabled = false;
            btnWaitingCall.Enabled = true;
        }

        private void btnWaitingCall_Click(object sender, EventArgs e)
        {
            DateTime TEMP = DateTime.Now;

            TimeSpan temp2 = TEMP.Subtract(CurrentEMT.getshiftlogintime());

            CurrentEMT.updatetotaolshifttime(temp2);
            btnWaitingCall.Enabled = false;
            LBtotalworkedhours.Text = CurrentEMT.getTotalShiftTime().ToString().Substring(0, 8);
            lblogtime.Text = "End";
            CurrentEMT.setstatus("End");
            CurrentEMT.GetResponseTeam().SetStatusByEmt(false, CurrentEMT.GetTeamNumber());
            button1.Enabled = true;
            btnWaitingCall.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LBcurrenttime.Text = DateTime.Now.ToLongTimeString();
        }
       
    }
}