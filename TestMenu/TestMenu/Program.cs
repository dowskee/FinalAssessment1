using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//TODO: Design a library menu for checking out books
namespace TestMenu //switch statements are used often for menus. You CANNOT use >,<, >=, <= operators. If/else statements are less restrictive and more common. 
{
    class Program
    {
        static void Main(string[] args)
        {
            bool ProgramContinue = true;

            while (ProgramContinue == true)
            {
                //input 
                string UserInput;
                Console.WriteLine("Please choose one option");
                Console.WriteLine("1. Search for books");
                Console.WriteLine("2. Checkout a book");
                Console.WriteLine("3. Check in a book");
                Console.WriteLine("4. Exit");
                UserInput = (Console.ReadLine()); //if string is not used, you must use Parse for conversion (for int, for example). When in doubt, hover over text to see what it returns (and if conversion is needed)


                switch (UserInput)
                {
                    case "1": //"1" needs to be in quotations as this is being used as a string. If it were an int type, you won't need the quotation marks. 
                              //search for books
                        Console.WriteLine("We will search for a book");
                        break; //curly brackets are not needed between the start and end (break) of the case

                    case "2":
                        //checkout book
                        Console.WriteLine("Checkout a book of your choosing");
                        break; //break is needed to close each case. Errors will occur if this is not added.

                    case "3":
                        //check in book
                        Console.WriteLine("Check in a book you rented");
                        break;

                    default:
                        ProgramContinue = false; //not == because you are assigning the value of false for this condition
                        Console.WriteLine("Bye bye!");
                        break;
                }
            }//TIP: to line up code, select all (Ctl A), then select Ctl K and F. 
        }
    }
}
