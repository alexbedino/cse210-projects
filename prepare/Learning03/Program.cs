using System;

class Program
{
    static void Main(string[] args)
    {
        
        Console.WriteLine("Hello Learning03 World!");
        Console.WriteLine("Please add a numerator");
        int numerator = int.Parse(Console.ReadLine());
        Console.WriteLine("Please add a denominator");
        int denominator = int.Parse(Console.ReadLine());

        Fraction fraction = new Fraction();
        Console.WriteLine(fraction.DisplayFraction1());
        fraction.SetFraction2(numerator);
        fraction.SetFraction3(numerator,denominator);
        Console.WriteLine(fraction.DisplayFraction2());
        
        Console.WriteLine(fraction.DisplayFraction3());

    }
}