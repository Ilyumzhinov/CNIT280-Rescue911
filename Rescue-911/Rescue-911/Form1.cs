using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Rescue_911
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public GetName(string xName) 
        {
            Form2 itsName = new Form2();
            
            itsname.Show();


            Name = xName;
        }
    }
}
