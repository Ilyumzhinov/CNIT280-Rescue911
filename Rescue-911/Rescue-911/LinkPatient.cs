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
    public partial class LinkPatient : Special_Form
    {
        public LinkPatient(ref Shared_Data xSD) : base(ref xSD, "Link Patient")
        {
            InitializeComponent();
        }

        private void Linkepatientandsub_Load(object sender, EventArgs e)
        {

            List<Patient> a = SD.Patients;
            for (int b = 0; b < a.Count(); b++)
            {

                listBox1.Items.Add(a[b].GetLast_Name() + ", " + a[b].GetName() + "     " + a[b].getsubsc());
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

            List<Patient> a = SD.Patients;
            if (listBox1.SelectedIndex == -1)
            {
                return;
            }
            else
            {
                int b = listBox1.SelectedIndex;
                a[b].setsubsc("non subscriber");
                listBox1.Items.Clear();
                for (int i = 0; i < a.Count(); i++)
                {

                    listBox1.Items.Add(a[i].GetLast_Name() + ", " + a[i].GetName() + "     " + a[i].getsubsc());
                }
                SD.Patients = a;
                ((Login_Form)SD.LoginForm).UpdateSD(SD);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            List<Patient> a = SD.Patients;
            if (listBox1.SelectedIndex == -1)
            {
                return;
            }
            else
            {
                int b = listBox1.SelectedIndex;
                a[b].setsubsc("subscriber");
                listBox1.Items.Clear();
                for (int i = 0; i < a.Count(); i++)
                {

                    listBox1.Items.Add(a[i].GetLast_Name() + ", " + a[i].GetName() + "     " + a[i].getsubsc());
                }
                SD.Patients = a;
                ((Login_Form)SD.LoginForm).UpdateSD(SD);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<Patient> a = SD.Patients;
            if (listBox1.SelectedIndex == -1)
            {
                return;
            }
            else
            {
                int b = listBox1.SelectedIndex;
                a[b].setsubsc("indirec subscriber");
                listBox1.Items.Clear();
                for (int i = 0; i < a.Count(); i++)
                {

                    listBox1.Items.Add(a[i].GetLast_Name() + ", " + a[i].GetName() + "     " + a[i].getsubsc());
                }
                SD.Patients = a;

                ((Login_Form)SD.LoginForm).UpdateSD(SD);
            }
        }
    }
}
