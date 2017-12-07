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
       
        private Special_List<Patient> Patients;



        // CONSTRUCTORS
        //To-setup the view
        int tem = 0;
        public Patient_Information_View(bool toDisplay, ref Special_List<Patient> xPIs) : this(toDisplay)
        {
            Patients = xPIs;
            Patients.ItemAdded -= new EventHandler(lstHistory_AddRecord);
            Patients.ItemAdded += new EventHandler(lstHistory_AddRecord);
            foreach (Patient iPatients in Patients)
            {
                lstHistory.Items.Add(iPatients.GetName().ToString());
            }
            tem = Patients.Count+1;
            txtPatientID.Text = tem.ToString();

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
    
            if (lstHistory.SelectedIndex != -1)
            {
               // DTPBirthDate.Value = DateTime.Now;
                txtComplications.Text = string.Empty;

               // DTPBirthDate.Enabled = true;
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
            if (txtGender.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Enter Patient Gender", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtGender.Focus();
                return;
            }
            if (txtAddress.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Enter Patient Address", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtAddress.Focus();
                return;
            }

            if (txtlastname.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Enter Patient Last Name", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtlastname.Focus();
                return;
            }

            if (txtBloodType.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Enter Patient Blood Type", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtBloodType.Focus();
                return;
            }

            if (txtDOB.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Enter Patient Age", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtDOB.Focus();
                return;
            }

            //Type Check
           

            else // All checks are satisfied
            {
               // DTPBirthDate.Enabled = false;
                txtComplications.Enabled = false;

                Patient pat = new Patient();

                pat.SetLast_Name(txtlastname.Text);
                pat.SetName(txtName.Text);
                pat.SetDOB(txtDOB.Text);
                pat.setbloodtype(txtBloodType.Text);
                pat.setcomplication(txtComplications.Text);
                pat.setInsuranceID(txtInsuranceID.Text);
                pat.setPatientID(txtPatientID.Text);
                pat.setGender(txtGender.Text);
                pat.SetAddress(txtAddress.Text);
                bool bol = false;
                for (int a = 0; a < Patients.Count; a++) {
                 if (Patients[a].GetName() == pat.GetName() && Patients[a].GetLast_Name() == pat.GetLast_Name())
                    {
                        Patients[a]=pat;
                  
                        bol = true;
                        break;
                    }
                }
                if (bol == false) {
                    Patients.AddItem(pat);
                    tem++;
                }
                clear();
                lstHistory.Items.Clear();
                foreach (Patient iPatients in Patients)
                {
                    lstHistory.Items.Add(iPatients.GetName().ToString());
                }
                lstHistory.SelectedIndex = lstHistory.Items.IndexOf(pat);
                SendStatusUpdate(true, "Patient Record Added!", "success");
                txtPatientID.Text = tem.ToString();
            }
        }

        private void lstHistory_AddRecord(object sender, EventArgs e)
        {
            Patient a = (Patient)sender;
            lstHistory.Items.Add(a);
        }

        private void lstHistory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstHistory.SelectedIndex == -1)
                return;
            Patient temp = Patients[lstHistory.SelectedIndex];
           // DTPBirthDate.Value = ((PatientInformation)lstHistory.SelectedItem).GetBirthDate();
             txtComplications .Text = temp.getComplication();
            txtName.Text = temp.GetName();
            txtDOB.Text = temp.GetDOB();
            txtlastname.Text = temp.GetLast_Name();
            txtBloodType.Text = temp.getbloodtype();
            txtAddress.Text = temp.GetAddress();
            txtInsuranceID.Text = temp.getInsuranceID();
            txtPatientID.Text = temp.getPatientID();
            txtGender.Text = temp.getGender();




         //   DTPBirthDate.Enabled = false;
            txtBloodType.Enabled = false;
            txtlastname.Enabled = false;
            txtName.Enabled = false;
            btnnew.Enabled = true;
          
           
          
           
        }
        public void clear() {
            txtName.Text = "";
            txtDOB.Text = "";
            txtlastname.Text = "";
            txtBloodType.Text = "";
            txtAddress.Text = "";
            txtInsuranceID.Text = "";
            txtPatientID.Text = "";
            txtGender.Text = "";



        }
        private void btnnew_Click(object sender, EventArgs e)
        {
            txtName.Enabled = true;
            txtBloodType.Enabled = true;
            txtlastname.Enabled = true;
            clear();
            btnnew.Enabled = false;
            txtPatientID.Text = tem.ToString();
        }
    }
}
