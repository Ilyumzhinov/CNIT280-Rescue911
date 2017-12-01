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
        //To-display
        public Sub_Payment_View(ref Shared_Data xSD) : base(ref xSD, "Sub Payment", false, Color.PowderBlue)
        {
            InitializeComponent();

            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "MM/yy";
        }

        //To-instantiate
        public Sub_Payment_View() : base("Sub Payment", false, Color.PowderBlue) { }
        //


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
