class WordRemover
{
    private readonly Random rand;
    private string[] words;
    public WordRemover(string[] words)
    {
        this.words = words;
        rand = new Random();
    }
    public string RemoveWords()
    {
        int index1 = Randomizer.Next(words.Length);
        int index2 = Randomizer.Next(words.Length);
        words = words.Where(val => val != words[index1] && val != words[index2]).ToArray();
        return string.Join(" ", words);
    }
}
