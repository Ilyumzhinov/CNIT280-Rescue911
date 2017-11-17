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
    public partial class Invoice_Form : Special_Form
    {
        public Invoice_Form(ref Shared_Data xSD) : base(ref xSD, "Invoice Form")
        {
            InitializeComponent();
        }
    }
}
