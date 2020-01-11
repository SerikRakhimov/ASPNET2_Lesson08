using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication3.Models
{
    public class MyOwnDbContext:DbContext
    {
        public DbSet<Bike> Bikes { get; set; }
        public MyOwnDbContext() : base("DefaultConnection")
        {

        }

    }
}