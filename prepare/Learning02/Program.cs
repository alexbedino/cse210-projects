using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning02 World!");

        Job job1 = new Job();
        job1._company = "Microsoft";
        job1._jobTitle = "Data Scientist";
        job1._startYear = "1999";
        job1._endYear = "2009";
        job1._jobInformation();

        Job job2 = new Job();
        job2._company = "Apple";
        job2._jobTitle = "Computer Scientist";
        job2._startYear = "2009";
        job2._endYear = "2019";
        job2._jobInformation();

        Resume resume1 = new Resume();
        resume1._name = "Jon Wayne";
        resume1.jobs.Add(job1);
        resume1.jobs.Add(job2);

        resume1.Display();
    }
}