using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorialExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            long fact = long.Parse(Console.ReadLine());
            Console.WriteLine(fact);
        }


        public static long CalcFact(int Input)
        {
            long Fact = 1;
            for (int i = 1; i <= Input; i++) 
            {
                Fact *= i;
            }

            return Fact;
        }
    }
}
