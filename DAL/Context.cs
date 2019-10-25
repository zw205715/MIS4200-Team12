using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MIS4200_Team12.Models; // This is needed to access the models
using System.Data.Entity; // this is needed to access the DbContext object

namespace MIS4200_Team12.DAL
{
    public class Context() : base("name=DefaultConnection")
    {
    
        public DbSet<TheProfile> TheProfile { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
    }
}




