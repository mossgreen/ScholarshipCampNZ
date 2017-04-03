using System;
using System.Collections.Generic;

namespace ContosoUniversity.Models
{
    public class Student
    {

        //By default, EF interprets a property that's named ID or classnameID as the primary key.
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstMidName { get; set; }
        public DateTime EnrollmentDate { get; set; }


        /*The Enrollments property is a navigation property. 
         * Navigation properties hold other entities that are related to this entity.
         * If you specify ICollection<T>, EF creates a HashSet<T> collection by default.*/
        public ICollection<Enrollment> Enrollments { get; set; }
    }
}