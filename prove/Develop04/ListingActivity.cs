using System;

class ListingActivity : Activity
{

    private List<string> _prompts;
    public ListingActivity() : base("Mindfulness Listing", "In this activity you will learn to focus on the good things of life becoming more mindful.")
    {
        
        _prompts = new List<string>();
        _prompts.Add("Who are people that you appreciate?");
        _prompts.Add("What are personal strengths of yours?");
        _prompts.Add("Who are people that you have helped this week?"); 
        _prompts.Add("When have you felt the Holy Ghost this month?");
        _prompts.Add("Who are some of your personal heroes?");
        _prompts.Add("What are some of your favorite scriptures?");
        _prompts.Add("What are some of your favorite quotes?");

    }

    public void Begin(){
    
        Welcome();

        Console.Clear();
        Console.WriteLine("Get Ready...");
        ShowSpinner(3);

        
        Console.Clear();

        Console.WriteLine();
        Console.WriteLine("List as many responses as you can to the following prompt:");

        Console.WriteLine();
        showRandomPrompt();
        Console.WriteLine();

        Console.WriteLine("Get ready");
        ShowSpinner(3);
        Console.WriteLine();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        List<string> responses = new List<string>();
        while( DateTime.Now < endTime){
            Console.Write(">");
            string response = Console.ReadLine();
            responses.Add(response);
        }

        Console.WriteLine();
        Console.WriteLine($"You listed {responses.Count} items.");


        EndActivity();
        
    }

    private void showRandomPrompt(){
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        Console.WriteLine(_prompts[index]);
    }


}