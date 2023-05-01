using System.Collections.Generic;

namespace Learning02  {
    class Program {
        static void Main(string[] args) {
            Job job1 = new Job();
            job1._title = "Software Engineer";
            job1._company = "Google";
            job1._startYear = 2006;
            job1._endYear = 2018;

            Job job2 = new Job();
            job2._title = "QA Tester";
            job2._company = "Amazon";
            job2._startYear = 1999;
            job2._endYear = 2014;

            Resume resume1 = new Resume();
            resume1._name = "Preston Corless";

            resume1._jobs = new List<Job>(){};
            resume1._jobs.Add(job1);
            resume1._jobs.Add(job2);

            resume1.Display();
        }
    }
}
