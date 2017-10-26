using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Rescue_911
{
    public class Shared_Data
    {

        public Form[,] OpenForms;
        public Response_Team[] ResponseTeams;
        public Emergency[] Emergencies;
        public Emergency_Call[] Calls;

        public Shared_Data()
        {
            //
            // 0 dimension: Call Waiting Forms.
            // 1 dimension: Receive Call Form.
            // 2 dimension: Main form.
            OpenForms = new Form[99, 99];
            //

            // RT TEST DATA
            ResponseTeams = new Response_Team[3];
            ResponseTeams[0] = new Response_Team();
            ResponseTeams[0].SetID(1);
            ResponseTeams[0].SetGrade('1');
            ResponseTeams[0].SetShift("somewhen...");
            ResponseTeams[1] = new Response_Team();
            ResponseTeams[1].SetID(2);
            ResponseTeams[1].SetGrade('3');
            ResponseTeams[1].SetShift("it happens...");
            ResponseTeams[2] = new Response_Team();
            ResponseTeams[2].SetID(3);
            ResponseTeams[2].SetGrade('2');
            ResponseTeams[2].SetShift("they work...");
            //

            // EMERGENCY TEST DATA 
            Caller[] Callers = LoadCallers();
            Emergency_Call[] ECs = LoadEC(Callers);


            Emergencies = new Emergency[99];
            for (int i = 0; i < 3; i++)
            {
                Emergencies[i] = new Emergency();
            }

            Emergencies[0].SetLinked_Calls(new Emergency_Call[2] { ECs[0], ECs[3] });
            Emergencies[0].SetEmergency_ID(0);
            Emergencies[1].SetLinked_Calls(new Emergency_Call[1] { ECs[1] });
            Emergencies[1].SetEmergency_ID(1);
            Emergencies[2].SetLinked_Calls(new Emergency_Call[1] { ECs[2] });
            Emergencies[2].SetEmergency_ID(2);
            //

            // CALLS TEST DATA
            Calls = new Emergency_Call[99];

            for (int i = 0; i < ECs.Length; i++)
            {
                Calls[i] = ECs[i];
            }        
            //
        }

        private Caller[] LoadCallers()
        {
            // CALLERS TEST DATA
            Caller[] ECallers = new Caller[4];

            for (int i = 0; i < ECallers.Length; i++)
            {
                ECallers[i] = new Caller();
                ECallers[i].SetCaller_ID(i);
            }

            ECallers[0].SetName("Artem");
            ECallers[0].SetLast_Name("Ilyumzhinov");
            ECallers[0].SetPhone_Number("1231231231");
            ECallers[0].SetAddress("102 N Chauncey Ave, West-Lafayette");

            ECallers[1].SetName("Kevin");
            ECallers[1].SetLast_Name("Zhang");
            ECallers[1].SetPhone_Number("1231231231");
            ECallers[1].SetAddress("1198 Third Street, West-Lafayette");

            ECallers[2].SetName("Jordan");
            ECallers[2].SetLast_Name("Sexton");
            ECallers[2].SetPhone_Number("1111111111");
            ECallers[2].SetAddress("600 E. Grand Avenue, Navy Pier, Chicago");

            ECallers[3].SetName("Zeeshan");
            ECallers[3].SetLast_Name("Khalib");
            ECallers[3].SetPhone_Number("1234567890");
            ECallers[3].SetAddress("1600 Amphitheatre Parkway, Mountain View");

            return ECallers;
        }

        private Emergency_Call[] LoadEC(Caller[] xCallers)
        {
            // EMERGENCY CALLS TEST DATA
            Emergency_Call[] Emergency_Calls = new Emergency_Call[4];

            for (int i = 0; i < Emergency_Calls.Length; i++)
            {
                Emergency_Calls[i] = new Emergency_Call();
                Emergency_Calls[i].SetEmergency_Caller(xCallers[i]);
            }

            Emergency_Calls[0].SetDateTime(DateTime.Parse("10/24/2017 7:10:24 AM", System.Globalization.CultureInfo.InvariantCulture));
            Emergency_Calls[0].SetDescription("The man got hit by a big snow flake.");
            Emergency_Calls[0].SetState("Logged");

            Emergency_Calls[1].SetDateTime(DateTime.Parse("10/23/2017 10:14:59 AM", System.Globalization.CultureInfo.InvariantCulture));
            Emergency_Calls[1].SetDescription("The man got attacked by a huge spider on his balcony.");
            Emergency_Calls[1].SetState("Logged");

            Emergency_Calls[2].SetDateTime(DateTime.Parse("10/23/2017 11:48:23 AM", System.Globalization.CultureInfo.InvariantCulture));
            Emergency_Calls[2].SetDescription("An incident regarding a banana slip.");
            Emergency_Calls[2].SetState("Logged");

            Emergency_Calls[3].SetDateTime(DateTime.Parse("10/23/2017 5:11:00 AM", System.Globalization.CultureInfo.InvariantCulture));
            Emergency_Calls[3].SetDescription("The man was run over by a cyclist. Cyclyst needs help.");
            Emergency_Calls[3].SetState("Logged");

            return Emergency_Calls;
        }
    }
}