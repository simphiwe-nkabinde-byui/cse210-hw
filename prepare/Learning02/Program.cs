using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Dell";
        job1._startYear = 2014;
        job1._endYear = 2017;

        Job job2 = new Job();
        job2._jobTitle = "Product Designer";
        job2._company = "Adidas";
        job2._startYear = 2017;
        job2._endYear = 2022;

        Resume resume1 = new Resume();
        resume1._name = "Jackson Mullinger";
        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);

        resume1.Display();
        
    }
}