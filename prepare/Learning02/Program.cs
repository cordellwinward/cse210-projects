using System;

class Program
{
    static void Main(string[] args)
    {

        Job job1 = new Job();
        job1._jobTitle = "Manager";
        job1._company = "Pizza United";
        job1._startYear = 2002;
        job1._endYear = 2014;

        Job job2 = new Job();
        job2._jobTitle = "Software Engineer";
        job2._company = "Microsoft";
        job2._startYear = 2016;
        job2._endYear = 2020;

        Resume myResume = new Resume();
        myResume._name = "John Hunter";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.DisplayResume();

    }
}