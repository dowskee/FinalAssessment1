using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            //design a program that takes a user's birthdate, and returns their age

            //first problem: Need to know user's birthdate
            Console.WriteLine("Please enter your Date of Birth in this format: MM/dd/yyyy");
            DateTime DOB = DateTime.ParseExact(Console.ReadLine(), "MM/dd/yyyy", null);
            //second problem: Need to know how to retrieve today's date
            Console.WriteLine(DOB);

            DateTime today = DateTime.Today;
            //Console.WriteLine(today); to test that today's date is being returned. Don't hesitate to test each part of your code. 

            //third problem: Find a way to get the difference between today's date and user's birthdate.
            TimeSpan DateDifference = today - DOB;

            Console.WriteLine("You are " + DateDifference.Days/365 + " years old!");
        }
    }
}
