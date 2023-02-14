public class Utility
{
    public static int GetCardNumber()
    {
        Console.WriteLine("Enter card number:");
        return int.Parse(Console.ReadLine());
    }

    public static int GetPin()
    {
        Console.WriteLine("Enter PIN:");
        return int.Parse(Console.ReadLine());
    }
}