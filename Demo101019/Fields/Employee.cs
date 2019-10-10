using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fields
{
    class Employee
    {
        // fields
        private string empName;
        private int empID;
        private double currPay;

        // accessor and mutator methods
        public string GetName() {return empName; }
        public int GetEmpID() { return empID; }
        public double GetCurryId() { return currPay; }

        public void SetName(string name)
        {
            // perform validation
            if (name.Length > 15) { empName = name.Substring(0, 15); }
            else empName = name;
        }
        public void SetEmpID(int id) { empID = id; }
        public void SetCurrPay(double pay) { currPay = pay; }

        //methods
        public void PrintState()
        {
            Console.WriteLine("Name:\t{0}", empName);
            Console.WriteLine("ID:\t{0}", empID);
            Console.WriteLine("Pay:\t{0}", currPay);
        }

    }
}
