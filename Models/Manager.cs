using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MIS4200_Team12.Models
{
    public class Manager
    {

        [Key]

        [Display (Name = "Identification Number") ]
        [Required]
        public int managerID { get; set; }
        

        [Display(Name = "First Name")]
        [Required]
        [StringLength(25)]
        public string firstName { get; set; }


        [Display(Name = "Last Name")]
        [Required]
        [StringLength(25)]
        public string lastName { get; set; }


        [Display(Name = "Email")]
        [Required]
        [EmailAddress(ErrorMessage = "Please enter a valid email address.")]
        public string email { get; set; }


        [Display(Name = "Phone Number")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"(\(\d{3}\) |\d{3}-)\d{3}-\d{4}$",
            ErrorMessage = "Phone number must be in the format (xxx) xxx-xxxx OR xxx-xxx-xxxx")]
        public string phone { get; set; }


        [Display(Name = "Date Started as a Manager")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
        public DateTime managerSince { get; set; }

    }

}