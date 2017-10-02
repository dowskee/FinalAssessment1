using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodTest
{
    class Program
    {

        //method can be written before or after the main
        static void Main(string[] args) //THIS is your Main Method!
        //for now, start with public, static, return type (defines the method's output), name of method, 
        //then "(arguments)" [aka output, returned based on input and return type], followed by your code.
        {
            //when defining a method, ask yourself, does it take any arguments, and does it return anything? 
            int x, y;
            //Console.WriteLine() is an example of something that returns no output and gets no input. It does the same thing every time.
            //Putting something in the quotations does return an output

            //a more simplified version would be to have the separate method below, and return back to this main:
            x = ReadInteger();

            y = ReadInteger();

            //write a method that takes two numbers, and it will return the sum of those two numbers. 
            int Result = Sum(x,y);
            Console.WriteLine(Result);

            //method that calculates the factorial!
            //the method should take a number (int) and return the factorial (long)

        }

        public static int ReadInteger() //what do you want your Method to return back? an integer. 
        //You can also return nothing (void) or another type (other than int)
        {
            int Input;
            Console.WriteLine("Please enter a number");
            Input = int.Parse(Console.ReadLine());

            return Input; //must return, as we declared this in the Method above. This will return to the main method for commands.
        }

        public static int Sum(int Num1, int Num2) //this time, we are requesting a calculation with two inputs, so they go in the argument
        {
           int Result = Num1 + Num2;
           return Result;

        
        }
    }
}
