using _3._8_First_app.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _3._8_First_app
{
    public class SampleData
    {
        public static void Initialize(TabletContext context)
        {
            if (!context.Phones.Any())
            {
                context.Phones.AddRange(
                    new Tablet
                    {
                        Name = "Ipad Air Pro",
                        Company = "Apple",
                        Price = 6000
                    },
                    new Tablet
                    {
                        Name = "Samsung Galaxy Tablet",
                        Company = "Samsung",
                        Price = 4500
                    },
                    new Tablet
                    {
                        Name = "Android Tablet",
                        Company = "Huawei",
                        Price = 500
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
