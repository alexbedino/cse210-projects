class Scripture
{
    private string _book { get; set; }
    private string _number { get; set; }
    private string _verse { get; set; }
    private string[] _words { get; set; }

    public Scripture(string book, string number, string verse)
    {
        _book = book;
        _number = number;
        _verse = verse;
        _words = verse.Split(' ');
    }

    public void Memorize()
    {
        WordRemover wordRemover = new WordRemover(_words);
        while (_words.Length > 0)
        {
            Console.Write($"{_book}, {_number}: ");
            Console.WriteLine(wordRemover.RemoveWords());
            Console.WriteLine("Enter 'quit' to stop or press enter to continue:");

            string input = Console.ReadLine();
            if (input == "quit") 
            {
                break;
            }
        }
    }
}