using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestControlGrade
{
    class Program
    {
        static void Main(string[] args)
        {
            //input

            double Input;
            Console.WriteLine("Please enter Grade:"); //grades use multiple ranges, so an if/else statement alone will not be sufficient
          
            Input = double.Parse(Console.ReadLine());
            //validation: check if the number is between 0 and 100. This would go here, with the user's input, not in your code. 
            //check if the user did provide a number (not a letter or special character) 

            //processing
            if (Input >= 98)
            {
                //output
                Console.WriteLine("A");
            }
            else if (Input >= 80) //else if is great for using multiple conditions. 
            {
                Console.WriteLine("B");
            }
            else if (Input >= 70)
            {
                Console.WriteLine("C");
            }
            else if (Input >= 60)
            {
                Console.WriteLine("D");
            }
            else 
            {
                Console.WriteLine("F");
            }
        }
    }
}
