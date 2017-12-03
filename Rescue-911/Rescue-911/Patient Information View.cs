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
    public partial class Patient_Information_View : Special_View
    {
        int mSize = 150;
        int[] age = new int[150];
        string[] name = new string[150];
        string[] date = new string[150];
        string[] bloodtype = new string[150];
        string[] complications = new string[150];
        string patientname = "Jane Smith";
        string patientblood = "O";
        int patientage = 22;
        string birthdate = "November 3rd, 1995";
        string complic = "Had triple heart bypass surgery";
        int mIndex = 0;

        private Special_List<Patient> Patients;

        // CONSTRUCTORS
        //To-setup the view

        public Patient_Information_View(bool toDisplay, ref Special_List<Patient> xPIs) : this(toDisplay)
        {
            Patients = xPIs;

        }
        //To-display the view.
        public Patient_Information_View(bool toDisplay) : base(toDisplay, "Patient Information", Color.Orchid, false)
        {
            if (toDisplay)
                InitializeComponent();
        }

        
        //

        private void btnSearch_Click(object sender, EventArgs e)
        {
            age[0] = patientage;
            date[0] = birthdate;
            name[0] = patientname;
            bloodtype[0] = patientblood;
            complications[0] = complic;

            int ctr;
            for (ctr = 0; ctr < mSize; ctr++)
            {
                if (name[mIndex] == txtName.Text)
                {
                    int agetemp;
                    agetemp = age[mIndex];
                    txtAge.Text = agetemp.ToString();
                    txtBloodType.Text = bloodtype[mIndex];
                    txtBirthdate.Text = date[mIndex];
                    txtComplications.Text = complications[mIndex];
                    MessageBox.Show("Patient found!");
                    return;
                }
            }
            MessageBox.Show("Patient not found!");
        }
    }
}
