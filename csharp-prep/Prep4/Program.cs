using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");
        List<int> numbers = new List<int>(); // defining the empty list

        int number = 1;
        while (number != 0){
            Console.Write("Please enter a number, press 0 to stop: ");
            string addnumber = Console.ReadLine();
            number = int.Parse(addnumber);
            if (number != 0){
                numbers.Add(number);
            }
            else{
                continue;
            }
        
        }
        int total = 0;
        foreach (int instance in numbers){
            total = total + instance; 
            }
        Console.WriteLine($"the total of numbers is {total}");
        double average = numbers.Average();
        Console.WriteLine($"the average of numbers is {average}");
        double max = numbers.Max();
        Console.WriteLine($"the max of numbers is {max}");
        numbers.Sort();
        foreach (int x in numbers){
        Console.WriteLine(x);}

    }
}