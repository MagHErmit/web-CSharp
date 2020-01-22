using System;
using System.Collections.Generic;

namespace _6._2_EF
{
    public partial class Phones
    {
        public Phones()
        {
            Users = new HashSet<Users>();
        }

        public int Id { get; set; }
        public int? Cost { get; set; }
        public string Model { get; set; }
        public string Company { get; set; }
        public bool IsChina { get; set; }

        public virtual ICollection<Users> Users { get; set; }
    }
}
