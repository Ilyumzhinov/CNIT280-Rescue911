using System;
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
        private Special_List<Emergency> Emergencies;
        private Special_List<Response_Team> ResponseTeams;
        private Special_List<Dispatch> Dispatches;
        private Special_List<Dispatch_Report> DispatchReports;
        private Special_List<BaseStation> BaseStations;
        private Special_List<Base_Station_Records> BaseStationRecords;

        //People
        private Special_List<Caller> Callers;
        private Special_List<Patient> Patients;

        //Employees
        private Special_List<Operator> Operators;
        private Special_List<Supervisor> Supervisors;
        private Special_List<EMT> EMTs;
        private Special_List<Manager> Managers;
        //


        public void UpdateSD(ref Shared_Data xSD)
        {
            Calls = xSD.GetCalls();
            Emergencies = xSD.GetEmergencies();
            EMTs = xSD.GetEMTs();
            ResponseTeams = xSD.GetResponseTeams();
            Dispatches = xSD.GetDispatches();
            DispatchReports = xSD.GetDispatchReports();
            BaseStationRecords = xSD.GetBaseStationRecords();
            Patients = xSD.GetPatients();
            Managers = xSD.GetManagers();
        }

        // To-Do: Delete sets
        public void AddMain_Form(Main_Form xForm)
        {
            MainForms.AddItem(xForm);
            FormsCount++;
        }
        public void AddCall(Emergency_Call xCall)
        {
            Calls.AddItem(xCall);
        }
        public void AddDispatch(Dispatch xDispatch) {
            Dispatches.Add(xDispatch);
        }
        public void AddDispatchReport(Dispatch_Report xDR)
        {
            DispatchReports.Add(xDR);
        }

        public void AddBaseStationRecords(Base_Station_Records xBR)
        {
            BaseStationRecords.Add(xBR);
        }
        //

        public Special_List<Emergency_Call> GetCalls() { return Calls; }
        public Special_List<Emergency> GetEmergencies() { return Emergencies; }
        public Special_List<Operator> GetOperators() { return Operators; }
        public Special_List<Supervisor> GetSupervisors() { return Supervisors; }
        public Special_List<EMT> GetEMTs() { return EMTs; }
        public Special_List<Response_Team> GetResponseTeams() { return ResponseTeams; }
        public Special_List<Dispatch> GetDispatches() { return Dispatches; }
        public Special_List<Dispatch_Report> GetDispatchReports() { return DispatchReports; }
        public Special_List<BaseStation> GetBase_Stations() { return BaseStations; }
        public Special_List<Base_Station_Records> GetBaseStationRecords() { return BaseStationRecords; }

        public Special_List<Caller> GetCallers() { return Callers; }
        public Special_List<Patient> GetPatients() { return Patients; }
        public Special_List<Manager> GetManagers() { return Managers; }
        public void RemoveMain_Form(Main_Form xForm)
        {
            MainForms.RemoveItem(xForm);
            FormsCount--;
        }

        public Shared_Data()
        {
            MainForms = new Special_List<Main_Form>();
            Calls = new Special_List<Emergency_Call>();
            DispatchReports = new Special_List<Dispatch_Report>();
            BaseStationRecords = new Special_List<Base_Station_Records>();


            Emergencies = new Special_List<Emergency>();
            EMTs = new Special_List<EMT>();
            ResponseTeams = new Special_List<Response_Team>();
            Dispatches = new Special_List<Dispatch>();
            Patients = new Special_List<Patient>();
            Managers = new Special_List<Manager>();

            // LOAD PATIENTS
            Patients = LoadPatients();

            // LOAD CALLERS
            Callers = LoadCallers(ref Patients);



            // LOAD OPERATORs, SUPERVISORs AND MANAGERs
            Operators = LoadOperators();
            Supervisors = LoadSupervisors();
            Managers = LoadManagers();

            // LOAD EMERGENCIES AND CALLs
            Emergencies = LoadEmergencies();
            Calls = LoadEC(Callers, Emergencies);
            BaseStations = LoadBSs();


            // LOAD RTs AND EMTs
            ResponseTeams = LoadRTs(BaseStations);
            EMTs = LoadEMTs();
        }
        
        private Special_List<Operator> LoadOperators()
        {
            Special_List<Operator> xOperators = new Special_List<Operator>();
            xOperators.Add(new Operator());
            xOperators[0].SetEmployee_ID(1);
            xOperators[0].SetName("Leicester");
            xOperators[0].SetLast_Name("Bosdet");
            xOperators[0].SetManager_ID(9);
            xOperators[0].SetOperator_ID(10);

            xOperators.Add(new Operator());
            xOperators[1].SetEmployee_ID(2);
            xOperators[1].SetName("Fredia");
            xOperators[1].SetLast_Name("Chessill");
            xOperators[1].SetManager_ID(9);
            xOperators[1].SetOperator_ID(11);

            return xOperators;
        }

        private Special_List<Supervisor> LoadSupervisors()
        {
            Special_List<Supervisor> xSupervisors = new Special_List<Supervisor>();

            xSupervisors.Add(new Supervisor());
            xSupervisors[0].SetEmployee_ID(3);
            xSupervisors[0].SetName("Chalmers");
            xSupervisors[0].SetLast_Name("Gatecliff");
            xSupervisors[0].SetManager_ID(9);
            xSupervisors[0].SetOperator_ID(12);

            return xSupervisors;
        }

        private Special_List<Manager> LoadManagers()
        {
            Special_List<Manager> xManagers = new Special_List<Manager>();
            xManagers.Add(new Manager());
            xManagers[0].SetEmployee_ID(9);
            xManagers[0].SetName("Hughie");
            xManagers[0].SetLast_Name("Diamant");

            xManagers.Add(new Manager());
            xManagers[1].SetEmployee_ID(10);
            xManagers[1].SetName("Vaugh");
            xManagers[1].SetLast_Name("Stairs");

            return xManagers;
        }

        private Special_List<BaseStation> LoadBSs()
        {
            Special_List<BaseStation> xBSs = new Special_List<BaseStation>();

            for (int i = 0; i < 3; i++)
            {
                xBSs.Add(new BaseStation());
            }

            xBSs[0].SetBS_ID(1);
            xBSs[0].SetBS_Name("Michaela");
            xBSs[0].SetBS_Location("259 Lighthouse Bay Center");

            xBSs[1].SetBS_ID(2);
            xBSs[1].SetBS_Name("Wenda");
            xBSs[1].SetBS_Location("18 Stephen Court");

            xBSs[2].SetBS_ID(3);
            xBSs[2].SetBS_Name("Corenda");
            xBSs[2].SetBS_Location("28528 Chive Drive");

            return xBSs;
        }

        private Special_List<Response_Team> LoadRTs(Special_List<BaseStation> xBSs)
        {
            Special_List<Response_Team> xRTs = new Special_List<Response_Team>();

            Random rnd = new Random();

            for (int a = 0; a < 15; a++) {
                xRTs.Add(new Response_Team());
                xRTs[a].SetID(10+a);
                if (a <=3) { xRTs[a].SetGrade(1); }
                else if (a > 3 && a <= 6) { xRTs[a].SetGrade(2); }
                else if (a > 6 && a < 15) { xRTs[a].SetGrade(3); }
                xRTs[a].SetShift("they work...");

                xRTs[a].SetBaseStation(xBSs[rnd.Next(3)]);
            }
            return xRTs;
        }

        private Special_List<EMT> LoadEMTs()
        {
            Special_List<EMT> xEMTs = new Special_List<EMT>();
            int temp = 0;
            int temp2 = 0;
            for (int a = 0; a < 50; a++)
            {

                xEMTs.Add(new EMT());
                xEMTs[a].SetName("EMT" + a);
                xEMTs[a].SetEmployee_ID(11 + a);
                if (temp > 4) { temp = 0;temp2++; }

                if (temp == 0)
                    {
                    xEMTs[a].SetResponseTeam(ResponseTeams[temp2]);
                    xEMTs[a].SetTeamnumber(temp);
                    temp++;
                    }else{
                     xEMTs[a].SetResponseTeam(ResponseTeams[temp2]);
                     xEMTs[a].SetTeamnumber(temp);
                     temp++;
                }
             

                if (a < 15)
                {
                    xEMTs[a].setShifttime("15:00");
                    xEMTs[a].SetManager_ID(9);
                }
                else if (a >= 15 && a < 30)
                {
                    xEMTs[a].setShifttime("23:00");
                    xEMTs[a].SetManager_ID(10);
                }
                else if (a >= 30)
                {
                    xEMTs[a].setShifttime("7:00");
                    xEMTs[a].SetManager_ID(11);
                }
                
            }
           
            return xEMTs;
        }
       
        private Special_List<Emergency> LoadEmergencies()
        {
            Special_List<Emergency> xEmergencies = new Special_List<Emergency>();

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


        private Special_List<Emergency_Call> LoadEC(Special_List<Caller> xCallers, Special_List<Emergency> xEmergencies)
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

        private Special_List<Caller> LoadCallers(ref Special_List<Patient> xPatients)
        {
            // CALLERS TEST DATA
            Special_List<Caller> ECallers = new Special_List<Caller>();

            for (int i = 0; i < 8; i++)
            {
                ECallers.AddItem(new Caller());
            }

            ECallers[2].SetName("Jordan");
            ECallers[2].SetPhone_Number("1111111111");

            ECallers[3].SetName("Zeeshan");
            ECallers[3].SetPhone_Number("1234567890");

            ECallers[0].SetPhone_Number("1231231231");
            ECallers[0].SetPatient(xPatients[0]);

            ECallers[1].SetPhone_Number("3213213211");
            ECallers[1].SetPatient(xPatients[2]);

            ECallers[5].SetPhone_Number("7655864179");
            ECallers[5].SetPatient(xPatients[1]);

            ECallers[4].SetPhone_Number("7655868686");
            ECallers[4].SetPatient(xPatients[3]);

            ECallers[6].SetPhone_Number("7655864179");
            ECallers[6].SetPatient(xPatients[4]);

            ECallers[7].SetPhone_Number("7659079894");
            ECallers[7].SetPatient(xPatients[5]);

            return ECallers;
        }

        private Special_List<Patient> LoadPatients()
        {
            Special_List<Patient> xPatients = new Special_List<Patient>();

            xPatients.Add(new Patient());

            xPatients[0].SetDOB("13 feb");
            xPatients[0].setbloodtype("o");
            xPatients[0].setcomplication("Losed Blood");
            xPatients[0].SetName("Calven");
            xPatients[0].SetLast_Name("Yuvenov");

            xPatients.Add(new Patient());
            xPatients[1].setbloodtype("o");
            xPatients[1].setcomplication("In pain ");
            xPatients[1].SetName("John");
            xPatients[1].SetLast_Name("Smith");

            xPatients.Add(new Patient());
            xPatients[2].SetDOB("2 feb");
            xPatients[2].setbloodtype("o");
            xPatients[2].setcomplication("Losed Blood");
            xPatients[2].SetName("kevin");
            xPatients[2].SetLast_Name("zhang");

            xPatients.Add(new Patient());
            xPatients[3].SetDOB("13 feb");
            xPatients[3].setbloodtype("o");
            xPatients[3].setcomplication("Losed Blood");
            xPatients[3].SetName("artem");
            xPatients[3].SetLast_Name("sub");

            xPatients.Add(new Patient());
            xPatients[4].SetDOB("13 feb");
            xPatients[4].setbloodtype("o");
            xPatients[4].setcomplication("Losed Blood");
            xPatients[4].SetName("jassica");
            xPatients[4].SetLast_Name("kanban");

            xPatients.Add(new Patient());
            xPatients[5].SetDOB("13 feb");
            xPatients[5].setbloodtype("o");
            xPatients[5].setcomplication("Losed Blood");
            xPatients[5].SetName("zoe");
            xPatients[5].SetLast_Name("abbe");

            return xPatients;
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