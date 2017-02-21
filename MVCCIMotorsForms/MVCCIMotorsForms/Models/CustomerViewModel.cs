using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCCIMotorsForms.Models
{
    public class CustomerViewModel
    {

        public int CustomerId { get; set; }

        //display annotation will afect the view on "Home/EditStaffMember?staffId=4"
        //@Html.LabelFor will display the name defined here
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Display(Name = "Last Name ")]
        public string LastName { get; set; }
        [Display(Name = "Address1  ")]
        public string Address1 { get; set; }
        [Display(Name = "Address2  ")]
        public string Address2 { get; set; }
        [Display(Name = "Suburb")]
        public string SelectedSuburb { get; set; }

        public IEnumerable<SuburbType> SuburbTypes { get; set; }
        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }
    }
}