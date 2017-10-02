using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringLesson
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Hello World"; //anything between these quotation marks is a literal value.

            string str1 = new string('*', 20);//this will store 20 *s inside your string. (in memory: new is declared for Heap storage, string is stored in Stack). 
            //for a single quote '(thing)' you can only store one character (like a single *). 

            Console.WriteLine(str1);
            Console.WriteLine(str);

            for (int i = 1; i <= 10; i++) 
            {
                string str2 = new string('#', i);
                Console.WriteLine(str2);
            }

            int x = 10;

            string str3 = "You need to pay $" + x; //this is an implicit conversion, as no method executes the conversion for you. x is converted to a string in the line. 
        }
    }
}
