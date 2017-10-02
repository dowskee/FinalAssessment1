using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace TestForLoops
{
    //ToDo: Make a countdown one second at a time from 10 to 0
    class Program
    {
        static void Main(string[] args)
        {
            int Input = 10;

            for(int i=Input; i >= 0; i--)
            {
                
                Thread.Sleep(1000); //sleep goes by miliseconds. For every 1000 miliseconds (1 second), there will be a pause
                Console.Clear(); //this will replace the previous number with the next in the sequence
                Console.WriteLine(i); //this by itself will return an output of a countdown list from 10 to 0.
               
            }
        }
    }
}
