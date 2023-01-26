using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment newAssignment = new Assignment("Alex Bedino", "Mathematics");
        Console.WriteLine(newAssignment.GetSummary());
        
        MathAssignment newMath = new MathAssignment("30.4","Math","Alex Bedino","Aerodynamics");
        Console.WriteLine(newMath.GetSummary());
        Console.WriteLine(newMath.GetHomeworkList());

    }
}