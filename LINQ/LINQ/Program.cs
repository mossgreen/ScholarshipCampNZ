using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            //1 highestScore
            var highestScore = students.Max(s => s.Scores.Sum());
            var studentWithHighestScore = students.Find(s => s.Scores.Sum().Equals(highestScore));
            Console.Write($"the student with hightest score is: \n---->{studentWithHighestScore.ToString()}\n");

            //2 Display students with first name length greater than 10
            Console.WriteLine($"\nDisplay students with first name length greater than 10");
            var studentWithFirstNameLengthG10 = students.FindAll(s => s.First.Length > 10);
            printList(studentWithFirstNameLengthG10);

            //3. Display student with total score greater than 270
            Console.WriteLine($"\nDisplay student with total score greater than 270: ");
            var studentWithTotalScoreG70 = students.FindAll(s => s.Scores.Sum() > 270);
            printList(studentWithTotalScoreG70);

            //4. Print students with reversed name
            Console.WriteLine($"\nPrint students with reversed name: ");
            List<Student> reverseStudents = new List<Student>(students.ToList());

            reverseStudents.ForEach(s => s.First = new string(s.First.Reverse().ToArray()));
            reverseStudents.ForEach(s => s.Last = new string(s.Last.Reverse().ToArray()));
            printList(reverseStudents);

            reverseStudents.ForEach(s => s.First = new string(s.First.Reverse().ToArray()));
            reverseStudents.ForEach(s => s.Last = new string(s.Last.Reverse().ToArray()));
            printList(students);


            //5. a new List has FirstName and LastName property
            Console.WriteLine($"\n a new List has FirstName and LastName property: ");
            List<Student> newStudents;
            newStudents = students.Select(s => new Student {First = s.First, Last = s.Last}).ToList();
            printList(newStudents);


            //6.Print students with First name Descending order
            Console.WriteLine($"\nPrint students with First name Descending order");
            List<Student> firstNameDescStudents = new List<Student>(students.ToList());

            var first = firstNameDescStudents.OrderByDescending(s => s.First);

            foreach (var s in first)
            {
                Console.WriteLine(s.ToString());
            }

            //7. Print students with Last name Ascending order
            Console.WriteLine($"\nPrint students with Last name Ascending order");
            List<Student> lastNameDescStudents = new List<Student>(students.ToList());

            var last = lastNameDescStudents.OrderBy(s => s.Last);

            foreach (var s in last)
            {
                Console.WriteLine(s.ToString());
            }
            Console.ReadKey();
        }

        private static void printList(List<Student> sl)
        {
            if (sl.Count == 0)
            {
                Console.WriteLine("---->none of them qualified to this requirement.");
            }
            else
            {
                foreach (var s in sl)
                {
                    Console.WriteLine($"---->{s.ToString()}");
                }
            }
        }

        static List<Student> students = new List<Student>
        {
           new Student {First="Svetlana", Last="Omelchenko", ID=111, Scores= new List<int> {97, 92, 81, 60}},
           new Student {First="Claire", Last="O'Donnell", ID=112, Scores= new List<int> {75, 84, 91, 39}},
           new Student {First="Sven", Last="Mortensen", ID=113, Scores= new List<int> {88, 94, 65, 91}},
           new Student {First="Cesar", Last="Garcia", ID=114, Scores= new List<int> {97, 89, 85, 82}},
           new Student {First="Debra", Last="Garcia", ID=115, Scores= new List<int> {35, 72, 91, 70}},
           new Student {First="Fadi", Last="Fakhouri", ID=116, Scores= new List<int> {99, 86, 90, 94}},
           new Student {First="Hanying", Last="Feng", ID=117, Scores= new List<int> {93, 92, 80, 87}},
           new Student {First="Hugo", Last="Garcia", ID=118, Scores= new List<int> {92, 90, 83, 78}},
           new Student {First="Lance", Last="Tucker", ID=119, Scores= new List<int> {68, 79, 88, 92}},
           new Student {First="Terry", Last="Adams", ID=120, Scores= new List<int> {99, 82, 81, 79}},
           new Student {First="Eugene", Last="Zabokritski", ID=121, Scores= new List<int> {96, 85, 91, 60}},
           new Student {First="Michael", Last="Tucker", ID=122, Scores= new List<int> {94, 92, 91, 91} }
        };

    }

    public class Student
    {
        public string First { get; set; }
        public string Last { get; set; }
        public int ID { get; set; }
        public List<int> Scores;

        public override string ToString()
        {
            if (this.Scores != null)
            {
                return $"ID: {ID}, FirstName:{this.First}, Lastname: {Last}, TotalScore: {this.Scores.Sum()}";
            }
            else
            {
                return $"FirstName:{this.First}, Lastname: {Last}";
            }
        }
    }

    // Create a data source by using a collection initializer.

}
