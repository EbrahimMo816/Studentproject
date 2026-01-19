using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studentproject
//EbraBepo

{
    internal class Student
    {
        public int StudentID;
        public string name;
        public int age;
        List<coursecs> Courses;
        public bool enrollInCourse(coursecs course)
        {
            if (Courses == null)
            {
                Courses = new List<coursecs>();
            }
            Courses.Add(course);
            return true;
        }
        public string printDetails()
        {
            return $"Student ID: {StudentID}, Name: {name}, Age: {age}";
        }
    }
}

    



