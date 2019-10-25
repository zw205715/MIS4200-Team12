using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;using System.ComponentModel.DataAnnotations;


namespace MIS4200-Team12.Models
public class myProfile
{
	public myProfile()
	{
        [Key]
    public int employeeID { get; set; }
    public string firstName { get; set; }
    public string lastName { get; set; }
    public string email { get; set; }
    public string phone { get; set; }
    public DateTime employeeSince { get; set; }


}
}


