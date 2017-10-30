using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DArrayEx
{
    class Program
    {
        static void Main(string[] args)
        {
            //say you want this program to work with any input from the user (we don't know the value)
            int NoOfPeople = int.Parse(Console.ReadLine());
            int[,] FriendsGraph = new int[NoOfPeople, NoOfPeople];

            //if we want to declare pre-determined values, it will be like so:
            //int[,] FriendsGraph = new int[4,4]; //declaring the comma in the first set of brackets declares a two dimensional array. 
            //declaring the value of integers in the second set of brackets declares how many "columns" or "rows" we want. 

            //mark person 0 to be friends with person 3

            FriendsGraph[0, 3] = 1; //this is the value of the "crossroad" of 0 and 3 on the "table". You will be creating a table to show where this index is.
            //you could also utilize a bool instead of an int, if you wanted to return true or false

            for (int i = 0; i < FriendsGraph.GetLength(0); i++) //rows. We will not use Length by itself as it will return all the elements, not just the ones for rows
            {
                for (int j = 0; j < FriendsGraph.GetLength(1); j++) //columns. We use 1 instead of 0 here, as each dimension has a number, and this is a 2D array.
                {
                    Console.Write(FriendsGraph[i, j] + " "); //each variable is incremented until it reaches the total amount of elements
                    //this will print the value of each element (not the sum) in the column

                //how to make it display columns one at a time (reverse?). Change the values for FriendsGraph.GetLight (swap 0 and 1), then change the order of j and i
                //this is an INTERVIEW question!! 0 always indicates rows, 1 always indicates columns. When you switch them it changes the order. 
                }
                Console.WriteLine(); //this will print the value of each element in the row (once the inner loop is done, then will repeat)
                //it will print out like a table
            }
        }
    }
}
