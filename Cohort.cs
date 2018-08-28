using System;
using System.Collections.Generic;
//namespaces all should match
namespace Lightning{
    //name of public class is unique
    public class Cohort {
        // creating an instance of a list with  new List<Student>();
        //List is telling the program to look for a list?
        // getting StudentList and Instructor list from the other files
        public List<Student> StudentList = new List<Student>();
        public List<Instructor> InstructorList = new List<Instructor>();

        public int Number;
    }
}