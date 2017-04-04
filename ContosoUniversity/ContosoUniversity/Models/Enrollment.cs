using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity.Models
{
    public enum Grade
    {
        A, B, C, D, F
    }

    public class Enrollment
    {
        public int EnrollmentID { get; set; }

        /*An enrollment record is for a single course, 
         * so there's a CourseID foreign key property and a Course navigation property:*/
        public int CourseID { get; set; }
        public Course Course { get; set; }


        [DisplayFormat(NullDisplayText = "No grade")]
        public Grade? Grade { get; set; } // Grade property is nullable


        /*An Enrollment entity is associated with one Student entity, 
         * so the property can only hold a single Student entity */
        public int StudentID { get; set; }
        public Student Student { get; set; }
    }
}