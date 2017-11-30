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
using Oracle.DataAccess.Client;

namespace Rescue_911
{
    public partial class Main_View : Special_View
    {
        // CONSTRUCTORS
        //To-display the view.
        public Main_View(ref Shared_Data xSD) : base(
            ref xSD, 
            "Main Page", 
            false, 
            Color.Black,
            DateTime.Today.DayOfWeek.ToString() + ", " + DateTime.Today.ToString("MMMM d")
            )
        {
            InitializeComponent();

            lbTime.Text = DateTime.Now.ToString("h:mm:ss MM/dd/yyyy");
            lbUsers.Text = SD.FormsCount.ToString();

            // TEST DATABASE CONNECTION
           // OleDbConnection cn = new OleDbConnection("DATA SOURCE=oracle.ecn.purdue.edu:1521/master.ecn.purdue.edu;PASSWORD=group1814;USER ID=RESCUE911DB");
            //cn.Open();
            OracleConnection cmd1 = new OracleConnection();
            cmd1.ConnectionString = "Data Source= oracle.ecn.purdue.edu:1521/master.ecn.purdue.edu;" +
                "User Id=rescue911db;" +
                "Password = group1814;";
            cmd1.Open();

            OracleCommand command = cmd1.CreateCommand();
            command.CommandText = "desc Operator; ";
            //OracleDataReader odr = command.ExecuteReader();

            //lbDevelopers.Text = (string)odr[0];

            //

        }
    }
}
