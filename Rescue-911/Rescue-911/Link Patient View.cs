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
    public partial class Link_Patient_View : Special_View
    {
        int non = 0;
        int sub = 0;
        int indirectsub = 0;

        private Special_List<Patient> LinkPatients;

        // CONSTRUCTORS
        //To-setup the view.

        public Link_Patient_View(bool toDisplay, ref Special_List<Patient> xLPs) : this(toDisplay)
        {
            LinkPatients = xLPs;

            List<Patient> a = LinkPatients;
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
            button3.Enabled = false;
            button2.Enabled = false;
            for (int i = 0; i < a.Count; i++)
            {
                if (a[i].getSubscribtion().GetSubtitle() == "non subscriber")
                {
                    non++;
                }
                if (a[i].getSubscribtion().GetSubtitle() == "Indirec subscriber")
                {
                    indirectsub++;

                }
                if (a[i].getSubscribtion().GetSubtitle() == "subscriber")
                {
                    sub++;
                }

            }
            label7.Text = sub.ToString();
            label9.Text = non.ToString();
            label8.Text = indirectsub.ToString();
            sub = 0;
            non = 0;
            indirectsub = 0;

        }
        //To-display the view.
        public Link_Patient_View(bool toDisplay) : base(toDisplay)
        {
            if (toDisplay)
                InitializeComponent();
        }
        

        private void button1_Click(object sender, EventArgs e)
        {

            List<Patient> a = LinkPatients;
            int temp = 0;
            if (lstsubs.SelectedItems.Count == 1)
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

                button1.Enabled = false;
                button3.Enabled = false;
                button2.Enabled = false;
            }
            for (int i = 0; i < a.Count; i++)
            {
                if (a[i].getSubscribtion().GetSubtitle() == "non subscriber")
                {
                    non++;
                }
                if (a[i].getSubscribtion().GetSubtitle() == "Indirec subscriber")
                {
                    indirectsub++;

                }
                if (a[i].getSubscribtion().GetSubtitle() == "subscriber")
                {
                    sub++;
                }

            }
            label7.Text = sub.ToString();
            label9.Text = non.ToString();
            label8.Text = indirectsub.ToString();
            sub = 0;
            non = 0;
            indirectsub = 0;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            List<Patient> a = LinkPatients;
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
                if (txtSub.Text == "" || txtProvider.Text == "")
                {
                    MessageBox.Show("Please Input provider and SUB ID");
                    return;
                }
                else

                    for (int b = 0; b < a.Count; b++) {

                       if( a[b].getSubscribtion().GetSubscriberMembershipNumber()== txtSub.Text)
                        {
                            MessageBox.Show("SUB ID MUST BE UNIQE");
                            return;

                        }

                    }
                    a[temp].getSubscribtion().setSubtitle("Indirec subscriber");
                    a[temp].getSubscribtion().setSubscriberMembershipNumber(txtSub.Text);
                    a[temp].getSubscribtion().Getprovider().setCompanyId(txtProvider.Text);
                    a[temp].getSubscribtion().Getprovider().setProviderType(txtTYPE.Text);
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
                if (a[i].getSubscribtion().GetSubtitle() == "Indirec subscriber")
                {
                    indirectsub++;

                }
                if (a[i].getSubscribtion().GetSubtitle() == "subscriber")
                {
                    sub++;
                }

            }
            label7.Text = sub.ToString();
            label9.Text = non.ToString();
            label8.Text = indirectsub.ToString();
            sub = 0;
            non = 0;
            indirectsub = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            List<Patient> a = LinkPatients;
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
                if (txtSub.Text == "")
                {
                    MessageBox.Show("Please Input SUB ID");
                    return;
                }
                else
                    for (int b = 0; b < a.Count; b++)
                    {

                        if (a[b].getSubscribtion().GetSubscriberMembershipNumber() == txtSub.Text)
                        {
                            MessageBox.Show("SUB ID MUST BE UNIQE");
                            return;

                        }

                    }

                a[temp].getSubscribtion().setSubtitle("subscriber");
                a[temp].getSubscribtion().setSubscriberMembershipNumber(txtSub.Text);
                a[temp].getSubscribtion().Getprovider().setCompanyId("");
                a[temp].getSubscribtion().Getprovider().setProviderType("");
                ; lstsubs.Items.Clear();
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

                button1.Enabled = false;
                button3.Enabled = false;
                button2.Enabled = false;
            }
            for (int i = 0; i < a.Count; i++)
            {
                if (a[i].getSubscribtion().GetSubtitle() == "non subscriber")
                {
                    non++;
                }
                if (a[i].getSubscribtion().GetSubtitle() == "Indirec subscriber")
                {
                    indirectsub++;

                }
                if (a[i].getSubscribtion().GetSubtitle() == "subscriber")
                {
                    sub++;
                }

            }
            label7.Text = sub.ToString();
            label9.Text = non.ToString();
            label8.Text = indirectsub.ToString();
            sub = 0;
            non = 0;
            indirectsub = 0;
        }



        private void lstsubs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstsubs.SelectedIndices.Count == 1)
            {

                button1.Enabled = true;
                button3.Enabled = true;
                button2.Enabled = true;
            }
        }

    }
    
}
