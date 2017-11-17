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
    public partial class LinkPatient : Special_Form
    {
        public LinkPatient(ref Shared_Data xSD) : base(ref xSD, "Link Patient")
        {
            InitializeComponent();
        }

        private void Linkepatientandsub_Load(object sender, EventArgs e)
        {

            List<Patient> a = SD.Patients;
            for (int b = 0; b < a.Count(); b++)
            {
                ListViewItem lvi = new ListViewItem(a[b].GetLast_Name() + ", " + a[b].GetName());
                
                lvi.SubItems.Add(a[b].getSubscribtion().GetSubtitle());
                lstsubs.Items.Add(lvi);
               
            }
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {

            List<Patient> a = SD.Patients;
            int temp = 0;
            if (lstsubs.SelectedItems.Count > 0)
            {
                temp = lstsubs.Items.IndexOf(lstsubs.SelectedItems[0]);
            }
            if (temp == -1)
            {
                return;
            }
            else
            {
               
                a[temp].getSubscribtion().setSubtitle("non subscriber");
                lstsubs.Items.Clear();
                for (int i = 0; i < a.Count(); i++)
                {
                    ListViewItem lvi = new ListViewItem(a[i].GetLast_Name() + ", " + a[i].GetName());

                    lvi.SubItems.Add(a[i].getSubscribtion().GetSubtitle());
                    lstsubs.Items.Add(lvi);
                }
                SD.Patients = a;
                ((Login_Form)SD.LoginForm).UpdateSD(SD);
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            List<Patient> a = SD.Patients;
            int temp = 0;
            if (lstsubs.SelectedItems.Count > 0)
            {
                temp = lstsubs.Items.IndexOf(lstsubs.SelectedItems[0]);
            }
            if (temp == -1)
            {
                return;
            }
            else
            {
                
                a[temp].getSubscribtion().setSubtitle("subscriber");
                lstsubs.Items.Clear();
                for (int i = 0; i < a.Count(); i++)
                {

                    ListViewItem lvi = new ListViewItem(a[i].GetLast_Name() + ", " + a[i].GetName());

                    lvi.SubItems.Add(a[i].getSubscribtion().GetSubtitle());
                    lstsubs.Items.Add(lvi);
                }
                SD.Patients = a;
                ((Login_Form)SD.LoginForm).UpdateSD(SD);
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<Patient> a = SD.Patients;
            int temp=0;
            if (lstsubs.SelectedItems.Count > 0)
            {
                temp = lstsubs.Items.IndexOf(lstsubs.SelectedItems[0]);
            }
            if (temp == -1)
            {
                return;
            }
            else
            {
               
                a[temp].getSubscribtion().setSubtitle("indirec subscriber");
                lstsubs.Items.Clear();
                for (int i = 0; i < a.Count(); i++)
                {

                    ListViewItem lvi = new ListViewItem(a[i].GetLast_Name() + ", " + a[i].GetName());

                    lvi.SubItems.Add(a[i].getSubscribtion().GetSubtitle());
                    lstsubs.Items.Add(lvi);
                }
                SD.Patients = a;

                ((Login_Form)SD.LoginForm).UpdateSD(SD);
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
            }
        }

        private void lstsubs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstsubs.SelectedItems.Count > 0) {

                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
            }
        }
    }
}
