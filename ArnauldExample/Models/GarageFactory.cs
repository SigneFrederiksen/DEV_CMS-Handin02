using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data.Entity;

namespace ArnauldExample.Models
{
    public class GarageFactory : DbContext
    {
        public DbSet<Car> Cars { get; set; }

        public GarageFactory()
        {
            Database.SetInitializer(new GarageInitializer());
        }
    }

    public class GarageInitializer : DropCreateDatabaseIfModelChanges<GarageFactory>
    {
        protected override void Seed(GarageFactory context)
        {
            context.Cars.Add(new Car { Model = "Rabbit", MaxSpeed = 300 });
            context.Cars.Add(new Car { Model = "Turtle", MaxSpeed = 150 });
        }
    }
}