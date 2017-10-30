using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boop
{
    public class Test
    {
        public static void Main(string[] args)
        {
            string str = "This C# bootcamp is so awesome!";

            int Count = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == 'a')
                    Count++;
            }

            Console.WriteLine(Count);
        }
    }
}
