using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
//using Oracle.DataAccess.Client;

namespace Rescue_911
{
    public partial class Main_View : Special_View
    {
        private int FormsCount;
        private Special_List<Patient> Patients;
        Special_List<Emergency_Call> ECs;
        Special_List<Response_Team> RTs;

        // CONSTRUCTORS
        //To-setup the view.
        public Main_View(bool toDisplay, ref int xFormsCount, ref Special_List<Patient> xPatients, ref Special_List<Emergency_Call> xECs, ref Special_List<Response_Team> xRTs) : this(toDisplay)
        {
            FormsCount = xFormsCount;
            Patients = xPatients;
            Patients.ItemAdded += new EventHandler(GeneratePanels);
            Patients.ItemRemoved += new EventHandler(GeneratePanels);
            ECs = xECs;
            ECs.ItemAdded += new EventHandler(GeneratePanels);
            ECs.ItemRemoved += new EventHandler(GeneratePanels);
            RTs = xRTs;
            RTs.ItemAdded += new EventHandler(GeneratePanels);
            RTs.ItemRemoved += new EventHandler(GeneratePanels);

            GeneratePanels(null, null);

            SendStatusUpdate(true, "Logged in");


            // TEST DATABASE CONNECTION
            // OleDbConnection cn = new OleDbConnection("DATA SOURCE=oracle.ecn.purdue.edu:1521/master.ecn.purdue.edu;PASSWORD=group1814;USER ID=RESCUE911DB");
            //cn.Open();
            //   OracleConnection cmd1 = new OracleConnection();
            //   cmd1.ConnectionString = "Data Source= oracle.ecn.purdue.edu:1521/master.ecn.purdue.edu;" +
            //        "User Id=rescue911db;" +
            //         "Password = group1814;";
            //   cmd1.Open();

            //  OracleCommand command = cmd1.CreateCommand();
            //   command.CommandText = "desc Operator; ";
            //OracleDataReader odr = command.ExecuteReader();

            //lbDevelopers.Text = (string)odr[0];

            //

        }

        //To-display the view.
        public Main_View(bool toDisplay) : base(toDisplay, false)
        {
            InitializeComponent();

            SetDesc(DateTime.Today.DayOfWeek.ToString() + ", " + DateTime.Today.ToString("MMMM d"));
        }

        public void GeneratePanels(object sender, EventArgs e)
        {
            specialPanel.Number = FormsCount.ToString();

            specialPanelPatients.Number = Patients.Count.ToString();
            specialPanelEC.Number = ECs.Count.ToString();

            int temp =0;
            foreach (Response_Team iRt in RTs)
            {
                if (iRt.GetTeamstatus() == "Available")
                    temp++;
            }

            specialPanelActiveRTs.Number = temp.ToString();          
        }
    }
}
