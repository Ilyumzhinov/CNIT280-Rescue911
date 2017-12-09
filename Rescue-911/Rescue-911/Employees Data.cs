using System;
using System.Collections.Generic;

namespace Rescue_911
{
    class Employees_Data
    {
        // 0.Employee object,
        // 1.Employee_ID,
        // 2.Password.
        private Tuple<Employee, int, string>[] Operators;
        private Tuple<Employee, int, string>[] Supervisors;
        private Tuple<Employee, int, string>[] EMTs;
        private Tuple<Employee, int, string>[] Managers;
        private Tuple<Employee, int, string> FakeEmpoyee;
        //


        // CONSTRUCTOR
        public Employees_Data(ref Shared_Data xSD)
        {
            SetupOperators(xSD.GetOperators());
            SetupSupervisors(xSD.GetSupervisors());
            SetupEMTs(xSD.GetEMTs());
            SetupManagers(xSD.GetManagers());

            // TEST SUPER USER: FAKE EMPOYEE
            Employee fakePerson = new Employee();
            fakePerson.SetName("Fake");
            fakePerson.SetLast_Name("Employee");
            fakePerson.SetAddress("Cupertino, California");

            FakeEmpoyee = Tuple.Create(fakePerson, 666, string.Empty);
            //
        }
        //


        // PUBLIC METHODS
        public List<Tuple<Employee,int,string>> GetEmployeesLoginsPasswords()
        {
            List<Tuple<Employee, int, string>> Employees = new List<Tuple<Employee, int, string>>();

            Employees.AddRange(Operators);
            Employees.AddRange(Supervisors);
            Employees.AddRange(EMTs);
            Employees.AddRange(Managers);
            Employees.Add(FakeEmpoyee);

            return Employees;
        }
        //

        private void SetupOperators(List<Operator> Operators_Existing)
        {
            Operators = new Tuple<Employee, int, string>[2];

            // Leicester ID1
            Operators[0] = Tuple.Create((Employee)Operators_Existing[0], Operators_Existing[0].GetEmployee_ID(), "qwe");
            // Fredia ID2
            Operators[1] = Tuple.Create((Employee)Operators_Existing[1], Operators_Existing[1].GetEmployee_ID(), "asd");
        }

        private void SetupSupervisors(List<Supervisor> Supervisors_Existing)
        {
            Supervisors = new Tuple<Employee, int, string>[1];

            // Chalmers ID3
            Supervisors[0] = Tuple.Create((Employee)Supervisors_Existing[0], Supervisors_Existing[0].GetEmployee_ID(), "password");
        }

        private void SetupEMTs(List<EMT> EMTs_Existing)
        {
            EMTs = new Tuple<Employee, int, string>[50];

            //// Jane
            //EMTs[0] = Tuple.Create((Employee)EMTs_Existing[0], EMTs_Existing[0].GetEmployee_ID(), "qwerty");
            //// Tyler
            //EMTs[1] = Tuple.Create((Employee)EMTs_Existing[1], EMTs_Existing[1].GetEmployee_ID(), "123");
            //// John
            //EMTs[2] = Tuple.Create((Employee)EMTs_Existing[2], EMTs_Existing[2].GetEmployee_ID(), "john");
            //// Shawn
            //EMTs[3] = Tuple.Create((Employee)EMTs_Existing[3], EMTs_Existing[3].GetEmployee_ID(), "111");

            for (int a = 0; a < 50; a++) {
                EMTs[a] = Tuple.Create((Employee)EMTs_Existing[a], EMTs_Existing[a].GetEmployee_ID(), "a");
                
            }
        }

        private void SetupManagers(List<Manager> Managers_Existing)
        {
            Managers = new Tuple<Employee, int, string>[2];

            // Hughie
            Managers[0] = Tuple.Create((Employee)Managers_Existing[0], Managers_Existing[0].GetEmployee_ID(), "test");
            // Vaugh
            Managers[1] = Tuple.Create((Employee)Managers_Existing[1], Managers_Existing[1].GetEmployee_ID(), "?");
        }
    }
}