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
    public partial class Invoice_View : Special_View, IUserDependent
    {
        // CONSTRUCTORS
        //To-display the view.
        public Invoice_View(ref Shared_Data xSD) : base(ref xSD, "Invoice", false, Color.DeepPink)
        {
            InitializeComponent();
            listbox1.Items.Add("Address: 270 littelton ST apt214");

            ListViewItem lvi = new ListViewItem("10005");

            lvi.SubItems.Add("200");
            lvi.SubItems.Add("12 - Jan - 2017");

            ListViewItem lvi2 = new ListViewItem("10001");
            lvi2.SubItems.Add("120");
            lvi2.SubItems.Add("10 - Nov - 2017");
            lstEmergencies.Items.Add(lvi);
            lstEmergencies.Items.Add(lvi2);
        }

        //To-instantiate the view.
        public Invoice_View() : base("Invoice", false, Color.DeepPink)
        { }
        //

        // FUNCTIONAL METHODS
        public void SendUser(Person xPerson)
        {
            if (xPerson is Manager)
            {
                // To-Do: Set up the view with the appropriate user data
            }
            else
            {
                btnGenerate.Enabled = false;
                btnSend.Enabled = false;

                lstEmergencies.Enabled = false;

                SendStatusUpdate(true, "To access, you must have Manager access level!", "urgent");
            }
        }
        //
    }
}