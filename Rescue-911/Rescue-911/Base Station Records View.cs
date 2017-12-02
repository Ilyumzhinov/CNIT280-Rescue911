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

        private int mIndex = 0;
        private const int cSize = 50;
        
        private string[] mDate = new string[cSize];
        private string[] mRecord = new string[cSize];

        // CONSTRUCTORS
        //To-display the view.
        public Base_Station_Records_View(ref Shared_Data xSD) : base(ref xSD, "Base Station Records", false, Color.SteelBlue)
        {
            InitializeComponent();
        }

        //To-instantiate the view.
        public Base_Station_Records_View() : base("Base Station Records", false, Color.SteelBlue)
        { }
        //


        private void btnRecord_Click(object sender, EventArgs e)
        {
            
            if (txtRecords.Text == "")
            {
                MessageBox.Show("Enter records.", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (dateTimePicker1.Text == "")
            {
                MessageBox.Show("Enter a Date.", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string date;
            string record;
            date = dateTimePicker1.Text;
            record = txtRecords.Text;
            mDate[mIndex] = date;
            mRecord[mIndex] = record;
            MessageBox.Show("Record Saved.", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            dateTimePicker1.Text = "";
            txtRecords.Text = "";
            mIndex++;
        }


    }
}
