using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MVCCIMotorsForms.Models
{
    public class StaffClass
    {
        public int StaffId { get; set; }

        //display annotation will afect the view on "Home/EditStaffMember?staffId=4"
        //@Html.LabelFor will display the name defined here
        [Display(Name = "First Name")]
        [Required]
        public string FirstName { get; set; }
        [Display(Name = "Last Name ")]
        [Required]
        public string LastName { get; set; }       
        [Display(Name = "Address1  ")]
        [Required]
        public string Address1 { get; set; }
        [Display(Name = "Address2  ")]
        public string Address2 { get; set; }

        [Display(Name = "Phone Number  ")]
        [Required]
        public string PhoneNumber { get; set; }
        [Display(Name = "Salary")]
        [Required]
        public Nullable<decimal> Salary { get; set; }

        [Display(Name = "Suburb")]
        [Required]
        public int SuburbId { get; set; }

        public IEnumerable<SuburbType> SuburbTypes { get; set; }
    }
}