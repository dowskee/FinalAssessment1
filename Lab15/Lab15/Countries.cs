using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab15
{
    class Countries
    {
        protected string country;

        public string Country //get set for each data piece
        {
            set { country = value; }
            get { return country; }
        }

        //constructors

        //default constructor
        public Countries() //base constructor? 
        {
            country = "";
        }

        //consturctor with values
        public Countries(string CountryName)
        {
            country = CountryName; //calls Make from the array Car
        }

        public virtual void PrintInfo()
        {
            Console.WriteLine(Country); //property (capitalized)

            //to enable method override, we must go to the top, in our Person class. 
            //if the method is defined as virtual, you can override it

        }

        public override string ToString()
        {
            return (Country);
        }
    }
}
