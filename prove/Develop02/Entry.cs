public class Entry
{
    public string _prompt { get; set; }
    public string _description { get; set; }
    public string _date { get; set; }

    public Entry(string prompt, string description, string date)
    {
        _prompt = prompt;
        _description = description;
        _date = date;
    }
}