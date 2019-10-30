using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MIS4200_Team12.Models; // This is needed to access the models
using System.Data.Entity; // this is needed to access the DbContext object

namespace MIS4200_Team12.DAL
{
    public class MIS4200Context : DbContext
    {
        public class Context : DbContext // inherits from DbContext
        {
            public Context() : base("name=DefaultConnection")
            {
                // this method is a 'constructor' and is called when a new context is created
                // the base attribute says which connection string to use
            }
            // Include each object here. The value inside <> is the name of the class,
            // the value outside should generally be the plural of the class name
            // and is the name used to reference the entity in code
            public DbSet<TheProfile> TheProfiles { get; set; }
            public DbSet<Manager> Managers { get; set; }
           
        }

        public System.Data.Entity.DbSet<MIS4200_Team12.Models.TheProfile> TheProfiles { get; set; }

        public System.Data.Entity.DbSet<MIS4200_Team12.Models.Manager> Managers { get; set; }
    }
}




