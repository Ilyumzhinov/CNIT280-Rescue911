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
    public partial class Base_Station_Records : Form
    {
        public Base_Station_Records()
        {
            InitializeComponent();

            Name = "Base Station Record";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private int mIndex = 0;
        private const int cSize = 50;
        private string[] mDate = new string[cSize];
        private string[] mRecord = new string[cSize];

        private void btnRecord_Click(object sender, EventArgs e)
        {
            if (txtRecordDate.Text == "")
            {
                MessageBox.Show("Enter a Date.", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtRecords.Text == "")
            {
                MessageBox.Show("Enter records.", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string date;
            string record;
            date = txtRecordDate.Text;
            record = txtRecords.Text;
            mDate[mIndex] = date;
            mRecord[mIndex] = record;
            MessageBox.Show("Record Saved.", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtRecordDate.Text = "";
            txtRecords.Text = "";
            mIndex++;
        }

      
    }
}
