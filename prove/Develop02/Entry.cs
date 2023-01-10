public class Entry
{
    public string Prompt { get; set; }
    public string Description { get; set; }
    public string Date { get; set; }

    public Entry(string prompt, string description, string date)
    {
        Prompt = prompt;
        Description = description;
        Date = date;
    }
}