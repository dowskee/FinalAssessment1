using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            //to use a class, you need to make an object. 

           // BankAccount IrvinAccount = new BankAccount(); //object () call for the default constructor [initializes to default values]
           // Console.WriteLine(IrvinAccount.Balance);

            //IrvinAccount.Name = "Irvin Aguilar"; //only Name is showing because it is public in the BankAccount class. Name is a property. 
            //IrvinAccount.Balance = 90000000;
            //Console.WriteLine(IrvinAccount.Name);
            //Console.WriteLine($"$ {IrvinAccount.Balance.ToString("n2")}");

            //test your engine (class) before putting it in the car (main). You can test this by going to the project, add, Test (Unit test project). 
            //integration testing is when sometimes the unit testing is working fine on its own, but once all components are together, it fails in some way. 
            //some companies have programmers specifically designated to ensure everything is working fine
            //IrvinAccount.OpenAccount(); //to call a method from an object, you need to use the "." operator, then the method's name, followed by parenthesis. 

           // BankAccount b1 = new BankAccount("Alexandra", "1928562940" , "900000", "245963827"); //when you call this, you will see you have three options for your BankAccount (hover)
            //should call ClientName, ClientPhoneNo, ClientBlanace, ClientAccountNo in this order. 

            //Console.WriteLine(); // you will see about 18 different options when you hover over between parenthesis. This is method overloading. 
            //Method overloading is valid when you have different types of paremeters with the same name, or different 

            //after this, you can manipulate the data as such:
            //b1.Balance += 1000000000; (would add 1 million to the private balance data. Note how Balance after b1 is capitalized, as we are only able to see the property (capital balance)) 
            //we can only manipulate data from the main by taping in to the public property in BankAccount.cs 
            //b1.OpenAccount(); //we can't store all of this here. Say we have 1000 customers. We will want to store this in a data structure, such as an array or hashtable.

            //we need to use a data structure to hold all of our objects (potential customers) 

            int NumberofAccounts;
            Console.WriteLine("Please enter the number of accounts in your bank");
            NumberofAccounts = int.Parse(Console.ReadLine());

            //Step 1: Create an array to hold the objects
            BankAccount [] GCBank = new BankAccount[NumberofAccounts]; //the name of the array is the BankAccount itself, as it holds all the information
            //this creates placeholders for the potential accounts, but they do not yet contain value (think of empty parking lot). 
            //we made an array of the class BankAccount, and we don't yet have any objects. 

            //an object part of another object is called Composition
            //Step 2: Creating the Bank Account objects inside our array (GCBank)
            for (int i = 0; i < GCBank.Length; i++)
            {
                GCBank[i] = new BankAccount(); //make an object
            }

            //Step 3. Initialze the objects, either with the constructor above by inserting the desired value (name, accountNo, etc). Or:

            for (int i = 0; i < GCBank.Length; i++)
            {
                Console.WriteLine("Please enter the client's name:"); //here we are gaining access to each "parking space" (initializing the objects) in our "parking lot" 
                GCBank[i].Name = Console.ReadLine();

                Console.WriteLine("Please enter the client's balance:");
                GCBank[i].Balance = double.Parse(Console.ReadLine());

                Console.WriteLine("Please enter the client's phone number:");
                GCBank[i].PhoneNo = Console.ReadLine();

                Console.WriteLine("Please enter the client's account number:");
                GCBank[i].AccountNo = double.Parse(Console.ReadLine());
            }

            //calculate the average of balances for all my accounts 

            //double Sum = 0;
            //for (int i = 0; i < GCBank.Length; i++)
            //{
            //    Sum = (GCBank[i].Balance) + Sum;
            //}
            //double Average = Sum / GCBank.Length;
            //Console.WriteLine(Average);
            Console.WriteLine("Name \tBalance \tPhone Number \tAccount Number");
            Console.Beep();
            foreach (BankAccount ElementBA in GCBank)
            {
                Console.WriteLine($" {ElementBA.Name} \t{ElementBA.Balance} \t{ElementBA.PhoneNo} \t{ElementBA.AccountNo}");
            }

            //calculate the average of balances for all my accounts

            double Sum = 0;
            for (int i = 0; i < GCBank.Length; i++)
            {
                Sum = (GCBank[i].Balance) + Sum;
            }
            double Average = Sum / GCBank.Length;
            Console.WriteLine($"The average balance for your accounts is: {Average}");
            Console.Beep();
        }
    }
}
