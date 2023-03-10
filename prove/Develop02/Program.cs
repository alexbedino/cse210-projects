using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator savedprompt = new PromptGenerator();
        bool running = true;
        while (running)
        {
            Console.WriteLine("Your Daily Journal");    
            Console.WriteLine("What would you like to do?\n1. Write\n2. Display\n3. Load\n4. Save\n5. Quit\n6. Add new prompt\n");
            Console.WriteLine();
            int choice = int.Parse(Console.ReadLine());
            // menu with the choices
            switch (choice)
            {
                case 1:
                    // Write
                    journal.AddEntry();
                    break;
                case 2:
                    // Display
                    journal.DisplayEntries();
                    break;
                case 3:
                    // Load
                    Console.WriteLine("Enter the file name you want to load:");
                    string fileName = Console.ReadLine();
                    journal.LoadEntries(fileName);
                    break;
                case 4:
                    // Save
                    Console.WriteLine("Enter the file name you want to save with:");
                    string newFileName = Console.ReadLine();
                    journal.SaveEntries(newFileName);
                    Console.WriteLine("Saved Successfully");
                    break;

                case 5:
                    // Quit
                    running = false;
                    break;

                case 6:
                    // Add another prompt
                    Console.WriteLine("Enter the prompt you want to add to the list:");
                    string newPrompt = Console.ReadLine();
                    savedprompt.SavePrompt(newPrompt);
                    break;
                default:
                    Console.WriteLine("Invalid Choice");
                    break;
            }
        }
    }
}