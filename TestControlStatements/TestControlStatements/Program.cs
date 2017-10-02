using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; //namespaces

namespace TestControlStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            double Input;
            Console.WriteLine("Please enter your age:");
            Input = double.Parse(Console.ReadLine());

            //processing
            if (Input <= 150 && Input >= 21)
            {
                //output
                Console.WriteLine("Date is valid!"); //if there is only one single statement, curly brackets are not necessary. However it is recommended you put them in case you need to add additional statements. 
                Console.WriteLine("You can purchase alcohol now!");
            }
            else
            {
                //output
                Console.WriteLine("Maybe you should get some soda!"); 
            }
        }
    }
}
