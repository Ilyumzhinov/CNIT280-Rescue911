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
    public partial class Sub_Payment_View : Special_View, IUserDependent
    {
        // CONSTRUCTORS
        //To setup the view

        
        //To-display
        public Sub_Payment_View(bool toDisplay) : base(toDisplay, "Sub Payment", Color.PowderBlue, false)
        {
            if (toDisplay)
            {
                InitializeComponent();
            }
            

            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "MM/yy";
        }



        // FUNCTIONAL METHODS
        public void SendUser(Person xPerson)
        {
            if (xPerson is Manager)
            {

            }
            else
            {
                btnPay.Enabled = false;
                SendStatusUpdate(true, "To access, you must have Manager acess level!", "urgent");
            }
        }
    }
}
