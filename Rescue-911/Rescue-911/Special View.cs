using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Rescue_911
{
    public partial class Special_View : UserControl
    {
        protected Shared_Data SD;
        protected bool MiddleAligned;

        // Reference: https://stackoverflow.com/questions/1216940/net-inherited-winforms-form-vs-designer-issue.
        public Special_View(ref Shared_Data xSD, string xTitle, bool xMiddleAligned) : this()
        {
            SD = xSD;
            MiddleAligned = xMiddleAligned;

            this.Text = xTitle;
            this.lbTitle.Text = xTitle;
            this.BackColor = Color.Transparent;
            this.lbTitle.Visible = true;
        }

        private Special_View()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {

        }

        public bool GetMiddleAligned() { return MiddleAligned; }
    }
}