public class Menu{

    private String _title;
    private String _instructions;
    private List<String> _options;

    public Menu(String title, String instructions, List<String> options){
        _title = title;
        _instructions = instructions;
        _options = options;
    }
    
    public int Display(){
        return Display(true);
    }

    public int Display(bool showQuit){
        int choice = -1;
        int minOption = 1;
        if(showQuit){
            minOption = 0;
        }
        while(choice < minOption || choice > _options.Count){
            
            Console.Clear();
            Console.WriteLine(_title);            
            Console.WriteLine(_instructions);
            for(int i = 0; i < _options.Count; i++){
                Console.WriteLine("  "+(i+1) + ". " + _options[i]);
            }
            if(showQuit){
                Console.WriteLine("  0. Quit");
            }
            Console.Write("Enter choice: ");
            String input = Console.ReadLine();
            try{
                choice = Int32.Parse(input);
            }catch(Exception e){
                Console.WriteLine("Invalid input");
                Console.WriteLine("Press enter to continue");
                Console.ReadLine();
            }
        }
        return choice;
    }
}