using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            // CreateInstructor();
            //CreateStudent();
            CreateCourse();
        }

        private static void CreateCourse()
        {
            using (var db = new SchoolEntities())
            {
                Console.WriteLine("Please type a course name");
                string cTitle = Console.ReadLine();

                Console.WriteLine("Please type Department Id");

                foreach (var department in db.Department)
                {
                    Console.WriteLine($"{department.Name}: {department.DepartmentID}");
                }

                int dId = int.Parse(Console.ReadLine());

                string dName = db.Department.FirstOrDefault(n => n.DepartmentID == dId).Name;

                var c = new Course();
                c.Title = cTitle;
                c.DepartmentID = dId;

                db.Course.Add(c);
                db.SaveChanges();

                Console.WriteLine($"Course title: {c.Title}, the Department is {dName}");

                Console.ReadLine();
            }
        }

        private static void CreateStudent()
        {
            using (var db = new SchoolEntities())
            {
                Console.WriteLine("Please type Student's first name");
                string sFirstName = Console.ReadLine();

                Console.WriteLine("Please type Student's last name");
                string sLastName = Console.ReadLine();

                Console.WriteLine("Please type Course title for this student");

                string cTitle = Console.ReadLine();

                Console.WriteLine("Please type Department Id");

                foreach (var department in db.Department)
                {
                    Console.WriteLine($"{department.Name}: {department.DepartmentID}");
                }

                int dId = int.Parse(Console.ReadLine());

                var p = new Person();
                p.FirstName = sFirstName;
                p.LastName = sLastName;

                var c = new Course();
                c.Title = cTitle;
                c.DepartmentID = dId;


                db.Person.Add(p);
                db.Course.Add(c);
                db.SaveChanges();

                var sg = new StudentGrade();
                sg.CourseID = c.CourseID;
                sg.StudentID = p.PersonID;
                db.StudentGrade.Add(sg);

                Console.WriteLine($"FirstName: {p.FirstName}, Last Name: {p.LastName}, Course title: {c.Title}");

                Console.ReadLine();
            }
        }


        private static void CreateInstructor()
        {
            using (var db = new SchoolEntities())
            {
                Console.WriteLine("Please type Course Instructor's first name");
                string pFirstName = Console.ReadLine();

                Console.WriteLine("Please type Course Instructor's last name");
                string pLastName = Console.ReadLine();

                Console.WriteLine("Please type Course title");

                string cTitle = Console.ReadLine();

                Console.WriteLine("Please type Department Id");

                foreach (var department in db.Department)
                {
                    Console.WriteLine($"{department.Name}: {department.DepartmentID}");
                }

                int dId = int.Parse(Console.ReadLine());


                var p = new Person();
                p.FirstName = pFirstName;
                p.LastName = pLastName;

                var c = new Course();
                c.Title = cTitle;
                c.DepartmentID = dId;

                db.Person.Add(p);
                db.Course.Add(c);
                db.SaveChanges();

                var ci = new CourseInstructor();
                ci.CourseID = c.CourseID;
                ci.PersonID = p.PersonID;
                db.CourseInstructor.Add(ci);

                Console.WriteLine($"FirstName: {p.FirstName}, Course title: {c.Title}");

                Console.ReadLine();
            }
        }
    }
}
