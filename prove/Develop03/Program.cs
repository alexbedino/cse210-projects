using System;

class Program
{
    static void Main(string[] args)
    {
        // exceeded requirement by allowing the user to type in their own scripture
        Console.Write("What book would you like to learn from?");
        string Book = Console.ReadLine();
        Console.Write("What book and chapter?");
        string Chapter = Console.ReadLine();
        Console.Write("Write the verse?");
        string Verse = Console.ReadLine();

        // call the scripture Class and arguments from the previous variables
        Scripture scripture = new Scripture(Book,Chapter,Verse);
        // call the Memorize method to initiate the program core functionality
        scripture.Memorize();
    }
}