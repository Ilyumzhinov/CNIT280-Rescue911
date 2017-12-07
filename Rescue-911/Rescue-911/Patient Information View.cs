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
       
        private Special_List<PatientInformation> Patients;

       

        // CONSTRUCTORS
        //To-setup the view

        public Patient_Information_View(bool toDisplay, ref Special_List<PatientInformation> xPIs) : this(toDisplay)
        {
            Patients = xPIs;

            Patients.ItemAdded -= new EventHandler(lstHistory_AddRecord);
            Patients.ItemAdded += new EventHandler(lstHistory_AddRecord);

            foreach (PatientInformation iPatients in Patients)
            {
                lstHistory.Items.Add(iPatients);
            }

        }
        //To-display the view.
        public Patient_Information_View(bool toDisplay) : base(toDisplay)
        {
         
                InitializeComponent();
        }

        // FUNCTIONAL METHODS
        public void SendUser(Person xPerson)
        {
            if (xPerson is Manager)
            {
                // To-Do: Set up the view with the appropriate user data
            }
            else
            {
                btnAddRecord.Enabled = false;


                txtComplications.Enabled = false;

                SendStatusUpdate(true, "To access, you must have Manager access level!", "urgent");
            }
        }
        private void btnAddRecord_Click(object sender, EventArgs e)
        {
            int Age;


            if (lstHistory.SelectedIndex != -1)
            {
                DTPBirthDate.Value = DateTime.Now;
                txtComplications.Text = string.Empty;

                DTPBirthDate.Enabled = true;
                txtComplications.Enabled = true;

                lstHistory.SelectedIndex = -1;
            }

            // Existence checks
            if (txtName.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Enter Patient Name", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtName.Focus();
                return;
            }

            if (txtBloodType.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Enter Patient Blood Type", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtBloodType.Focus();
                return;
            }

            if (txtAge.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Enter Patient Age", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtAge.Focus();
                return;
            }

            //Type Check
            if (int.TryParse(txtAge.Text, out Age) == false)
            {
                MessageBox.Show("Enter a real number for Patient Age.", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtAge.Focus();
                return;
            }

            else // All checks are satisfied
            {
                DTPBirthDate.Enabled = false;
                txtComplications.Enabled = false;

                PatientInformation PatientHealthInformation = new PatientInformation();

                PatientHealthInformation.SetPatientName(txtName.Text);
                PatientHealthInformation.Setage(int.Parse(txtAge.Text));
                PatientHealthInformation.SetBirthdate(DTPBirthDate.Value);
                PatientHealthInformation.SetBloodType(txtBloodType.Text);
                PatientHealthInformation.Setcomplication(txtComplications.Text);

                Patients.AddItem(PatientHealthInformation);

                lstHistory.SelectedIndex = lstHistory.Items.IndexOf(PatientHealthInformation);
                SendStatusUpdate(true, "Patient Record Added!", "success");


            }
        }

        private void lstHistory_AddRecord(object sender, EventArgs e)
        {
            lstHistory.Items.Add((PatientInformation)sender);
        }

        private void lstHistory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstHistory.SelectedIndex == -1)
                return;

            DTPBirthDate.Value = ((PatientInformation)lstHistory.SelectedItem).GetBirthDate();
            txtComplications.Text = ((PatientInformation)lstHistory.SelectedItem).Getcomplication();
            DTPBirthDate.Enabled = false;
            txtComplications.Enabled = false;
        }
    }
}
