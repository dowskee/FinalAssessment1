using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritenceTest
{
    class Student:Person
    {
        #region Variables
        private string studentID;
        private string major;
        #endregion

        #region Properties
        public string StudentID
        {
            set { studentID = value; }
            get { return studentID; }
        }

        public string Major
        {
            set { major = value; }
            get { return major; }
        }
        #endregion

        #region Constructors 

        public Student()
        {
            StudentID = "";
            Major = "";

        }

        public Student(string fname, string lname, string stdID, string mjr)
        {
            StudentID = stdID;
            Major = mjr;
            FirstName = fname;
            LastName = lname;

        }
        #endregion
        public override void PrintInfo()
        {
            Console.WriteLine(FirstName+" "+LastName+", "+Major);
        }

    }
}
