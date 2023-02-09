public class Menu {
    private String _title;
    private String _instructions;
    private List<String> _options;
     // Constructor with parameters
    public Menu(String title, String instructions, List<String> options) {
        _title = title;
        _instructions = instructions;
        _options = options;
    }
     // Method to display menu 
    // with no parameter (showQuit defaulted to true)
    public int Display() {
        return Display(true);
    }
     // Method to display menu 
    // with parameter showQuit (boolean type)
    public int Display(bool showQuit) {
        int choice = -1;
        int minOption = 1;
         // If showQuit is true then minimum option is 0
        if (showQuit) {
            minOption = 0;
        }
         // While loop to input and validate user's choice
        while (choice < minOption || choice > _options.Count) {
            Console.Clear();
            Console.WriteLine(_title);
            Console.WriteLine(_instructions);
             // Loop to show all available options
            for (int i = 0; i < _options.Count; i++) {
                Console.WriteLine("  " + (i + 1) + ". " + _options[i]);
            }
             // Option to quit the program if showQuit is true
            if (showQuit) {
                Console.WriteLine("  0. End the program");
            }
             Console.Write("Make your choice: ");
            String input = Console.ReadLine();
            try {
                choice = Int32.Parse(input);
            } catch (Exception)
            {
                Console.WriteLine("Wrong choice");
                Console.WriteLine("Enter to continue");
                Console.ReadLine();
            }
        }
        return choice;
    }
}
