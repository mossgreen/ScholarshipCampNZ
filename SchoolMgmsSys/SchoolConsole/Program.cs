using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Data.Entity.Core.Metadata.Edm;
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
            // CreateCourse();
            //GetStudentGradeByCourse();
            //View all  Instructors and display the course they teach
            //GetInstructorsWithCourse();
            // DeleteAStudentById();

            //Delete a Course


            using (var db = new SchoolEntities())
            {
                Console.WriteLine("You can delete a course by couse Id");

                var courses = db.Course.Include(c => c.OnlineCourse)
                    .Include(olc => olc.CourseID)
                    .Include(osc => osc.CourseID)
                    .Include(ci => ci.CourseID)
                    .Include(sg => sg.CourseID);

                foreach (var c in courses)
                {
                    Console.WriteLine($" CourseId: {c.CourseID},  Course Title {c.Title}");
                }

                int courseId = int.Parse(Console.ReadLine());

                var course = db.Course.FirstOrDefault(c => c.CourseID == courseId);
                //var s = db.StudentGrade.Include(sgp => sgp.Person).Include(sgc => sgc.Course).Where(n => n.Person);
                db.OnlineCourse.FirstOrDefault(clc => clc.CourseID == courseId).remove();
                db.Person.FirstOrDefault(p => p.PersonID == sg.StudentID);

                db.SaveChanges();
            }
        }

        private static void DeleteAStudentById()
        {
            using (var db = new SchoolEntities())
            {
                Console.WriteLine("You can delete a student by student Id");

                var students = db.StudentGrade.Include(s => s.Person);

                foreach (var s in students)
                {
                    Console.WriteLine($" StudentId: {s.StudentID}, student name {s.Person.FirstName} {s.Person.LastName}");
                }

                int studentId = int.Parse(Console.ReadLine());

                var sg = db.StudentGrade.Where(s => s.StudentID == studentId);

                foreach (var s in sg)
                {
                    db.StudentGrade.Remove(s);
                   
                }

                var pp = db.Person.FirstOrDefault(p => p.PersonID == studentId);

                db.Person.Remove(pp);

                db.SaveChanges();
            }
        }

        private static void GetInstructorsWithCourse()
        {
            using (var db = new SchoolEntities())
            {
                Console.WriteLine("view all instructors and the course they teach");
                var instructors = db.CourseInstructor.Distinct().Include(ci => ci.Course).Include(ci => ci.Person);

                foreach (var i in instructors)
                {
                    Console.WriteLine($" Name: {i.Person.FirstName} {i.Person.LastName}, course title: {i.Course.Title}");
                }
            }

            Console.ReadLine();
        }

        private static void GetStudentGradeByCourse()
        {
            using (var db = new SchoolEntities())
            {
                Console.WriteLine("To get student grades by course ID as following");
                foreach (var course in db.Course)
                {
                    Console.WriteLine($"{course.Title}: {course.CourseID}");
                }

                int cTitle = int.Parse(Console.ReadLine());

                //var sgs = db.StudentGrade.Where(sg => sg.CourseID == cTitle);
                //foreach (var s in sgs)
                //{
                //    Console.WriteLine($"Student ID: {s.StudentID}");
                //}

                var stus = db.StudentGrade.Include(sg => sg.Person)
                    .Where(sg => sg.CourseID == cTitle).ToList();
                foreach (var  ss in stus)
                {
                    Console.WriteLine($" entollID: {ss.EnrollmentID}, student ID: {ss.StudentID}, student first name: {ss.Person.FirstName}");
                }


                Console.ReadLine();
            }
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
