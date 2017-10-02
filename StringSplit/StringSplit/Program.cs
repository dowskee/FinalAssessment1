using System;

public class Example
{
    public static void Main()
    {
        string[] separators = { ",", "!", ":", " " }; //split will look for these characters, and 
        //separate the string wherever they occur
        string value = "The smart, exceptional teacher: Dr.K!"; //value of the string
        string[] words = value.Split(separators, StringSplitOptions.RemoveEmptyEntries); //words variable will be the
        //string value, divided by separators (deliminator, or the piece that actually separates. Think of this 
        //like scissors!)
        value.Split(','); //a more simplified way than writing value.Split(...line 10).
        foreach (var word in words) //for every returned word in words variable, it will print below
            Console.WriteLine(word); //prints word and separates by a new line
    }
}
