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
    public partial class Main_View : Special_View
    {
        // CONSTRUCTORS
        //To-display the view.
        public Main_View(ref Shared_Data xSD) : base(
            ref xSD, 
            "Main Page", 
            false, 
            Color.Black,
            DateTime.Today.DayOfWeek.ToString() + ", " + DateTime.Today.ToString("MMMM d")
            )
        {
            InitializeComponent();

            lbTime.Text = DateTime.Now.ToString("h:mm:ss MM/dd/yyyy");
            lbUsers.Text = SD.FormsCount.ToString();

        }
        //
    }
}
