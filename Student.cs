using System;
using System.Collections.Generic;
//namespaces all should match
namespace Lightning{
    //name of public class is unique
    public class Student {
        private string _firstName;
        private string _lastName;

        public string Name {get => $"{_firstName} {_lastName}";}
//exercise is refering to other file
        public List<Exercise> AssignedExercises { get; } = new List<Exercise>();

        // a constructor
        public Student(string firstName, string lastName){
            _firstName = firstName;
            _lastName = lastName;
        }
    }
}