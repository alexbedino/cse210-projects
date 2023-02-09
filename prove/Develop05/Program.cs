using System;

class Program
{
    static void Main(string[] args)
    {
        
        // calls the class manage goals which inherits all the components of the program
        ManageGoal goalmanager = new ManageGoal();
        // calls the start method to initiate the program
        goalmanager.start();
        // The GoalManager has been started, allowing users to set, track goals and earn points on top of that.
        Console.WriteLine("Thank you for using the goal manager!");
    }
}