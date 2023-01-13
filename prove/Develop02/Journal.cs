public class Journal
{
    List<Entry> entries;
    PromptGenerator promptGenerator;

    public Journal()
    {
        entries = new List<Entry>();
        promptGenerator = new PromptGenerator();
    }

    public void AddEntry()
    {
        string prompt = promptGenerator.GeneratePrompt();
        string date = DateTime.Now.ToString("yyyy-MM-dd");
        Console.WriteLine(prompt);
        string eventDescription = Console.ReadLine();
        Entry entry = new Entry(prompt, eventDescription, date);
        entries.Add(entry);
    }

    public void DisplayEntries()
    {
        foreach (Entry entry in entries)
        {
            Console.WriteLine($"{entry._date} {entry._description}");
            Console.WriteLine();
        }
    }

    public void SaveEntries(string fileName)
    {
        using (StreamWriter outputFile = new StreamWriter(fileName, true))
        {
            foreach (Entry entry in entries)
            {
                outputFile.WriteLine($"{entry._date} {entry._description}");
                outputFile.WriteLine();
            }
        }
    }

    public void LoadEntries(string fileName)
    {
        using (StreamReader sr = new StreamReader(fileName))
        {
            String line = sr.ReadToEnd();
            Console.WriteLine("\n" + line);
        }
    }
}