using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    class Program
    {
        static void Main(string[] args)
        { //Generics. Generics allow us to create typed collections of a specific type. 
            //Array list with type string
            List<string> ShoppingItems = new List<string>(); //note how the array list does not have a size. It can grow or shrink

            //ShoppingItems.Add("Spices");
            //ShoppingItems.Add("Milk");
            //ShoppingItems.Add("T-Shirt");//each item has an index. We can use a for loop or foreach to call on them if we like
            //ShoppingItems.Add("Coffee"); //adding one item to list at a time. Current length of array list is 4. 
            int UserOption = 0;
            while(true)
            {
                Console.WriteLine("Please choose an option");
                Console.WriteLine("1. Add an item");
                Console.WriteLine("2. Remove an item");
                Console.WriteLine("3. Print my list");
                Console.WriteLine("4. Search for an item:");
                Console.WriteLine("5. Exit");

                UserOption = int.Parse(Console.ReadLine());

                if (UserOption == 1)
                {
                    Console.WriteLine("Please enter an item");
                    string InputItem = Console.ReadLine();

                    ShoppingItems.Add(InputItem);
                    

                }
                else if (UserOption == 2)
                {
                    Console.WriteLine("Please enter an item you would like to remove");
                    string InputRemove = Console.ReadLine();

                    if (ShoppingItems.Remove(InputRemove) == true)
                    {
                        Console.WriteLine($"{InputRemove} was successfully removed from your list");
                    }
                    else
                    {
                        Console.WriteLine($"I'm sorry, I couldn't find {InputRemove} on your shopping list");
                    }
                    
                }
                else if (UserOption == 3)
                {
                    Console.WriteLine("Your shopping list:");
                    for (int i = 0; i < ShoppingItems.Count; i++)
                    {
                        Console.WriteLine(ShoppingItems[i]);
                    }
                }
                else if (UserOption == 4)
                {
                    Console.WriteLine("Please enter what you would like to search for on your list:");
                    string Search = Console.ReadLine();

                    //for (int i = 0; i < ShoppingItems.Count; ++i)
                    //{
                    //    Search = ShoppingItems[i];
                    //}
                    //Console.WriteLine($"I found {Search} on your shopping list");
                    //but how to return false? Try this way instead v
                    bool Found = false;
                    foreach (string Element in ShoppingItems)
                    {
                        if (Search == Element)
                        {
                            Console.WriteLine($"I found {Search} on your shopping list");
                            Found = true;
                            break; //break from the foreach
                        }
                    }
                    if (!Found)
                    {
                        Console.WriteLine($"I'm sorry, I could not find {Search} in your list");
                    }
                }
                else 
                {
                    Console.WriteLine("Thank you for shopping at Meijer! Please remove your items. Please remove your items. Please take your receipt");
                    break;
                }
            }

            //ShoppingItems.RemoveAt(1); //RemoveAt removes at the index. So this would remove "Milk" 
            //ShoppingItems.Remove("Milk"); //Also can just remove and call on the name of the item
            //ShoppingItems.Clear(); //imagine this like a "clear cart" option online
        }
    }
}
