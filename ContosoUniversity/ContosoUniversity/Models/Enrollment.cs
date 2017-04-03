namespace ContosoUniversity.Models
{
    public enum Grade
    {
        A, B, C, D, F
    }

    public class Enrollment
    {
        public int EnrollmentID { get; set; }
        public int CourseID { get; set; }
        public int StudentID { get; set; }
        public Grade? Grade { get; set; } // Grade property is nullable

        public Course Course { get; set; }

        /*An Enrollment entity is associated with one Student entity, 
         * so the property can only hold a single Student entity */
        public Student Student { get; set; }
    }
}