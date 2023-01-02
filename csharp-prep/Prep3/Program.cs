using System;

class Program
{
    static void Main(string[] args)
    {
    string playAgain = "Yes";
    while( playAgain == "Yes"){
        Random rnd = new Random();
        int secretNum = rnd.Next(1, 11); // creates a number between 1 and 10
        int guess = 0;
        int attempt = 1;
        while (secretNum != guess && attempt < 4){

            Console.WriteLine($"Attempt number {attempt}");
            Console.WriteLine("Guess the number ");
            string userInput = Console.ReadLine();
            guess = int.Parse(userInput);
            attempt = attempt+1;
            if (guess > secretNum){
                Console.WriteLine("Lower");
            }
            else{
                Console.WriteLine("Higher");
            }
            
        }

        if (secretNum == guess){
            Console.WriteLine($"You win! The secret number is {secretNum}.");
        }
        else{
            Console.WriteLine($"You lose! The secret number is {secretNum}.");
        }
    Console.WriteLine("Do you want to play again? ");
    playAgain = Console.ReadLine();
    }
        
    }
}