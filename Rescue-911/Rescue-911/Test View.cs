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
    public partial class Test_View : Special_View
    {
        public Test_View(ref Shared_Data xSD) : base(ref xSD, "Test View", false, Color.Purple, "my desc")
        {
            InitializeComponent();
            button1.Text = SD.GetPatients()[0].GetAddress();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //
        }
    }
}
