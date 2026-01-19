using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studentproject
{
    internal class coursecs
    {
        public int CourseID;
        public string title;
        public instructorcs Instructor;
        public string printDetails()
        {
            return $"Course ID: {CourseID}, Title: {title}, Instructor: {Instructor.name}";
        }
    }
}
