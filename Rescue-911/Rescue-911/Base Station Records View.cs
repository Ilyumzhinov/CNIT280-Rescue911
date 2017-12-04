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
        Special_List<Base_Station_Records> BSR;


        // CONSTRUCTORS
        //To-setup the view.
        public Base_Station_Records_View(bool toDisplay, ref Special_List<Base_Station_Records> xBSR) : this(toDisplay)
        {
            BSR = xBSR;

            BSR.ItemAdded -= new EventHandler(lstHistory_AddRecord);
            BSR.ItemAdded += new EventHandler(lstHistory_AddRecord);

            foreach (Base_Station_Records iBSR in BSR)
            {
                lstHistory.Items.Add(iBSR);
            }
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
            if (lstHistory.SelectedIndex != -1)
            {
                dateTimePicker1.Value = DateTime.Now;
                txtRecords.Text = string.Empty;

                dateTimePicker1.Enabled = true;
                txtRecords.Enabled = true;

                lstHistory.SelectedIndex = -1;
            }



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
                dateTimePicker1.Enabled = false;
                txtRecords.Enabled = false;

                Base_Station_Records BaseStationRecord = new Base_Station_Records();

                BaseStationRecord.SetRecord(txtRecords.Text);
                BaseStationRecord.SetDate(dateTimePicker1.Value);

                BSR.AddItem(BaseStationRecord);

                lstHistory.SelectedIndex = lstHistory.Items.IndexOf(BaseStationRecord);

                SendStatusUpdate(true, "Record Saved!", "success");
            }
        }

        private void lstHistory_AddRecord(object sender, EventArgs e)
        {
            lstHistory.Items.Add((Base_Station_Records)sender);
        }

        private void lstHistory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstHistory.SelectedIndex == -1)
                return;

            dateTimePicker1.Value = ((Base_Station_Records)lstHistory.SelectedItem).GetDate();
            txtRecords.Text = ((Base_Station_Records)lstHistory.SelectedItem).GetRecord();
            dateTimePicker1.Enabled = false;
            txtRecords.Enabled = false;
        }
    }
}
