using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Rescue_911
{
    public class Shared_Data
    {

        public Form[,] OpenForms;
        public Response_Team[] ResponseTeams;
        public List<Emergency> Emergencies = new List<Emergency>();
        public List<Emergency_Call> Calls = new List<Emergency_Call>();
        public List<patient> patients = new List<patient>();
        public List<EMT> EMTs = new List<EMT>();

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
            ResponseTeams[0].SetGrade(1);
            ResponseTeams[0].SetShift("somewhen...");
            ResponseTeams[1] = new Response_Team();
            ResponseTeams[1].SetID(2);
            ResponseTeams[1].SetGrade(3);
            ResponseTeams[1].SetShift("it happens...");
            ResponseTeams[2] = new Response_Team();
            ResponseTeams[2].SetID(3);
            ResponseTeams[2].SetGrade(2);
            ResponseTeams[2].SetShift("they work...");
            //

            patients.Add(new patient());
            patients[0].setage("14");
            patients[0].setbd("13 feb");
            patients[0].setbloodtype("o");
            patients[0].setcomplication("Losed Blood");
            patients[0].SetName("calven");
            patients[0].SetLast_Name("UV");
            patients.Add(new patient());
            patients[1].setage("20");
            patients[1].setbd("13 feb");
            patients[1].setbloodtype("o");
            patients[1].setcomplication("In pain ");
            patients[1].SetName("John");
            patients[1].SetLast_Name("Smith");



            EMTs = LoadEMTs();
            // EMERGENCY TEST DATA 
            Caller[] Callers = LoadCallers();
            Emergency_Call[] ECs = LoadEC(Callers);

            for (int i = 0; i < 3; i++)
            {
                Emergencies.Add(new Emergency());
            }

            Emergencies[0].AddLinked_Call(ECs[0]);
            Emergencies[0].AddLinked_Call(ECs[3]);
            Emergencies[0].SetEmergency_ID(0);

            Emergencies[1].AddLinked_Call(ECs[1]);
            Emergencies[1].SetEmergency_ID(1);

            Emergencies[2].AddLinked_Call(ECs[2]);
            Emergencies[2].SetEmergency_ID(2);
            //

            // CALLS TEST DATA
            for (int i = 0; i < ECs.Length; i++)
            {
                Calls.Add(ECs[i]);
            }        
            //
        }
        
        private List<EMT> LoadEMTs()
        {
            List<EMT> xEMTs = new List<EMT>();
            xEMTs.Add(new EMT());
            xEMTs[0].SetName("Jane");
            xEMTs[0].SetPassword("qwerty");
            xEMTs[0].SetEmployee_ID(0);
            xEMTs[0].setResponseTeamID(1.ToString());
            xEMTs[0].setShifttime("15:00 PM");

            xEMTs.Add(new EMT());
            xEMTs[1].SetName("Tyler");
            xEMTs[1].SetPassword("123");
            xEMTs[1].SetEmployee_ID(1);
            xEMTs[1].setResponseTeamID(2.ToString());
            xEMTs[1].setShifttime("15:00 PM");

            xEMTs.Add(new EMT());
            xEMTs[2].SetName("John");
            xEMTs[2].SetPassword("john");
            xEMTs[2].SetEmployee_ID(2);
            xEMTs[2].setResponseTeamID(1.ToString());
            xEMTs[2].setShifttime("15:00 PM");

            xEMTs.Add(new EMT());
            xEMTs[3].SetName("Shawn");
            xEMTs[3].SetPassword("anything");
            xEMTs[3].SetEmployee_ID(3);
            xEMTs[3].setResponseTeamID(3.ToString());
            xEMTs[3].setShifttime("15:00 PM");

            return xEMTs;
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
            Emergency_Calls[0].SetAddress("102 N Chauncey Ave, West-Lafayette");
            Emergency_Calls[0].SetPriority(3);
            Emergency_Calls[0].SetDescription("The man got hit by a big snow flake.");
            Emergency_Calls[0].SetState("Logged");

            Emergency_Calls[1].SetDateTime(DateTime.Parse("10/23/2017 10:14:59 AM", System.Globalization.CultureInfo.InvariantCulture));
            Emergency_Calls[1].SetPriority(2);
            Emergency_Calls[1].SetAddress("1198 Third Street, West-Lafayette");
            Emergency_Calls[1].SetDescription("The man got attacked by a huge spider on his balcony.");
            Emergency_Calls[1].SetState("Logged");

            Emergency_Calls[2].SetDateTime(DateTime.Parse("10/23/2017 11:48:23 AM", System.Globalization.CultureInfo.InvariantCulture));
            Emergency_Calls[2].SetPriority(1);
            Emergency_Calls[2].SetAddress("600 E. Grand Avenue, Navy Pier, Chicago");
            Emergency_Calls[2].SetDescription("An incident regarding a banana slip.");
            Emergency_Calls[2].SetState("Logged");

            Emergency_Calls[3].SetDateTime(DateTime.Parse("10/23/2017 5:11:00 AM", System.Globalization.CultureInfo.InvariantCulture));
            Emergency_Calls[3].SetPriority(3);
            Emergency_Calls[3].SetAddress("1600 Amphitheatre Parkway, Mountain View");
            Emergency_Calls[3].SetDescription("The man was run over by a cyclist. Cyclyst needs help.");
            Emergency_Calls[3].SetState("Logged");

            return Emergency_Calls;
        }
    }
}