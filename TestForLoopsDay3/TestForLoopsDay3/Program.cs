using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestForLoopsDay3
{
    class Program
    {
        static void Main(string[] args)
        {
            //This program will generate two random numbers between 2 and 10
            //This program will show the two numbers to the user in the form of
            //Num1 x Num2, and will ask the user for the answer.
            //The program will check if the user gave the correct response. 

            //Input: get two random numbers between 2 and 10
            bool ProgramContinue =true; 
            while (ProgramContinue == true)
            {
                int Num1, Num2, Answer;

                Random rnd = new Random();
                Num1 = rnd.Next(2, 11); //range is not inclusive of 11, it stops at 10 for your random numbers between 2 and 10

                Num2 = rnd.Next(2, 11); //min - (max-1)

                Console.WriteLine("What is " + Num1 + " x " + Num2 + " = ? ");

                Answer = int.Parse(Console.ReadLine());

                if (Num1 * Num2 == Answer)
                {
                    Console.WriteLine("Correct!");
                    ProgramContinue = false;
                }

                else
                {
                    Console.WriteLine("That is incorrect. Please try again.");
                }

            }
        }
    }
}
