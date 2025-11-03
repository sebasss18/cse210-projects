using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("\nHello World! This is the Resumes Project.");
        Job job1 = new Job();
        Job job2 = new Job();
        job1._JobTitle = "Software Engineer";
        job1._Company = "Apple";
        job1._Start = 2021;
        job1._End = 2024;

        job2._JobTitle = "Manager";
        job2._Company = "Google";
        job2._Start = 2010;
        job2._End = 2020;

        Resume myResume = new Resume();

        myResume._Name = "Sebastian Bernal";
        myResume._Jobs.Add(job1);
        myResume._Jobs.Add(job2);

        myResume.DisplayResume();
    }
}