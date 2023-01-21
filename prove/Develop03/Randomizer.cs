static class Randomizer
{
    private static readonly Random rand = new Random();
    public static int Next(int maxValue)
    {
        return rand.Next(maxValue);
    }
}