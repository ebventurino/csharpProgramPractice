using System;
using System.Collections.Generic;

namespace Lightning
{

    public class Instructor
    {
        private string _firstName;
        private string _lastName;

        public string Name { get => $"{_firstName} {_lastName}"; }
        // a constructor
        public Instructor(string firstName, string lastName)
        {
            _firstName = firstName;
            _lastName = lastName;
        }
        // student is taco, exercise is taco
        public void AssignExercise(Student student, Exercise exercise)
        // adding one more exercise to assignedExercises
        { 
            student.AssignedExercises.Add(exercise);
        }

    }

}