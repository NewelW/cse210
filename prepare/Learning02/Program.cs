using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Microslop";
        job1._endYear = 2028;
        job1._startYear = 2026;
        Job job2 = new Job();
        job2._jobTitle = "Electrical Engineer";
        job2._company = "Apple";
        job2._endYear = 2047;
        job2._startYear = 2002;
        Resume resume = new Resume();
        resume._name = "Dave Joe";
        resume._jobs.Add(job1);
        resume._jobs.Add(job2);
        resume.DisplayResume();
    }
}