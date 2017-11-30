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
        private Tuple<Employee, int, string> FakeEmpoyee;
        //


        // CONSTRUCTOR
        public Employees_Data(ref Shared_Data xSD)
        {
            SetupOperators(xSD.GetOperators());
            SetupSupervisors(xSD.GetSupervisors());
            SetupEMTs(xSD.GetEMTs());

            // TEST SUPER USER: FAKE EMPOYEE
            Employee fakePerson = new Employee();
            fakePerson.SetName("Fake");
            fakePerson.SetLast_Name("Employee");
            fakePerson.SetAddress("Cupertino, California");

            //FakeEmpoyee = new Tuple<Employee, int, string>();
            FakeEmpoyee = Tuple.Create(fakePerson, 666, string.Empty);
            //
        }
        //


        // PUBLIC METHODS
        public List<Tuple<Employee,int,string>> GetEmployeesLoginsPasswords()
        {
            List<Tuple<Employee, int, string>> Employees = new List<Tuple<Employee, int, string>>(); // = new Tuple<Employee, int, string>[8];

            Employees.AddRange(Operators);
            Employees.AddRange(Supervisors);
            Employees.AddRange(EMTs);
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
            EMTs = new Tuple<Employee, int, string>[4];

            // Jane
            EMTs[0] = Tuple.Create((Employee)EMTs_Existing[0], EMTs_Existing[0].GetEmployee_ID(), "qwerty");
            // Tyler
            EMTs[1] = Tuple.Create((Employee)EMTs_Existing[1], EMTs_Existing[1].GetEmployee_ID(), "123");
            // John
            EMTs[2] = Tuple.Create((Employee)EMTs_Existing[2], EMTs_Existing[2].GetEmployee_ID(), "john");
            // Shawn
            EMTs[3] = Tuple.Create((Employee)EMTs_Existing[3], EMTs_Existing[3].GetEmployee_ID(), "111");
        }
    }
}