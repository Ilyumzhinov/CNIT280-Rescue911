using System;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Rescue_911
{
    public partial class Emergency_Link_Form : Special_Form
    {
        private Emergency_Call Current_Call;
        private int emergencySelected;

        public Emergency_Link_Form(ref Shared_Data xSD) : base(ref xSD, "Emergency Link")
        {
            // Change it
            Current_Call = SD.Calls[SD.Calls.Count - 1];

            InitializeComponent();
        }
    }
}