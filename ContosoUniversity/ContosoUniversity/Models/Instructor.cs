using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity.Models
{
    public class Instructor
    {
        public int ID { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        [StringLength(50)]
        public string LastName { get; set; }

        [Required]
        [Column("FirstName")]
        [Display(Name = "First Name")]
        [StringLength(50)]
        public string FirstMidName { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Hire Date")]
        public DateTime HireDate { get; set; }

        [Display(Name = "Full Name")]
        public string FullName
        {
            get { return LastName + ", " + FirstMidName; }
        }

        /*An instructor can teach any number of courses, so CourseAssignments is defined as a collection.*/
        public ICollection<CourseAssignment> CourseAssignments { get; set; }

        /*Contoso University business rules state that an instructor can only have at most one office, 
         * so the OfficeAssignment property holds a single OfficeAssignment entity 
         * (which may be null if no office is assigned).*/
        public OfficeAssignment OfficeAssignment { get; set; }
    }
}