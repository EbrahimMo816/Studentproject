using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studentproject
{
    internal class StudentManager
    {
        
            List<Student> students;
            List<instructorcs> instructors;
            List<coursecs> courses;
            public bool addStudent(Student student)
            {
                if (students == null)
                {
                    students = new List<Student>();
                }
                students.Add(student);
                Console.WriteLine("Student added successfully.");
                return true;
            }
            public bool addcourse(coursecs course)
            {
                if (courses == null)
                {
                    courses = new List<coursecs>();
                }
                Console.WriteLine("select the instructor by id");
                courses.Add(course);
                Console.WriteLine("Course added successfully.");
                return true;
            }
            public bool addInstructor(instructorcs instructor)
            {
                if (instructors == null)
                {
                    instructors = new List<instructorcs>();
                }
                instructors.Add(instructor);
                return true;
            }
            public Student findstudent(int studentID)
            {
                if (students != null)
                {
                    foreach (var student in students)
                    {
                        if (student.StudentID == studentID)
                        {
                            return student;
                        }
                    }
                }
                return null;
            }
           public coursecs findcourse(int courseID)
            {
                if (courses != null)
                {
                    foreach (var course in courses)
                    {
                        if (course.CourseID == courseID)
                        {
                            return course;
                        }
                    }
                }
                return null;

            }
            public instructorcs findistructor(int instructorID)
            {
                if (instructors != null)
                {
                    foreach (var instructor in instructors)
                    {
                        if (instructor.InstructorID == instructorID)
                        {
                            return instructor;
                        }
                    }
                }
                return null;
            }
            public bool enrollStudentInCourse(int studentID, int courseID)
            {
                Student student = findstudent(studentID);
                coursecs course = findcourse(courseID);
                if (student != null && course != null)
                {
                    return student.enrollInCourse(course);
                }
                return false;
            }
        
    }
}
