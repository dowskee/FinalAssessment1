using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestArrays2
{
    class Program
    {
        static void Main(string[] args)
        {
            // int[] Numbers = { 1,2,3,4,5};
            //  char[] Vowels = {'i','e','o','u','a' };

            Console.WriteLine("How many students do you have?");
            int Size = int.Parse(Console.ReadLine());

            double[] StudentGrades = new double[Size];

            // read the grades from the user
            for (int i = 0; i < StudentGrades.Length; i++)
            {
                Console.WriteLine("Please enter grade for student No." + (i + 1));
                StudentGrades[i] = double.Parse(Console.ReadLine());
            }

            double Sum = 0;
            double Avg;

            for (int i = 0; i < StudentGrades.Length; i++)
            {
                Sum = Sum + StudentGrades[i];

            }

            Avg = Sum / Size;

            Console.WriteLine($"The Avg is equal to {Avg}");

            //Console.WriteLine("The Avg is equal to" +Avg);
            // Find the average of the grades 
            //Average  = Sum/Size 


            //foreach is for read-only. You cannot change the elements inside of an array with a foreach statement. 
            //used to fetch limits, so you can't use it to work with indexes
            //int[] ar = { 1, 2, 3, 4, 5, 6, 0, 3 };
            //foreach (int Element in ar) (for each element in the array). This goes over the elements one by one without you incrementing
            //{
            //  Console.WriteLine(Element);
            //}




        }
    }
}