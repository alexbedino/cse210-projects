using System;

class Program
{
    static void Main(string[] args)
    {

        int choice = -1;
        while (choice != 0)
        {

            Menu homeMenu = new Menu(
                "Your Mindfulness App",
                "Which Mindfulness Activity would you like to do today?",
                new List<String> { "Breath", "Reflect", "Listing" }
            );
            choice = homeMenu.Display();
            Console.Clear();
            
            BreathingActivity breathingActivity = new BreathingActivity();
            ReflectingActivity reflectingActivity = new ReflectingActivity();
            ListingActivity listingActivity = new ListingActivity();

            switch (choice)
            {
                case 1:
                    breathingActivity.Begin();
                    break;
                case 2:
                    reflectingActivity.Begin();
                    break;
                case 3:
                    listingActivity.Begin();
                    break;
                default:
                    return;
            }
        }
    }
}