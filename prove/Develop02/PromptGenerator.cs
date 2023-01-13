public class PromptGenerator
{
    List<string> items = new List<string>() {"Who was the most interesting person I interacted with today?", "What was the best part of my day?", "How did I see the hand of the Lord in my life today?", "What was the strongest emotion I felt today?", "If I had one thing I could do over today, what would it be?"};
    public string GeneratePrompt()
    {
        
        Random rand = new Random();
        int randomIndex = rand.Next(items.Count);
        string randomItem = items[randomIndex];
        return randomItem;
    }

    public void SavePrompt(string savedprompt){
        items.Add(savedprompt);

    }
}