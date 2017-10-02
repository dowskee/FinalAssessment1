using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseD
{
    class Program
    {
        static void Main(string[] args)
        {
                for (int row = 0; row < 9; row++) //this counts how many rows there should be (8 and less)
                {
                    Console.Write(" ");

                    for (int col = 0; col <= row; col++) //this counts the columns, or lack thereof (for when the hastag is missing)
                    {
                        Console.Write("#");//this prints the hastags
                        Console.Write(" ");
                    }
                    Console.WriteLine(" ");
                }
                Console.WriteLine(" ");
          
        }
    }
}