using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Reflection;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Rescue_911
{
    public partial class Main_Form : Form
    {
        private Shared_Data SD;
        private Special_View Current_View;

        public Main_Form()
        {
            // Setting up the form.
            // To-Do: Add dynamic ID type identification

            SD = new Shared_Data();

            SD.MainForm = this;

            InitializeComponent();
        }


        // SETTING UP THE VIEWS
        //Displaying the Login screen when the app is launched.
        private void Main_Form_Load(object sender, EventArgs e)
        {
            Login_Prepare(sender, e);
        }

        //Event for displaying the Login screen.
        private void Login_Prepare(object sender, EventArgs e)
        {
            Login_View LoginView = (Login_View)SetView(typeof(Login_View));

            LoginView.LoginButton_Click += new EventHandler(MainView_Prepare);
        }

        //Event for trashing out the Current View and going back to Login screen.
        private void Logout_Prepare(object sender, EventArgs e)
        {
            Current_View.Dispose();

            Login_Prepare(sender, e);
        }

        //Displaying the Main screen when the Login screen is closed.
        private void MainView_Prepare(object sender, EventArgs e)
        {
            if (sideBar.Visible == false)
            {
                sideBar.CallButton_Click += new EventHandler(CallView_Prepare);
                sideBar.EmergencyManagement_Click += new EventHandler(EmergencyManagementView_Prepare);
                sideBar.ResponseTeamInfoButton_Click += new EventHandler(ResponseTeamInfoView_Prepare);
                sideBar.EMTLoginShiftButton_Click += new EventHandler(EMTLoginShiftView_Prepare);
                sideBar.BaseStationRecordsButton_Click += new EventHandler(BaseStationRecordsView_Prepare);
                sideBar.DispatchRelatedTimesButton_Click += new EventHandler(DispatchRelatedTimesView_Prepare);
                sideBar.DispatchReportButton_Click += new EventHandler(DispatchReportView_Prepare);
                sideBar.LinkPatientButton_Click += new EventHandler(LinkPatientView_Prepare);
                sideBar.PatientInformationButton_Click += new EventHandler(PatientInformationView_Prepare);
                sideBar.InvoiceButton_Click += new EventHandler(InvoiceView_Prepare);
                sideBar.LogoutButton_Click += new EventHandler(Logout_Prepare);

                sideBar.Visible = true;
            }

            Main_View MainView = (Main_View)SetView(typeof(Main_View));
        }

        private void CallView_Prepare(object sender, EventArgs e)
        {
            SetTypicalView(typeof(Call_View));
        }

        private void EmergencyManagementView_Prepare(object sender, EventArgs e)
        {
            SetTypicalView(typeof(Emergency_Management_View));
        }

        private void ResponseTeamInfoView_Prepare(object sender, EventArgs e)
        {
            SetTypicalView(typeof(Response_Team_Information_View));
        }

        private void EMTLoginShiftView_Prepare(object sender, EventArgs e)
        {
            SetTypicalView(typeof(EMT_Login_Shift_View));
        }

        private void BaseStationRecordsView_Prepare(object sender, EventArgs e)
        {
            SetTypicalView(typeof(Base_Station_Records_View));
        }

        private void DispatchRelatedTimesView_Prepare(object sender, EventArgs e)
        {
            SetTypicalView(typeof(Dispatch_Related_Times_View));
        }

        private void DispatchReportView_Prepare(object sender, EventArgs e)
        {
            SetTypicalView(typeof(Dispatch_Report_View));
        }

        private void LinkPatientView_Prepare(object sender, EventArgs e)
        {
            SetTypicalView(typeof(Link_Patient_View));
        }

        private void PatientInformationView_Prepare(object sender, EventArgs e)
        {
            SetTypicalView(typeof(Patient_Information_View));
        }

        private void InvoiceView_Prepare(object sender, EventArgs e)
        {
            SetTypicalView(typeof(Invoice_View));
        }
        //


        // FUNCTIONAL METHODS
        public void SetSideBar(ref Shared_Data xSD, List<Type> xAcccessibleViews, Person xUserType)
        {
            sideBar.PopulateSideBar(ref SD, xAcccessibleViews, xUserType);
        }

        private Special_View SetView(Type xSpecialView)
        {
            Current_View = (Special_View)(Activator.CreateInstance(xSpecialView, new object[] { SD }));

            if (Current_View.GetMiddleAligned() == false)
            {
                this.SizeChanged -= new EventHandler(Main_Form_SizeChanged);
                Current_View.Dock = DockStyle.Fill;
            }
            else
            {
                this.SizeChanged += new EventHandler(Main_Form_SizeChanged);

                Main_Form_SizeChanged(null, null);
            }

            Current_View.Show();

            this.Controls.Add(Current_View);
            Current_View.BringToFront();

            return Current_View;
        }

        private void SetTypicalView(Type xTypicalView)
        {
            Special_View SVtemp = Current_View;

            Current_View.Dispose();

            SetView(xTypicalView);

            Current_View.SetPrevious_View(SVtemp);

            // To-Do: Change this
            Current_View.BackButton_Click += new EventHandler(MainView_Prepare);
        }
        //


        private void Main_Form_SizeChanged(object sender, EventArgs e)
        {
            Current_View.Location = new System.Drawing.Point((int)(this.Width / 2.0) - (int)(Current_View.Width / 2.0), 15);
        }

        public void UpdateSD(Shared_Data xSD)
        {
            SD = xSD;
        }

    }
}
