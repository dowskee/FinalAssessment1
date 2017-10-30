using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLogicalErrors
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter two numbers");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine(Add(num1, num2));
            Console.WriteLine(Subtract(num1, num2));
        }

        public static int Add(int x, int y)
        {
            return x + y;
        }

        public static int Subtract(int x, int y)
        {
            return x - y; //if you forget to change + to -, you will get incorrect figures in the code. There are no errors 
            //displayed, but things are still wrong. This is a logical error, that you must find by yourself, with no help from IDE. 
            //how do you find this? Use the debugger. 
        }

    }
}
