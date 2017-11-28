﻿using System;
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
        //To-display the view.
        public EMT_Login_Shift_View(ref Shared_Data xSD) : base(ref xSD, "EMT Shift Login", false, Color.DarkGray)
        {
            InitializeComponent();
            //timer1.Enabled = true;
            //timer1.Interval = 1000;

            emts = xSD.GetEMTs().ToArray();

        }

        //To-display the view.
        public EMT_Login_Shift_View() : base("EMT Shift Login", false, Color.DarkGray)
        { }
        //

        private void EMT_login_shift_Load(object sender, EventArgs e)
        {
            if (emts[1].getstatus() == "STARTED")
            {

                LBshifttime.Text = emts[1].getshifttime();
                LBtotalworkedhours.Text = emts[1].getTotalShiftTime().ToString().Substring(0, 8);
                label6.Text = emts[1].GetResponseTeam().GetID().ToString();
                labemtid.Text = emts[1].GetEmployee_ID().ToString();
                if (emts[1].getstatus() == "STARTED")
                {
                    label8.Text = emts[1].getstatus();
                }
                else if (DateTime.Now.Hour.ToString() == "21")
                {
                    label8.Text = "READY";
                }
                else label8.Text = " NOT READY";
            }
            else
                btnWaitingCall.Enabled = false;

        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            LBcurrenttime.Text = DateTime.Now.ToLongTimeString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            emts[1].setShiftLoginTime(DateTime.Now);
            label8.Text = "STARTED";
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
            label8.Text = "End";
            emts[1].setstatus("End");
        }
    }
}