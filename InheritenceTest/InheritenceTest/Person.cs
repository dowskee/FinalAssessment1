using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritenceTest
{
    class Person
    {
        #region Variables
        private string firstname;
        private string lastname;
        private DateTime dob;
        #endregion

        #region Properties 
        public string FirstName
        //do vaidation here. Use a try/catch or throw exception to prevent someone from hacking the code
        {
            set { firstname = value; }
            get { return firstname; }
        }

        public string LastName
        {
            set { lastname = value; }
            get { return lastname; }
        }

        public DateTime DOB
        {
            set { dob = value; }
            get { return dob; }
        }

        #endregion

        #region Constructors
        public Person() //constructor base
        {
            FirstName = "";
            LastName = "";
            DOB = DateTime.Now;
        }

        public Person(string fname, string lname, DateTime Dateofbirth) //constructor value
        {
            FirstName = fname;//use the property (upper case) instead to ensure validation is being exectued. Otherwise (with variables), 
            //this will create a back door around validation, leaving room for bugs
            LastName = lname;
            DOB = Dateofbirth;
        }
        #endregion

        public virtual void PrintInfo()
        {
            Console.WriteLine(FirstName+" "+LastName); //property (capitalized)

            //to enable method override, we must go to the top, in our Person class. 
            //if the method is defined as virtual, you can override it

        }
    }
}
