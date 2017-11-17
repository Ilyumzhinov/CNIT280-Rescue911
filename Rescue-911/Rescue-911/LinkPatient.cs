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
        int sub = 0;
        int indirectsub = 0;
        public LinkPatient(ref Shared_Data xSD) : base(ref xSD, "Link Patient")
        {
            InitializeComponent();
        }

        private void Linkepatientandsub_Load(object sender, EventArgs e)
        {
            Link_Patient_View LPV = new Link_Patient_View(ref SD);
            LPV.Dock = DockStyle.Fill;
            LPV.Show();

            this.Controls.Add(LPV);

        }
    }
}
