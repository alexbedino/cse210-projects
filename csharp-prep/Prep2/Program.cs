using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Grade Calculator");
        Console.Write("What is your grade percentage? ");
        string userInput = Console.ReadLine();
        int grade = int.Parse(userInput);
        string letter = "";
        string pass = "";

        if (grade >= 90){
            pass = "Y";
            if (grade <=93){
                letter="A-";
            }
            else{
                letter = "A";
            }
        }
        else if (grade >= 80){
            pass = "Y";
            if (grade >= 87){
                letter ="B+";
            }
            else if (grade <= 83){
                letter = "B-";
            }
            else{
                letter ="B";
            }
        }
        else if (grade >= 70){
            pass = "Y";
            if (grade >= 77){
                letter ="C+";
            }
            else if (grade <= 73){
                letter = "C-";
            }
            else{
                letter ="C";
            }
        }
        else if (grade >= 60){
            pass = "N";
            if (grade >= 67){
                letter ="D+";
            }
            else if (grade <= 63){
                letter = "D-";
            }
            else{
                letter ="D";
            }
        }
        else{
            letter = "F";
            pass = "N";
        }

        Console.Write($"You got {letter}. ");
        if (pass == "Y"){
            Console.Write("And you passed the class.");
        }
        else{
            Console.Write("You failed the class.");
        }

    }
}