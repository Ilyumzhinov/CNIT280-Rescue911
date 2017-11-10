using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rescue_911
{
    public class General_Form : Form
    {
        protected Shared_Data SD;

        public General_Form(ref Shared_Data xSD)
        {
            SD = xSD;
        }
    }
}
