using System;
using System.Drawing;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Rescue_911
{
    public partial class Login_View : Special_View
    {
        // DATA STRUCTURE
        // Composite data
        private List<Tuple<Employee, int, string>> EmployeesLogins;
        private Shared_Data SD;
        //Events
        public event EventHandler LoginButton_Click;
        //


        // CONSTRUCTORS
        //To-setup the view.
        public Login_View(bool toDisplay, ref Shared_Data xSD) : this(toDisplay)
        {
            SD = xSD;
            Employees_Data EmloyeesData = new Employees_Data(ref SD);

            EmployeesLogins = EmloyeesData.GetEmployeesLoginsPasswords();
        }

        //To-display the view.
        public Login_View(bool toDisplay) : base(toDisplay, true)
        {
            //To-instantiate the view.
            InitializeComponent();


            //btnLogin.Image = SystemIcons.Warning.ToBitmap();
            //btnNewMain.Image = SystemIcons.WinLogo.ToBitmap();
        }
        //


        // FUNCTIONAL METHODS
        private List<Type> FetchAccessibleViews(Type xUserType)
        {
            List<Type> AccessibleViews = new List<Type>();


            if (xUserType == typeof(Operator) || xUserType == typeof(Supervisor) || xUserType == typeof(Employee))
                AccessibleViews.Add(typeof(Call_View));

            if (xUserType == typeof(Operator) || xUserType == typeof(Supervisor) || xUserType == typeof(Employee))
                AccessibleViews.Add(typeof(Emergency_Management_View));

            if (xUserType == typeof(EMT) || xUserType == typeof(Employee))
                AccessibleViews.Add(typeof(Response_Team_Information_View));

            if (xUserType == typeof(EMT) || xUserType == typeof(Employee))
                AccessibleViews.Add(typeof(EMT_Login_Shift_View));

            if (xUserType == typeof(EMT) || xUserType == typeof(Employee))
                AccessibleViews.Add(typeof(Dispatch_Report_View));

            if (xUserType == typeof(Manager) || xUserType == typeof(Employee))
                AccessibleViews.Add(typeof(Base_Station_Records_View));

            if (xUserType == typeof(Operator) || xUserType == typeof(Employee))
                AccessibleViews.Add(typeof(Dispatch_Related_Times_View));

            if (xUserType == typeof(Manager) || xUserType == typeof(Employee))
                AccessibleViews.Add(typeof(Link_Patient_View));

            if (xUserType == typeof(Manager) || xUserType == typeof(Employee))
                AccessibleViews.Add(typeof(Patient_Information_View));

            if (xUserType == typeof(Manager) || xUserType == typeof(Employee))
                AccessibleViews.Add(typeof(Invoice_View));

            if (xUserType == typeof(Manager) || xUserType == typeof(Employee))
                AccessibleViews.Add(typeof(Sub_Payment_View));

            // Login view
            AccessibleViews.Add(typeof(Login_View));

            return AccessibleViews;
        }
        //


        //
        private void btnLogin_Click(object sender, EventArgs e)
        {
            int loginFound = -1;

            for (int i = 0; i < EmployeesLogins.Count; i++)
            {
                if (txtLogin.Text != EmployeesLogins[i].Item2.ToString())
                    continue;

                loginFound = i;

                if (txtPassword.Text != EmployeesLogins[i].Item3)
                    continue;

                // Adding accessible Forms for a user
                List<Type> AccessibleViews = FetchAccessibleViews(EmployeesLogins[i].Item1.GetType());

                // Accessing the main form and telling it what to do.
                // Reference: https://social.msdn.microsoft.com/Forums/en-US/99df9c07-c117-465a-9207-fa3534982021/how-to-get-the-mainform-reference?forum=winforms
                ((Main_Form)this.Parent).SetSideBar(ref SD, AccessibleViews, EmployeesLogins[i].Item1);

                LoginButton_Click?.Invoke(this, e);

                this.Dispose();
                return;
            }

            if (loginFound == -1)
            {
                SendStatusUpdate(false);
                txtLogin.Focus();
            }
            else
            {
                SendStatusUpdate(true, "User found with name " + EmployeesLogins[loginFound].Item1.GetName() + " " + EmployeesLogins[loginFound].Item1.GetLast_Name(), "success");
                txtPassword.Focus();
            }
        }

        private void btnNewMain_Click(object sender, EventArgs e)
        {
            Main_Form M = new Main_Form(ref SD);
            M.Show();
        }
    }
}