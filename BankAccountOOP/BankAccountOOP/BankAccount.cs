using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountOOP
{
    class BankAccount
    {
        //(AKA fields, members, etc)
        private string name;
        private double accountNo;
        private double balance;
        private string phoneNo;

        //setters and getters in Java => property 
        
        //property
        public string Name //property usually has the same name as the data, but capitalized. No parenthesis next to a property
        {
            set { name = value; } //changes the value of data. Value comes from the user. 

            get { return name; } //return the data (with the small case)
            //These are the guardians of your data. Without the property, no one can utilize the data elements. 
        }

        public double AccountNo
        {
            set { accountNo = value; } //validating numbers would also go here
            get { return accountNo; } //could not realistically return a balance without verifing PIN etc
        }

        public string PhoneNo
        {
            set { phoneNo = value; }
            get { return phoneNo; }
        }

        public double Balance
        {
            set { balance = value; }
            get { return balance; }
        }

        public void OpenAccount() //this is a method, not a property
        {
            Console.WriteLine("Please enter the customer's name:");
            Name = Console.ReadLine();

            Console.WriteLine("Please enter the customer's balance:");
            Balance = double.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the Account Number:");
            AccountNo = double.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the customer's phone number:");
            PhoneNo = Console.ReadLine();

            Console.WriteLine($"Account Number: {AccountNo} Customer Name: {Name} Customer Balance: {Balance} Customer Phone Number {PhoneNo}");
        }

        //constructors 

        //a constructor is a method used to initialize an object once it's been created 

        public BankAccount() //constructors do not need a return types (no void, integer, string, etc). Constructors usually have same name as class name
        {
            //default constructor defines object in this way:
            accountNo = 0;
            name = "";
            balance = 0;
            phoneNo = "";
        }

        //public BankAccount(string ClientName, string ClientPhoneNo, double ClientBalance, double ClientAccountNo) //in this constructor, it will take the name of the client 
        //{
        //    name = ClientName;
        //    accountNo = 0; //only one is initialized (name). All others should be default again. Unless you declare them all at once, like below property 
        //    balance = 0;
        //    phoneNo = ""; //always ensure the constructor perameters are assigned to the class variable, not the other way around. This is a common bug

        //}

        public BankAccount(string ClientName, string ClientPhoneNo, double ClientBalance, double ClientAccountNo)
            //because we have different methods with the same name, with different parameter settings, we have method overloading. 
        {
            name = ClientName;

            accountNo = ClientAccountNo;

            balance = ClientBalance;

            phoneNo = ClientPhoneNo;

        }
    }
}
