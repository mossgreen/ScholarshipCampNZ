using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace ContosoUniversity.Models
{
    public class Student:Person
    {

        //By default, EF interprets a property that's named ID or classnameID as the primary key.
        public int ID { get; set; }

        /*inherits from Person Class*/

        /*The StringLength attribute won't prevent a user from entering white space for a name. 
         * You can use the RegularExpression attribute to apply restrictions to the input.*/
        //[Required]
        //[StringLength(50)]
        //[RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$")]
        //[Display(Name = "Last Name")]
        //public string LastName { get; set; }

        //[Required]
        //[StringLength(50, ErrorMessage = "First name cannot be longer than 50 characters.")]
        //[Column("FirstName")]
        //[Display(Name = "First Name")]
        //public string FirstMidName { get; set; }

        //[Display(Name = "Full Name")]
        //public string FullName
        //{
        //    get
        //    {
        //        return LastName + ", " + FirstMidName;
        //    }
        //}

        /*The DataType attribute is used to specify a data type that is more specific 
         * than the database intrinsic type. 
         * In this case we only want to keep track of the date, not the date and time.*/
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Enrollment Date")]
        public DateTime EnrollmentDate { get; set; }




        /*The Enrollments property is a navigation property. 
         * Navigation properties hold other entities that are related to this entity.
         * If you specify ICollection<T>, EF creates a HashSet<T> collection by default.*/
        public ICollection<Enrollment> Enrollments { get; set; }
    }
}