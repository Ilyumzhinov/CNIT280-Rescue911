using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rescue_911
{
    public partial class Special_View : UserControl
    {
        protected Shared_Data SD;


        // Reference: https://stackoverflow.com/questions/1216940/net-inherited-winforms-form-vs-designer-issue.
        public Special_View(ref Shared_Data xSD, string xTitle) : this()
        {
            SD = xSD;

            this.Text = xTitle;
            this.lbTitle.Text = xTitle;
            //this.lbTitle.Dock = DockStyle.Top;
            this.lbTitle.Visible = true;
        }

        public Special_View()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {

        }
    }
}
