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
    public partial class Special_Panel : UserControl
    {
        private string mTitle;
        private string mNumber;

        [Description("Set Title")]
        public string Title
        {
            get { return mTitle; }
            set
            {
                mTitle = value;

                if (lbTitle != null)
                    lbTitle.Text = mTitle;
            }
        }
        [Description("Set Number")]
        public string Number
        {
            get { return mNumber; }
            set
            {
                mNumber = value;

                if (lbNumber != null)
                    lbNumber.Text = mNumber;
            }
        }

        public Special_Panel()
        {
            InitializeComponent();
        }
    }
}