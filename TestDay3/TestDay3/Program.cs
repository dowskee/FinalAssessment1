using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDay3
{
    class Program
    {
        static void Main(string[] args)
        {
            bool answer = true;
            while (answer == true)
            {
                //TO DO: This program will generate two random numbers between 2 and 10
                //This program will show the two numbers to the user in the form of num1 x num2, and then ask the user for the answer. 
                //The program needs to check if the user did submit the correct answer. 
                //If incorrect answer is given, it should continue to ask for correct answer.

                //1st problem: How can we generate two numbers between 2 and 10. 
                //2nd problem: Print those two random numbers to the user to multiply together. 
                //3rd problem: Prompt user to enter in their answer.
                //4th problem: Give this back as correct, or incorrect, repeat prompt for user's answer. 
                bool result = true;
                while (result == true)
                {


                    int UserNum1, UserNum2, response;

                    Console.WriteLine("We are going to practice multiplication!");
                    Console.WriteLine("Please enter a number between 2 and 10");
                    UserNum1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Please enter a second number between 2 and 10");
                    UserNum2 = int.Parse(Console.ReadLine());


                    if (UserNum1 <= 2 && UserNum1 >= 10 && UserNum2 <= 2 && UserNum2 >= 10)
                    {
                        answer = false;
                        Console.WriteLine("Please select numbers between 2 and 10");
                    }

                    else
                    {
                        Console.WriteLine("What is the result of your numbers' multiplied?");
                        response = int.Parse(Console.ReadLine());

                        if (UserNum1 * UserNum2 == response)
                        {
                            result = false;
                            answer = false;
                            Console.WriteLine("Correct!");
                        }

                        else
                        {
                          
                            Console.WriteLine("That is incorrect. Please try again");
                        }
                    }
                }
            }
        }
    }
}
