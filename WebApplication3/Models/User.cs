using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication3.Models
{
    public class User:ApplicationUser
    {
        public int Age { get; set; }
        public bool Gender { get; set; }
        public virtual IList<Car> Cars { get; set; } = new List<Car>();
    }
}