using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritenceTest
{
    class Instructor:Person
    {

        private string employeeID;
        private double salary;


        public string EmployeeID
        {
            set { employeeID = value; }
            get { return employeeID; }
        }

        public double Salary
        {
            set { salary = value; }
            get { return salary; }
        }


        public Instructor()
        {
            EmployeeID = "";
            Salary = 0;

        }

        public Instructor(string fname, string lname, string emplID, double slry)
        {
            EmployeeID = emplID;
            Salary = slry;
            FirstName = fname;
            LastName = lname;
        }

        public override void PrintInfo()
        {
            Console.WriteLine(FirstName + " " + LastName + ", PhD");
        }

    }
}
