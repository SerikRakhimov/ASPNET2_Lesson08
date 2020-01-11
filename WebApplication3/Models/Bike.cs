using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication3.Models
{
    public class Bike
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public BikeType BikeType { get; set; }

    }

    public enum BikeType
    {
        Sport,
        Mountain,
        Etc
    }
}