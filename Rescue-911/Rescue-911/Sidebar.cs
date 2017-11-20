using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Reflection;
using System.Drawing;

namespace Rescue_911
{
    public partial class Sidebar : UserControl
    {
        // DATA STRUCTURE
        //Primitives
        private Shared_Data SD;
        private Button mSelectedButton;

        //Composite Data
        private List<Button> Buttons;

        //Event Handlers
        public event EventHandler CallButton_Click;
        public event EventHandler EmergencyManagement_Click;
        public event EventHandler ResponseTeamInfoButton_Click;
        public event EventHandler EMTLoginShiftButton_Click;
        public event EventHandler BaseStationRecordsButton_Click;
        public event EventHandler DispatchRelatedTimesButton_Click;
        public event EventHandler DispatchReportButton_Click;
        public event EventHandler LinkPatientButton_Click;
        public event EventHandler PatientInformationButton_Click;
        public event EventHandler InvoiceButton_Click;
        public event EventHandler LogoutButton_Click;
        //


        public Sidebar()
        {
            InitializeComponent();
        }


        // FUNCTIONAL METHODS
        //This method is called from the outside and has the data to be populated.
        public void PopulateSideBar(ref Shared_Data xSD, List<Type> xAcccessibleViews, Person xUserType)
        {
            SD = xSD;

            // To-Do: If an EMT, show a Response Team ID to which they belong.
            lbUser.Text = xUserType.GetName() + " " + xUserType.GetLast_Name();
            lbAccessLevel.Text = xUserType.GetType().ToString();

            layoutPanel.Width = this.Width;
            layoutPanel.BorderStyle = BorderStyle.None;

            PopulateMenu(xAcccessibleViews);
        }

        //This method is used to dynamically populate the form with buttons.
        //Reference on LayoutPanel: https://docs.microsoft.com/en-us/dotnet/framework/winforms/controls/walkthrough-arranging-controls-on-windows-forms-using-a-flowlayoutpanel#positioning-controls-using-docking-and-anchoring
        private void PopulateMenu(List<Type> xAcccessibleViews)
        {
            Special_View instance;
            Buttons = new List<Button>();

            for (int i = 0; i < xAcccessibleViews.Count; i++)
            {
                //Creating an instance of a view to get its attributes.
                instance = (Special_View)(Activator.CreateInstance(xAcccessibleViews[i], new object[] { }));

                Buttons.Add(new Button());
                Buttons[i].Size = new System.Drawing.Size(layoutPanel.Width, 25);
                Buttons[i].Cursor = System.Windows.Forms.Cursors.Hand;
                Buttons[i].FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                Buttons[i].FlatAppearance.BorderSize = 0;
                Buttons[i].Font = new System.Drawing.Font("Corbel", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                Buttons[i].ForeColor = instance.GetColour();
                Buttons[i].Name = "btn" + i.ToString();
                Buttons[i].Tag = i;
                Buttons[i].TabIndex = i;
                Buttons[i].Text = instance.GetTitle();
                Buttons[i].TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

                //Spacing between buttons
                Buttons[i].Margin = new Padding(0, 0, 0, 0);

                layoutPanel.Controls.Add(Buttons[i]);

                //Special rules for the Logout button.
                if (i == (xAcccessibleViews.Count - 1))
                {
                    Buttons[i].Text = "Logout";
                    Buttons[i].BackColor = Color.WhiteSmoke;
                    Buttons[i].Margin = new Padding(0, 10, 0, 0);
                }

                // Doing the funcitonal button setup
                //Uniform way of creating the click event
                Buttons[i].Click += (sender, e) =>
                {
                    Special_View viewInstance = (Special_View)(Activator.CreateInstance(xAcccessibleViews[((Button)sender).TabIndex], new object[] { SD }));

                    MenuElement_Changed(sender, e);

                    ((Button)sender).BackColor = viewInstance.GetColour();
                    ((Button)sender).Enabled = false;
                    ((Button)sender).ForeColor = Color.White;

                    viewInstance.Show();

                    SetUpButton((Button)sender, e, xAcccessibleViews[((Button)sender).TabIndex]);
                };
            }
        }

        //Do the functional button setup.
        private void SetUpButton(Button sender, EventArgs e, Type t)
        {
            if (t == typeof(Call_View))
            {
                CallButton_Click?.Invoke(this, e);
            }
            else if (t == typeof(Emergency_Management_View))
            {
                EmergencyManagement_Click?.Invoke(this, e);
            }
            else if (t == typeof(Response_Team_Information_View))
            {
                ResponseTeamInfoButton_Click?.Invoke(this, e);
            }
            else if (t == typeof(EMT_Login_Shift_View))
            {
                EMTLoginShiftButton_Click?.Invoke(this, e);
            }
            else if (t == typeof(Base_Station_Records_View))
            {
                BaseStationRecordsButton_Click?.Invoke(this, e);
            }
            else if (t == typeof(Dispatch_Related_Times_View))
            {
                DispatchRelatedTimesButton_Click?.Invoke(this, e);
            }
            else if (t == typeof(Dispatch_Report_View))
            {
                DispatchReportButton_Click?.Invoke(this, e);
            }
            else if (t == typeof(Link_Patient_View))
            {
                LinkPatientButton_Click?.Invoke(this, e);
            }
            else if (t == typeof(Patient_Information_View))
            {
                PatientInformationButton_Click?.Invoke(this, e);
            }
            else if (t == typeof(Invoice_View))
            {
                InvoiceButton_Click?.Invoke(this, e);
            }
            else if (t == typeof(Login_View))
            {
                this.Hide();

                layoutPanel.Controls.Clear();

                LogoutButton_Click?.Invoke(this, e);
            }
        }
        //


        // EVENTS
        public void MenuElement_Changed(object sender, EventArgs e)
        {
            // The first time a button gets selected.
            if (mSelectedButton == null)
            {
                mSelectedButton = (Button)sender;
            }

            // Activate the previously selected button.
            if (mSelectedButton != (Button)sender)
            {
                mSelectedButton.Enabled = true;
                mSelectedButton.ForeColor = mSelectedButton.BackColor;
                mSelectedButton.BackColor = Color.Transparent;

                mSelectedButton = (Button)sender;
            }
        }
        //

        // Draws a vertical line that separates the control.
        //Reference: https://www.youtube.com/watch?v=s94WCTDMtbw
        private void LinePaint(object sender, PaintEventArgs e)
        {
            Graphics gObject = this.CreateGraphics();

            Brush colour = new SolidBrush(SystemColors.MenuHighlight);
            Pen colourPen = new Pen(colour, 8);

            gObject.FillRectangle(colour, this.Width - 1, 0, 1, this.Height);
        }
        //
    }
}