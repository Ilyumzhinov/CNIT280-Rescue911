using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Rescue_911
{
    public class Shared_Data
    {
        // DATA STRUCTURE
        //System data
        private Special_List<Main_Form> MainForms;
        public int FormsCount;

        //Common data
        private Special_List<Emergency_Call> Calls;
        private List<Emergency> Emergencies;
        private List<EMT> EMTs;
        private List<Response_Team> ResponseTeams;
        private List<Dispatch> Dispatches;
        private List<Patient> Patients;
        //

        public void UpdateSD(ref Shared_Data xSD)
        {
            Calls = xSD.GetCalls();
            Emergencies = xSD.GetEmergencies();
            EMTs = xSD.GetEMTs();
            ResponseTeams = xSD.GetResponseTeams();
            Dispatches = xSD.GetDispatches();
            Patients = xSD.GetPatients();
        }

        // To-Do: Delete sets
        public void AddMain_Form(Main_Form xForm)
        {
            MainForms.AddItem(xForm);
            FormsCount++;
        }
        public void SetResponseTeams(List<Response_Team> xRT) { ResponseTeams = xRT; }
        public void SetEmergencies(List<Emergency> xEmergencies) {  Emergencies = xEmergencies;}
        public void AddCall(Emergency_Call xCall)
        {
            Calls.AddItem(xCall);
        }
        public void SetEMTs(List<EMT> xEMTs) { EMTs = xEMTs; }
        public void SetPatients(List<Patient> xPatients) { Patients = xPatients; }
        public void AddDispatch(Dispatch xDispatch) {
            Dispatches.Add(xDispatch);
        }
        //

        public Special_List<Emergency_Call> GetCalls() { return Calls; }
        public List<Emergency> GetEmergencies() { return Emergencies; }
        public List<EMT> GetEMTs() { return EMTs; }
        public List<Response_Team> GetResponseTeams() { return ResponseTeams; }
        public List<Dispatch> GetDispatches() { return Dispatches; }
        public List<Patient> GetPatients() { return Patients; }
        public void RemoveMain_Form(Main_Form xForm)
        {
            MainForms.RemoveItem(xForm);
            FormsCount--;
        }

        public Shared_Data()
        {
            MainForms = new Special_List<Main_Form>();
            Calls = new Special_List<Emergency_Call>();
            
            Emergencies = new List<Emergency>();
            EMTs = new List<EMT>();
            ResponseTeams = new List<Response_Team>();
            Dispatches = new List<Dispatch>();
            Patients = new List<Patient>();

            // LOAD CALLERS
            List<Caller> Callers = LoadCallers();

            // LOAD RTs AND EMTs
            ResponseTeams = LoadRTs();
            EMTs = LoadEMTs();

            Patients.Add(new Patient());

            Patients[0].SetDOB("13 feb");
            Patients[0].setbloodtype("o");
            Patients[0].setcomplication("Losed Blood");
            Patients[0].SetName("Calven");
            Patients[0].SetLast_Name("Yuvenov");

            Patients.Add(new Patient());
            Patients[1].setbloodtype("o");
            Patients[1].setcomplication("In pain ");
            Patients[1].SetName("John");
            Patients[1].SetLast_Name("Smith");

            Patients.Add(new Patient());
            Patients[2].SetDOB("2 feb");
            Patients[2].setbloodtype("o");
            Patients[2].setcomplication("Losed Blood");
            Patients[2].SetName("kevin");
            Patients[2].SetLast_Name("zhang");

            Patients.Add(new Patient());
            Patients[3].SetDOB("13 feb");
            Patients[3].setbloodtype("o");
            Patients[3].setcomplication("Losed Blood");
            Patients[3].SetName("artem");
            Patients[3].SetLast_Name("sub");

            Patients.Add(new Patient());
            Patients[4].SetDOB("13 feb");
            Patients[4].setbloodtype("o");
            Patients[4].setcomplication("Losed Blood");
            Patients[4].SetName("jassica");
            Patients[4].SetLast_Name("kanban");

            Patients.Add(new Patient());
            Patients[5].SetDOB("13 feb");
            Patients[5].setbloodtype("o");
            Patients[5].setcomplication("Losed Blood");
            Patients[5].SetName("zoe");
            Patients[5].SetLast_Name("abbe");


            Emergencies = LoadEmergencies();

            Calls = LoadEC(Callers, Emergencies);
        }
        
        private List<Response_Team> LoadRTs()
        {
            List<Response_Team> xRTs = new List<Response_Team>();

            xRTs.Add(new Response_Team());
            xRTs[0].SetID(1);
            xRTs[0].SetGrade(1);
            xRTs[0].SetShift("somewhen...");

            xRTs.Add(new Response_Team());
            xRTs[1].SetID(2);
            xRTs[1].SetGrade(3);
            xRTs[1].SetShift("it happens...");

            xRTs.Add(new Response_Team());
            xRTs[2].SetID(3);
            xRTs[2].SetGrade(2);
            xRTs[2].SetShift("they work...");

            return xRTs;
        }

        private List<EMT> LoadEMTs()
        {
            List<EMT> xEMTs = new List<EMT>();
            xEMTs.Add(new EMT());
            xEMTs[0].SetName("Jane");
            xEMTs[0].SetPassword("qwerty");
            xEMTs[0].SetEmployee_ID(0);
            xEMTs[0].SetResponseTeam(ResponseTeams[0]);
            xEMTs[0].setShifttime("15:00 PM");

            xEMTs.Add(new EMT());
            xEMTs[1].SetName("Tyler");
            xEMTs[1].SetPassword("123");
            xEMTs[1].SetEmployee_ID(1);
            xEMTs[1].SetResponseTeam(ResponseTeams[2]);
            xEMTs[1].setShifttime("15:00 PM");

            xEMTs.Add(new EMT());
            xEMTs[2].SetName("John");
            xEMTs[2].SetPassword("john");
            xEMTs[2].SetEmployee_ID(2);
            xEMTs[2].SetResponseTeam(ResponseTeams[2]);
            xEMTs[2].setShifttime("15:00 PM");

            xEMTs.Add(new EMT());
            xEMTs[3].SetName("Shawn");
            xEMTs[3].SetPassword("111");
            xEMTs[3].SetEmployee_ID(3);
            xEMTs[3].SetResponseTeam(ResponseTeams[1]);
            xEMTs[3].setShifttime("15:00 PM");

            return xEMTs;
        }
       
        private List<Emergency> LoadEmergencies()
        {
            List<Emergency> xEmergencies = new List<Emergency>();

            for (int i = 0; i < 3; i++)
            {
                xEmergencies.Add(new Emergency());
            }

            xEmergencies[0].SetEmergency_ID(100);
            xEmergencies[0].SetEType("Broken bones");

            xEmergencies[1].SetEmergency_ID(101);
            xEmergencies[1].SetEType("Poison");

            xEmergencies[2].SetEmergency_ID(102);
            xEmergencies[2].SetEType("Broken bones");

            return xEmergencies;
        }


        private Special_List<Emergency_Call> LoadEC(List<Caller> xCallers, List<Emergency> xEmergencies)
        {
            // EMERGENCY CALLS TEST DATA
            Special_List<Emergency_Call> xECs = new Special_List<Emergency_Call>();

            for (int i = 0; i < 4; i++)
            {
                xECs.AddItem(new Emergency_Call());
                xECs[i].SetEmergency_Caller(xCallers[i]);
            }

            xECs[0].SetDateTime(DateTime.Parse("10/24/2017 7:10:24 AM", System.Globalization.CultureInfo.InvariantCulture));
            xECs[0].SetAddress("102 N Chauncey Ave, West-Lafayette");
            xECs[0].SetPriority(3);
            xECs[0].SetDescription("The man got hit by a big snow flake.");
            xECs[0].SetState("Logged");
            xECs[0].SetEmergency(xEmergencies[0]);

            xECs[1].SetDateTime(DateTime.Parse("10/23/2017 10:14:59 AM", System.Globalization.CultureInfo.InvariantCulture));
            xECs[1].SetPriority(2);
            xECs[1].SetAddress("1198 Third Street, West-Lafayette");
            xECs[1].SetDescription("The man got attacked by a huge spider on his balcony.");
            xECs[1].SetState("Logged");
            xECs[1].SetEmergency(xEmergencies[1]);

            xECs[2].SetDateTime(DateTime.Parse("10/23/2017 11:48:23 AM", System.Globalization.CultureInfo.InvariantCulture));
            xECs[2].SetPriority(1);
            xECs[2].SetAddress("600 E. Grand Avenue, Navy Pier, Chicago");
            xECs[2].SetDescription("An incident regarding a banana slip.");
            xECs[2].SetState("Logged");
            xECs[2].SetEmergency(xEmergencies[2]);

            xECs[3].SetDateTime(DateTime.Parse("10/23/2017 5:11:00 AM", System.Globalization.CultureInfo.InvariantCulture));
            xECs[3].SetPriority(3);
            xECs[3].SetAddress("1600 Amphitheatre Parkway, Mountain View");
            xECs[3].SetDescription("The man was run over by a cyclist. Cyclyst needs help.");
            xECs[3].SetState("Logged");
            xECs[3].SetEmergency(xEmergencies[0]);

            return xECs;
        }

        private List<Caller> LoadCallers()
        {
            // CALLERS TEST DATA
            List<Caller> ECallers = new List<Caller>();

            for (int i = 0; i < 4; i++)
            {
                ECallers.Add(new Caller());
            }

            ECallers[0].SetPhone_Number("1231231231");

            ECallers[1].SetPhone_Number("1231231231");

            ECallers[2].SetName("Jordan");
            ECallers[2].SetPhone_Number("1111111111");

            ECallers[3].SetName("Zeeshan");
            ECallers[3].SetPhone_Number("1234567890");

            return ECallers;
        }
    }

    public class Special_List<T> : List<T>
    {
        public event EventHandler ItemAdded;
        public event EventHandler ItemRemoved;

        public void AddItem(T item)
        {
            base.Add(item);

            ItemAdded?.Invoke(item, null);
        }

        public void RemoveItem(T item)
        {
            base.Remove(item);

            ItemRemoved?.Invoke(item, null);
        }

        public void RemoveItemAt(int index)
        {
            base.RemoveAt(index);

            ItemRemoved?.Invoke(index, null);
        }
    }
}