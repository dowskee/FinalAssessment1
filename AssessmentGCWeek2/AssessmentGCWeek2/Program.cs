﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssessmentGCWeek2
{
    class Program
    {
        //static void Main(string[] args)
        //{
        //Problem 1
        //Write a C# code to find the AVERAGE of odd numbers in an arary (you can write this code in the main)

        //int[] Numbers = { 1, 3, 4, 6, 8, 10, 20 };
        //double Average; //needs to be double as average will be decimal. 2/7 numbers are odd
        //double Count = 0; //count the odd numbers
        //for (int i = 0; i < Numbers.Length; i++)
        //{
        //   if (Numbers[i]%2 == 1) //checks if odd
        //       Count++; //adds to count
        //}
        //Average = Count / Numbers.Length; //total of odd/Length of array
        //Console.WriteLine(Average); //print out put (2.875....)

        //---------------------------------------------------------------------------
        //}
        //Problem 2 
        //Write a method that checks if a string is empty or not. The method should return either true or false. 
        //(hint: The string is considered to be empty if it has no characters in it, which means that it has a length of zero)

        //public static bool Check (string Input)
        //{
        // int Enter = 0;

        //     while (!int.TryParse(Console.ReadLine(), out Enter)) //Tryparse to validate input has a value. 
        //         {
        //           Console.WriteLine("The string is empty"); If it doesn't, console will display a message and return will be false. 
        //           return false;
        //         }
        //}

        //---------------------------------------------------------------------------
        //Problem 3
        //Write a for loop that counts how many "a"s there are in the string
        //"This C# bootcamp is so AWESOME". 

        //public class Test
        //{
        //    public static void Main(string[] args)
        //    {
        //        string str = "This C# bootcamp is so awesome!";

        //        int Count = 0;
        //        for (int i = 0; i < str.Length; i++) //goes through length of string
        //        {
        //            if (str[i] == 'a') //searches for any instances of 'a' in string
        //                Count++; //count adds instances together 
        //        }

        //        Console.WriteLine(Count); //output should be 2, which is the total of 'a's in the string
        //    }
        //}

    }
}
