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
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Display(Name = "Last Name ")]
        public string LastName { get; set; }       
        [Display(Name = "Address1  ")]
        public string Address1 { get; set; }
        [Display(Name = "Salary")]
        public Nullable<decimal> Salary { get; set; }
    }
}