using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeIDClass
{
    class EmplID
    {
        private string name;
        private double salary;
        private string id;

        public string Name
        {
            set { name = value; }

            get { return name; }

        }

        public double Salary
        {
            set { salary = value; }
            get { return salary; }
        }

        public string ID
        {
            set { id = value; }
            get { return id; }
        }

        public void PrintEmployeeInfo()
        {
            Console.WriteLine($"Employee ID: {ID} Employee Name: {Name} Employee Salary: {Salary}");
        }
    }
}
