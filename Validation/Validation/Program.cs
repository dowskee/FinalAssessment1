using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Validation
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                int Input = ReadValidInteger();

                int Input2 = ReadValidInteger();

                Console.WriteLine(Input / Input2);
            }

            catch (DivideByZeroException er) //variable er needs to be defined so it can be referenced with StackTrace
            //even in simple programs, a catch is a good idea. Especially if you are connecting to an API or 
            //something out of your control. 
            {
                Console.WriteLine("You have an error. Don't divide by zero!");
                //save the error message on a file, or send via the web to the programmer

                //if you reach the catch statement, it will sotre the information for you (in Heap). Now, anything related
                //to the problem can be stored in the er (or error) in stack, which will reference Heap in memory. 
                Console.WriteLine(er.StackTrace); //error memory storage traced to heap from stack
            }
             catch (Exception er) //generic Exception to catch any other errors can be stated
            {
                Console.WriteLine("Error. Please see your administrator");
                Console.WriteLine(er.StackTrace);
            }
            //how would you validate an email?

            //Regex (regular expressions) 
            //search for regular expression for email in c# and you will find the answer. 
            // @"^([\w\.\-]+) @ ([\W\-]+)((\.(\w){2,3})+)$" will check if the first part of email (someone's name, for example), contains
            //letters (\w\), and punctuation limited to . or - (\.\-). Then it will be separated by an @ sign, then the next string for 
            //the domain, which can only contain letters and the - sign (/w/-), the finally followed by the .com/.edu/.net etc, which can
            //also only include letters (\w), and be only 2 to 3 characters long. 

            //string email = Console.ReadLine();
            //Regex regex = new Regex (@"^([\w\.\-]+) @ ([\w\-]+)((\.(\w){2,3})+)$");
            //Match match = regex.Match(email);
            //if (match.Success)
            //{
            //  Console.WriteLine(email + " is correct");
            //}
            //else
            //{
            //Console.WriteLine (email + " is incorrect");
        }

        public static int ReadValidInteger()
        {
            Console.WriteLine("Please enter a number:");

            // int Input = int.Parse(Console.ReadLine());

            int Input = 0;

            while (!int.TryParse(Console.ReadLine(), out Input))
            {

                Console.WriteLine("Please enter a valid number!");
            }
            // after the while, you will have a valid number! 
            return Input;



        }
    }
}
