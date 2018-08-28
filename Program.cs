using System;
using System.Collections.Generic;

namespace Lightning
{
    class Program
    {
        static void Main(string[] args)
        {
            //Cohort refering to the file name. cohort26 = taco. Setting to a function Cohort
            Cohort cohort26 = new Cohort();

            Instructor steve = new Instructor("Steve", "Brownlee");

            Student jewel = new Student("Jewel", "Ramirez");
            // adding steve and jewel to the function??
            cohort26.InstructorList.Add(steve);
            cohort26.StudentList.Add(jewel);





            // setting exercise to new exercise
            Exercise ex1 = new Exercise();
            ex1.Name = "ChickenMonkey";
            ex1.Language = "JavaScript";
            ex1.GithubUrl = "www.github.com";

            Exercise ex2 = new Exercise()
            {
                Name = "KillHanson",
                Language = "c#",
                GithubUrl = "www.github.com"

            };

            Console.WriteLine(ex2.Name);

            steve.AssignExercise(jewel, ex2);

            foreach (Exercise exercise in jewel.AssignedExercises)
            {
                Console.WriteLine($"{jewel.Name}:{exercise.Name}");
            }


        }
    }
}

