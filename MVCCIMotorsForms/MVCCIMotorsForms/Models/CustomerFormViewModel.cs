using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCCIMotorsForms.Models
{
    public class CustomerFormViewModel
    {

        public int CustomerId { get; set; }

        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last Name ")]
        public string LastName { get; set; }

        [Required]
        [Display(Name = "Address1  ")]
        public string Address1 { get; set; }

        [Display(Name = "Address2  ")]
        public string Address2 { get; set; }

        [Required]
        [Display(Name = "Suburb")]
        public int SuburbId { get; set; }

        public string SearchTerm { get; set; }

        public IEnumerable<SuburbType> SuburbTypes { get; set; }

        [Required]
        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }

        public CustomerFormViewModel()
        {
            SuburbTypes = new List<SuburbType>();
        }
    }
}