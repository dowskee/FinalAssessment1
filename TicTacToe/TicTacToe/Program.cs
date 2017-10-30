using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            bool PlayAgain = true;
            while (PlayAgain == true)
            { 
            //define a 2d array of chars
            char[,] TTT = new char[3, 3];

            PrintGameBoard(TTT);

            int Row;
            int Column;

            int Rounds = 1;

                while (Rounds != 9)//this loop will stop when one of the users win, or we have a tie
                {
                    Console.WriteLine("User 1 turn");
                    Console.WriteLine("Please enter the row number (0-2): ");
                    Row = int.Parse(Console.ReadLine()); //you can replace this with validation method to ensure numbers selected are correct

                    Console.WriteLine("Please enter the column number (0-2): ");
                    Column = int.Parse(Console.ReadLine());


                    if (Rounds % 2 == 0)
                        TTT[Row, Column] = '0';

                    else
                        TTT[Row, Column] = 'x';

                    Console.Clear();
                    char Status = GameOutcome(TTT, TTT[Row, Column]);
                    if (Status != 'p')
                    {
                        Console.WriteLine("We have a winner!" + Status);
                        break; //terminate the while loop
                    }

                    PrintGameBoard(TTT); //call method and the name of the array
                    Rounds++; //move to the next round
                }

                string AgainAgain = Console.ReadLine().ToLower();
                if (AgainAgain == "n" || AgainAgain == "no")
                {
                    Console.WriteLine("Goodbye! Come back soon!");
                    PlayAgain = false;
                }
            }
        }

        static void PrintGameBoard(char[,] TTT)
        {
            Console.WriteLine(TTT[0, 0] + "|" + TTT[0, 1] + "|" + TTT[0, 2]);
            Console.WriteLine("-------");

            Console.WriteLine(TTT[1, 0] + "|" + TTT[1, 1] + "|" + TTT[1, 2]);
            Console.WriteLine("-------");

            Console.WriteLine(TTT[2, 0] + "|" + TTT[2, 1] + "|" + TTT[2, 2]);
            Console.WriteLine("-------");
        }

        static char GameOutcome(char [,] TTT, char CurrentPlayer)
        {
            char Status = 'p'; //default status to play the game
            
            if (TTT[0,0] == TTT [0,1] && TTT[0, 1] == TTT[0, 2] && TTT[0, 2] == CurrentPlayer)
            {
                Status = CurrentPlayer;
            }
            
            if (TTT[1,0] == TTT [1,1] && TTT[1,1] == TTT[1,2] && TTT [1,2] == CurrentPlayer)
            {
                Status = CurrentPlayer;
            }

            if (TTT[2,0] == TTT [2,1] && TTT[2,1] == TTT[2,2] && TTT [2,2] == CurrentPlayer)
            {
                Status = CurrentPlayer;
            }

            if (TTT[0,0] == TTT[1,0] && TTT[1,0] == TTT[2,0] && TTT [2,0] == CurrentPlayer)
            {
                Status = CurrentPlayer;
            }

            if (TTT[0,1] == TTT[1,1] && TTT [1,1] == TTT[2,1] && TTT [2,1] == CurrentPlayer)
            {
                Status = CurrentPlayer;
            }

            if (TTT[0,2] == TTT[1,2] && TTT[1,2] == TTT[2,2] && TTT [2,2] == CurrentPlayer)
            {
                Status = CurrentPlayer;
            }

            if (TTT[0,0] == TTT[1,1] && TTT[1,1] == TTT[2,2] && TTT [2,2] == CurrentPlayer)
            {
                Status = CurrentPlayer;
            }

            if (TTT[0,2] == TTT[1,1] && TTT[1,1] == TTT[2,0] && TTT[2,0] == CurrentPlayer)
            {
                Status = CurrentPlayer;
            }

            return Status;
        }
    }
}
