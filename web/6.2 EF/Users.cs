using System;
using System.Collections.Generic;

namespace _6._2_EF
{
    public partial class Users
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? Age { get; set; }
        public int? PhoneId { get; set; }
        

        public virtual Phones Phone { get; set; }
    }
} 
