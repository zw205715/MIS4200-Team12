using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace MIS4200_Team12.Models
{
    public class TheProfile
    {
        [Key]
        [Display(Name = "Identification Number")]
        public int employeeID { get; set; }
        [Display(Name = "First Name")]
        public string firstName { get; set; }
        [Display(Name = "Last Name")]
        public string lastName { get; set; }
        [Display(Name = "Email")]
        public string email { get; set; }
        [Display(Name = "Phone")]
        public string phone { get; set; }
        [Display(Name = "Start Date")]
        public DateTime employeeSince { get; set; }
    }
}