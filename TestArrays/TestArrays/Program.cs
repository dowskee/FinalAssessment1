using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //a common way of defining an array is to declare the (type) [ ] and then the (name of the array) = new (type) [size];
            //an array can be any data type, such as strings, chars, int, etc. 

            int[] FirstExamGrades = new int[9]; //this creates nine spots in your array (0-8 in memory). You may use a variable 
            //instead of a fixed number.
            //The spaces in memory will be initialized with zeroes in the int arrays. If you had a string, it would be an empty string
            //value. If you had a boolean, it would initialize everything false. Until the values are changed. 

            //any time you want to access any of these spaces in memory, you must declare the name of the array and then [(index)]

            for (int i = 0; i <= FirstExamGrades.Length -1; i++) //this will go from the instance of 0 until the length of the array -1
            //a for loop is almost always used with arrays
            //if you for get to define the bounds of the array (Length - 1), you will get an IndexOutofRangeException
            {
                Console.WriteLine("Please enter a grade:");
                FirstExamGrades[i] = int.Parse(Console.ReadLine());
            }

            //sum all the elements of the array? 
            int Sum = 0;
            for (int i = 0; i <= FirstExamGrades.Length - 1; i++)
            {
                Sum = Sum + FirstExamGrades[i];
                Console.WriteLine(Sum);
            }

            //find the largest element in the array? 
            int LargestElement = FirstExamGrades[0];
            int SmallestElement = FirstExamGrades[0];
            for (int i = 0; i <= FirstExamGrades.Length - 1; i++)
            {
                if (FirstExamGrades[i] > LargestElement)
                    LargestElement = FirstExamGrades[i]; //this declares your new LargestElement 

                if (FirstExamGrades[i] < SmallestElement)
                    SmallestElement = FirstExamGrades[i];
           
            }
           // for (int i = 0; i < FirstExamGrades.Length; i++)
           // {

           //}


        }
    }
}
