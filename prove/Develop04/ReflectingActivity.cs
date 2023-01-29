class ReflectingActivity : Activity
{

    private List<string> _prompts;

    private List<string> _questions;
    public ReflectingActivity() : base("Reflecting Activity", "Reflect on instances of your strength and resilience with this activity. Acknowledge your inner power and learn to apply it in other areas of your life.")
    {
        _prompts = new List<string>();
        _prompts.Add("Think of a time when you did something really difficult.");
        _prompts.Add("Think of a time when you were really proud of yourself.");
        _prompts.Add("Think of a time when you were really scared.");
        _prompts.Add("Think of a time when you were really happy.");
        _prompts.Add("Think of a time when you did something truly selfless.");
        _prompts.Add("Think of a time when you helped someone in need.");

        _questions = new List<string>();
        _questions.Add("Why was this experience meaningful to you?");
        _questions.Add("Have you ever done anything like this before?");
        _questions.Add("How did you get started?");
        _questions.Add("How did you feel when it was complete?");
        _questions.Add("What made this time different than other times when you were not as successful?");
        _questions.Add("What is your favorite thing about this experience?");
        _questions.Add("What could you learn from this experience that applies to other situations?");
        _questions.Add("What did you learn about yourself through this experience?");
        _questions.Add("How can you keep this experience in mind in the future?");
        _questions.Add("What are some things you can do to help you feel this way again?");


    }

    public void Begin(){
    
        Welcome();


        Console.Clear();
        Console.WriteLine("Prepare to write");
        ShowSpinner(3);

        Console.WriteLine("Start from this idea:");

        Console.WriteLine();
        showRandomPrompt();
        Console.WriteLine();

        Console.WriteLine("When you have something in mind, press any key to begin");
        Console.ReadKey();

        Console.Clear();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while( DateTime.Now < endTime){
            showRandomQuestion();
            int sleep = 8;
            if(endTime.Subtract(DateTime.Now).TotalSeconds < 8){
                sleep = (int)endTime.Subtract(DateTime.Now).TotalSeconds+1;
            }
            ShowSpinner(sleep);
        }

        EndActivity();
        
    }

    private void showRandomPrompt(){
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        Console.WriteLine(_prompts[index]);
    }

    private void showRandomQuestion(){
        Random random = new Random();
        int index = random.Next(_questions.Count);
        Console.WriteLine(_questions[index]);
    }

}