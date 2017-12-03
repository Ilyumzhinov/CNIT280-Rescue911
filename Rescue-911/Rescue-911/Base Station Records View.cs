using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Rescue_911
{
    public partial class Base_Station_Records_View : Special_View
    {

        //private int mIndex = 0;
        //private const int cSize = 50;

        //private string[] mDate = new string[cSize];
        //private string[] mRecord = new string[cSize];

        List<Base_Station_Records> BSR;


        // CONSTRUCTORS
        //To-setup the view.
        public Base_Station_Records_View(bool toDisplay, ref Special_List<Base_Station_Records> xBSR) : this(toDisplay)
        {
            BSR = xBSR;
        }

        //To-display the view.
        public Base_Station_Records_View(bool toDisplay) : base(toDisplay, "Base Station Records", Color.SteelBlue)
        {
            if (toDisplay)
                InitializeComponent();
        }
        //


        private void btnRecord_Click(object sender, EventArgs e)
        {
            
            if (txtRecords.Text == "")
            {
                MessageBox.Show("Enter records.", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtRecords.Focus();
                return;
            }

            if (dateTimePicker1.Text == "")
            {
                MessageBox.Show("Enter a Date.", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            else //All checks are satisfied
            {
                txtRecords.Enabled = false;
                btnRecord.Visible = false;
                dateTimePicker1.Enabled = false;

                Base_Station_Records BaseStationRecords = new Base_Station_Records();

                BaseStationRecords.SetRecord(txtRecords.Text);

                BSR.Add(BaseStationRecords);
            }

            SendStatusUpdate(true, "Record Saved!", "success");
            //date = dateTimePicker1.Text;
            //record = txtRecords.Text;
            //mDate[mIndex] = date;
            //mRecord[mIndex] = record;
            //MessageBox.Show("Record Saved.", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            //dateTimePicker1.Text = "";
            //txtRecords.Text = "";
            //mIndex++;
        }


    }
}
