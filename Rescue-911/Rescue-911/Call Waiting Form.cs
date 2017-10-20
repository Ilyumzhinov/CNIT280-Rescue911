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
    public partial class Call_Waiting_Form : Form
    {
        Emergency ExistingEmergency = new Emergency();
        private int emergencySelected;

        public Call_Waiting_Form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lstEmergencies.Visible = true;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            lstEmergencies.Items[emergencySelected].SubItems[2].Text = "Active";
           

            textBox1.Enabled = false;
            button1.Enabled = false;
            lstEmergencies.Enabled = false;
            radioButton1.Enabled = false;
            radioButton2.Enabled = false;
            listBox1.Enabled = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            lstEmergencies.Items[emergencySelected].SubItems[2].Text = "Canceled";
            textBox1.Enabled = false;
            button1.Enabled = false;
            lstEmergencies.Enabled = false;
            radioButton1.Enabled = false;
            radioButton2.Enabled = false;
            listBox1.Enabled = false;
        }

        private void Call_Waiting_Form_Load(object sender, EventArgs e)
        {
            

            ListViewItem lstItem = new ListViewItem("111");

            lstItem.SubItems.Add(DateTime.Now.ToString("h:mm:ss MM/dd/yyyy "));
            lstItem.SubItems.Add("Waiting");
            lstItem.SubItems.Add("A person injured");

            lstEmergencies.Items.AddRange(new ListViewItem[] { lstItem });

            lstItem = new ListViewItem("112");

            lstItem.SubItems.Add(DateTime.Now.ToString("h:mm:ss MM/dd/yyyy "));
            lstItem.SubItems.Add("Waiting");
            lstItem.SubItems.Add("A person shot");

            lstEmergencies.Items.AddRange(new ListViewItem[] { lstItem });

            lstItem = new ListViewItem("113");
            lstItem.SubItems.Add(DateTime.Now.ToString("h:mm:ss MM/dd/yyyy "));
            lstItem.SubItems.Add("Waiting");
            lstItem.SubItems.Add("A person fell off stairs");

            lstEmergencies.Items.AddRange(new ListViewItem[] { lstItem });
        }

        private void lstEmergencies_SelectedIndexChanged(object sender, EventArgs e)
        {
                emergencySelected = lstEmergencies.SelectedIndices[0];
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
