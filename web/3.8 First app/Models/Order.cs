using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _3._8_First_app.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public string User { get; set; }
        public string Address { get; set; }
        public string ContactPhone { get; set; }

        public int TabletId { get; set; }
        public virtual Tablet Tablet { get; set; }
    }
}
