using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studentproject
{
    internal class instructorcs
    {
        public int InstructorID;
        public string name;
        public string department;
        public string specialization;
        public string printDetails()
        {
            return $"Instructor ID: {InstructorID}, Name: {name}, Department: {department}, Specialization: {specialization}";
        }
    }
}
