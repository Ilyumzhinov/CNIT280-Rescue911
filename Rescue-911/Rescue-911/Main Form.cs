using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Reflection;

namespace Rescue_911
{
    public partial class Main_Form : Form
    {
        Shared_Data SD;

        public Main_Form(Shared_Data xSD, List<Type> xAcccessibleForms, Person xUserType)
        {
            SD = xSD;

            InitializeComponent();

            sideBar.PopulateSideBar(ref SD, xAcccessibleForms, xUserType);

            // Setting up the form.
            // To-Do: Add dynamic ID type identification
        }

    
        public void UpdateSD(Shared_Data xSD)
        {
            SD = xSD;
        }

        private void Main_Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (SD.LoginForm != null)
                SD.LoginForm.Close();
        }
    }
}
