using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep5 World!");

        // defining functions list
        static void DisplayMessage(){
        Console.WriteLine("Welcome to the Program!");}

        static string DisplayName(){
            Console.Write("What is your name human? ");
            string name = Console.ReadLine();
            return name;
        }

        static int FavoriteNumber(){
            Console.Write("What is your favorite number? ");
            string number = Console.ReadLine();
            int luckyNumber = int.Parse(number);
            return luckyNumber;
        }

        static int SquareNumber(int luckyNumber){
            int result = luckyNumber*luckyNumber;
            return result;
        }

        static void DisplayResult(string name, int result){
            Console.Write($"{name} the square of your number is {result}");
        };

        static void main(){
            DisplayMessage();
            DisplayResult(DisplayName(),SquareNumber(FavoriteNumber()));
        }

        main();
    }
}