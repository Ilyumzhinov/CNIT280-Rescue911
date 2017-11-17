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
        int non = 0;
        int sub=0;
        int indirectsub=0;
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
                lvi.SubItems.Add(a[b].getSubscribtion().GetSubscriberMembershipNumber());
                lvi.SubItems.Add(a[b].getSubscribtion().Getprovider().getCompanyId());
                lvi.SubItems.Add(a[b].getSubscribtion().Getprovider().getProviderType());
                lvi.SubItems.Add(b.ToString());
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
                    lvi.SubItems.Add(a[i].getSubscribtion().GetSubscriberMembershipNumber());
                    lvi.SubItems.Add(a[i].getSubscribtion().Getprovider().getCompanyId());
                    lvi.SubItems.Add(a[i].getSubscribtion().Getprovider().getProviderType());
                    lvi.SubItems.Add(i.ToString());
                    lstsubs.Items.Add(lvi);
                }
                SD.Patients = a;
                ((Login_Form)SD.LoginForm).UpdateSD(SD);
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
            }
            for (int i = 0; i < a.Count; i++)
            {
                if (a[i].getSubscribtion().GetSubtitle() == "non subscriber")
                {
                    non++;
                }
                if (a[i].getSubscribtion().GetSubtitle() == "Indirec subscriber" && a[i].getSubscribtion().Getprovider().getCompanyId() == "Indirec subscriber")
                {
                    indirectsub++;

                }
                if (a[i].getSubscribtion().GetSubtitle() == "subscriber" && a[i].getSubscribtion().Getprovider() == null)
                {
                    sub++;
                }
                
            }
            lb1.Text = sub.ToString();
            lb2.Text = non.ToString();
            lb3.Text = indirectsub.ToString();
            sub = 0;
            non = 0;
            indirectsub = 0;
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
                if (txtSub.Text == "") {
                    MessageBox.Show("Please Input SUB ID");
                    return;
                }else 
                
                a[temp].getSubscribtion().setSubtitle("subscriber");
                a[temp].getSubscribtion().setSubscriberMembershipNumber(txtSub.Text);
                a[temp].getSubscribtion().Getprovider().setCompanyId("");
                a[temp].getSubscribtion().Getprovider().setProviderType("");
;             lstsubs.Items.Clear();
                for (int i = 0; i < a.Count(); i++)
                {

                    ListViewItem lvi = new ListViewItem(a[i].GetLast_Name() + ", " + a[i].GetName());

                    lvi.SubItems.Add(a[i].getSubscribtion().GetSubtitle());
                    lvi.SubItems.Add(a[i].getSubscribtion().GetSubscriberMembershipNumber());
                    lvi.SubItems.Add(a[i].getSubscribtion().Getprovider().getCompanyId());
                    lvi.SubItems.Add(a[i].getSubscribtion().Getprovider().getProviderType());
                    lvi.SubItems.Add(i.ToString());
                    lstsubs.Items.Add(lvi);
                }
                SD.Patients = a;
                ((Login_Form)SD.LoginForm).UpdateSD(SD);
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
            }
            for (int i = 0; i < a.Count; i++)
            {
                if (a[i].getSubscribtion().GetSubtitle() == "non subscriber")
                {
                    non++;
                }
                if (a[i].getSubscribtion().GetSubtitle() == "subscriber" && a[i].getSubscribtion().Getprovider().getCompanyId() == "Indirec subscriber")
                {
                    indirectsub++;

                }
                if (a[i].getSubscribtion().GetSubtitle() == "subscriber" && a[i].getSubscribtion().Getprovider() == null)
                {
                    sub++;
                }
            }
            lb1.Text = sub.ToString();
            lb2.Text = non.ToString();
            lb3.Text = indirectsub.ToString();
            sub = 0;
            non = 0;
            indirectsub = 0;
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
                if (txtSub.Text == ""||txtProvider.Text=="")
                {
                    MessageBox.Show("Please Input provider and SUB ID");
                    return;
                }
                else


                a[temp].getSubscribtion().setSubtitle("Indirec subscriber");
                a[temp].getSubscribtion().setSubscriberMembershipNumber(txtSub.Text);
                a[temp].getSubscribtion().Getprovider().setCompanyId(txtProvider.Text);
                a[temp].getSubscribtion().Getprovider().setProviderType(txtType.Text);
                lstsubs.Items.Clear();
                for (int i = 0; i < a.Count(); i++)
                {

                    ListViewItem lvi = new ListViewItem(a[i].GetLast_Name() + ", " + a[i].GetName());

                    lvi.SubItems.Add(a[i].getSubscribtion().GetSubtitle());
                    lvi.SubItems.Add(a[i].getSubscribtion().GetSubscriberMembershipNumber());
                    lvi.SubItems.Add(a[i].getSubscribtion().Getprovider().getCompanyId());
                    lvi.SubItems.Add(a[i].getSubscribtion().Getprovider().getProviderType());
                    lvi.SubItems.Add(i.ToString());
                    lstsubs.Items.Add(lvi);
                }
                SD.Patients = a;

                ((Login_Form)SD.LoginForm).UpdateSD(SD);
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
            }
            for (int i = 0; i < a.Count; i++)
            {
                if (a[i].getSubscribtion().GetSubtitle() == "non subscriber")
                {
                    non++;
                }
                if (a[i].getSubscribtion().GetSubtitle() == "subscriber" && a[i].getSubscribtion().Getprovider() != null)
                {
                    indirectsub++;

                }
                if (a[i].getSubscribtion().GetSubtitle() == "subscriber" && a[i].getSubscribtion().Getprovider() == null)
                {
                    sub++;
                }
            }
            lb1.Text = sub.ToString();
            lb2.Text = non.ToString();
            lb3.Text = indirectsub.ToString();
            sub = 0;
            non = 0;
            indirectsub = 0;
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
