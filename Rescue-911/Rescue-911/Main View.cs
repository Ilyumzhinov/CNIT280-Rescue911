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

        // CONSTRUCTORS
        //To-setup the view.
        public Main_View(bool toDisplay, ref int xFormsCount) : this(toDisplay)
        {
            FormsCount = xFormsCount;

            lbTime.Text = DateTime.Now.ToString("h:mm:ss MM/dd/yyyy");
            lbUsers.Text = FormsCount.ToString();

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
    public Main_View(bool toDisplay) : base( toDisplay, false )
        {
            if (toDisplay)
                InitializeComponent();

            SetDesc(DateTime.Today.DayOfWeek.ToString() + ", " + DateTime.Today.ToString("MMMM d"));
        }
    }
}
