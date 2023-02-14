public class AppScreen
{
    public static int GetMenuChoice()
    {
        Console.WriteLine("Please choose an option:");
        Console.WriteLine("1. Deposit");
        Console.WriteLine("2. Current balance");
        Console.WriteLine("3. Pay bills");
        Console.WriteLine("4. Exit");
        return int.Parse(Console.ReadLine());
    }

    public static void ShowBalance(double balance)
    {
        Console.WriteLine($"Current balance: ${balance}");
    }

    public static void ShowMessage(string message)
    {
        Console.WriteLine(message);
    }

    public static double GetAmount()
    {
        Console.WriteLine("Enter amount:");
        return double.Parse(Console.ReadLine());
    }
}