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

                string dId = Console.ReadLine();

                var p = new Person();
                p.FirstName = pFirstName;
                p.LastName = pLastName;

                var c = new Course();
                c.Title = cTitle;

                var d = new Department();
                d.DepartmentID = int.Parse(dId);
                db.Department.Add(d);

                db.Person.Add(p);
                db.Course.Add(c);
                db.SaveChanges();

                var ci = new CourseInstructor();
                ci.CourseID = c.CourseID;
                ci.PersonID = p.PersonID;
                db.CourseInstructor.Add(ci);

                Console.WriteLine($"FirstName: {p.FirstName}");

                Console.ReadLine();
            }

        }
    }
}
