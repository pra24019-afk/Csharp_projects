using System;

class Program
{
    static void Main(string[] args)
    {
        Resume myResume = new Resume();
        myResume._name = "Parley Pratt";

        Job job1 = new Job();
        job1._jobTitle = "Electrical Engineer";
        job1._company = "Engineering inc";
        job1._startYear = 2022;
        job1._endYear = 2026;
        
        Job job2 = new Job();
        job2._jobTitle = "Electrician";
        job2._company = "Fryer Handiman";
        job2._startYear = 2018;
        job2._endYear = 2022;

        Job job3 = new Job();
        job3._jobTitle = "Cashier";
        job3._company = "McDonalds";
        job3._startYear = 2015;
        job3._endYear = 2018;

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);
        myResume._jobs.Add(job3);
        myResume.DisplayResume();
    }
}
