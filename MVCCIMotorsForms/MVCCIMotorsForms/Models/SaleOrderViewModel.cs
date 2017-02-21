using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCCIMotorsForms.Models
{
    public class SaleOrderViewModel
    {
       
        public int SaleOrderId { get; set; }

        [Required]
        [Display(Name = "Order Date")]
        public DateTime OrderDate { get; set; }

        [Required]
        [Display(Name = "PersonId")]
        public int PersonId { get; set; }

        [StringLength(20, ErrorMessage = "orderNumbver must be at most 20 characters")]
        [Display(Name = "Order Number")]
        public string OrderNumber { get; set; }

    }
}