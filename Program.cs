using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Studentproject
{
    internal static class Program
    {
       
        static void Main()
        {
            while (true)
            {
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Menu");
                Console.WriteLine("1. Add Student");
                Console.WriteLine("2. Add Instructor");
                Console.WriteLine("3. Add Course");
                Console.WriteLine("4. Enroll Student in Course");
                Console.WriteLine("5. Show all student");
                Console.WriteLine("6. Show all instructor");
                Console.WriteLine("7. Show all clourses");
                Console.WriteLine("8,Fine the course by id or name");
                Console.WriteLine("9,Fine the course by id or name");
                Console.WriteLine("10. Exit");
                Console.Write("Enter your choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());
                StudentManager manager = new StudentManager();
                if (choice == 1)
                {
                    manager.addStudent(new Student { StudentID = Convert.ToInt32(Console.ReadLine()), name = Console.ReadLine(), age = Convert.ToInt32(Console.ReadLine()) });
                }
                else if (choice == 2)
                {
                    manager.addInstructor(new instructorcs { InstructorID = Convert.ToInt32(Console.ReadLine()), name = Console.ReadLine(), department = Console.ReadLine(), specialization = Console.ReadLine() });
                }
                else if (choice == 3)
                {
                    manager.addcourse(new coursecs { CourseID = Convert.ToInt32(Console.ReadLine()), title = Console.ReadLine() });

                }
                else if (choice == 4)
                {
                    manager.enrollStudentInCourse(new Student { StudentID = Convert.ToInt32(Console.ReadLine()) }.StudentID, new coursecs { CourseID = Convert.ToInt32(Console.ReadLine()) }.CourseID);
                }
                else if (choice == 5)
                {
                    Student students = new Student();
                    students.printDetails();

                }
                else if (choice == 6)
                {
                    instructorcs instructors = new instructorcs();
                    instructors.printDetails();
                }
                else if (choice == 7)
                {
                    coursecs c = new coursecs();
                    c.printDetails();
                }
                else if (choice == 10)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid choice. Please try again.");
                }
            }

        }
    }
}
