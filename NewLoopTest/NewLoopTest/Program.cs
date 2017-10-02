using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewLoopTest
{
    class Program
    {
        static void Main(string[] args)
        {
            bool ProgramContinue = true;

            while (ProgramContinue == true) 
            {
                //put in your code

                string UserChoice;
                Console.WriteLine("Do you want to run the code again?");
                UserChoice = Console.ReadLine(); //validation would go here
                if (UserChoice == "N" || UserChoice == "No" || UserChoice == "no" || UserChoice == "n")
                {
                    ProgramContinue = false;
                }
    
            }
        }
    }
}
