using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritenceTest
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Notes
            //Console.WriteLine("Please enter the student information:");
            //Student Irvin = new Student();
            //Console.WriteLine("Student First Name");
            //Irvin.FirstName = Console.ReadLine();
            //Console.WriteLine("Student Last Name:");
            //Irvin.LastName = Console.ReadLine();
            //Console.WriteLine("Student Major:");
            //Irvin.Major = Console.ReadLine();
            //Console.WriteLine("Student Date of Birth");
            //Irvin.DOB = DateTime.Parse(Console.ReadLine());

            //Instructor DrK = new Instructor();

            //Console.WriteLine("Please enter the Professor information:");
            //Console.WriteLine("Professor First Name:");
            //DrK.FirstName = Console.ReadLine();
            //Console.WriteLine("Professor Last Name:");
            //DrK.LastName = Console.ReadLine();
            //Console.WriteLine("Professor Date of Birth:");
            //DrK.DOB = DateTime.Parse(Console.ReadLine());
            //Console.WriteLine("Professor Employee ID:");
            //DrK.EmployeeID = Console.ReadLine();
            //Console.WriteLine("Professor Salary:");
            //DrK.Salary = double.Parse(Console.ReadLine());

            //Student Irvin = new Student();

            //Person P1 = new Person();

            //P1. //you are prompted for items like Equals, ToString, GetHasttable. These are part of the object. Classes are a part of objects!
            //any class that is marked as a sealed class cannot be inhereted

            //View --> Class View will show you the base types and inhereted classes. 
            //You can also view in Solution Explorer, by going to Program, Add New Item,
            #endregion

            Person P1 = new Person("John", "Doe", new DateTime(1982, 04, 12));

            Person P2 = new Person("Mary", "Jane", new DateTime(1980, 02, 20));

            Person P3 = new Person("Justin", "Fredricks", new DateTime(1991, 12, 25));

            Student S1 = new Student("Josh", "Jameson", "34243423", "Art");

            Student S2 = new Student("Jenna", "Anne", "89765253", "Mathematics");

            Instructor r1 = new Instructor("Davy", "Jones", "434", 70000);

            Instructor r2 = new Instructor("Jack", "Sparrow", "567", 100000);

            //Person[] UniversityList = new Person[7]; //7 persons total ^

            List<Person> UniversityList = new List<Person>();

            UniversityList.Add(P1);
            UniversityList.Add(P2);
            UniversityList.Add(P3);
            UniversityList.Add(S1);
            UniversityList.Add(S2);
            UniversityList.Add(r1); //Override operation will change behavior of inherited methods. 
            UniversityList.Add(r2); //Instructor and Student are viewed as "Person" inside this array because of Polymorphism

            for (int i = 0; i < UniversityList.Count; i++)
            {
                UniversityList[i].PrintInfo(); //even if we change to List, we can still use the index here as if it were in array
            }
            //int index = int.Parse(Console.ReadLine());
            //UniversityList.Remove(index); //remove car object from (array) List!
        }
    }
}
