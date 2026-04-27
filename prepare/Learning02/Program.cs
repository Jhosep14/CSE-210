using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Resume and Job History Builder");
        Console.WriteLine("-----------------------------------------------");

        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Google";
        job1._startDate = "2023";
        job1._endDate = "Present";
        
        Job job2 = new Job();
        job2._jobTitle = "Software Engineer";
        job2._company = "Microsoft";
        job2._startDate = "2020";
        job2._endDate = "2023";
        
        Resume resume = new Resume();
        resume._name = "John Doe";
        resume._jobs.Add(job1);
        resume._jobs.Add(job2);
        
        resume.DisplayResume();
    }
}


