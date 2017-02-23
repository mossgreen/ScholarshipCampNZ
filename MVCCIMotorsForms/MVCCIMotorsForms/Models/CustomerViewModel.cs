using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCCIMotorsForms.Models
{
    public class CustomerViewModel
    {
        public List<Person> Customers { get; set; }
        public string SearchTerm { get; set; }
    }
}