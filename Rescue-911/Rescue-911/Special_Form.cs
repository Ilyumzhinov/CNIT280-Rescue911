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
    // A form used by most of the forms in the program.
    // Has a special constructor which receives Shared Data and sets the Title of the Form automatically.
    public partial class Special_Form : Form
    {
        protected Shared_Data SD;

        // Reference: https://stackoverflow.com/questions/1216940/net-inherited-winforms-form-vs-designer-issue.
        public Special_Form(ref Shared_Data xSD, string xTitle) : this()
        {
            SD = xSD;

            this.Text = xTitle;
        }

        public Special_Form()
        {
            InitializeComponent();

        }
    }
}
