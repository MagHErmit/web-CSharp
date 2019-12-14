using _4._0_GetPost.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _4._0_GetPost
{
    public class SampleData
    {
        public static void Initialize(EssenceContext context)
        {
            if (!context.Alcohols.Any())
            {
                context.Alcohols.AddRange(
                    new Alcohol
                    {
                        Brand = "Jack Daniel's",
                        Type = "Виски",
                        Strength = 40, 
                        Volume = 5
                    },
                    new Alcohol
                    {
                        Brand = "Триозерье",
                        Type = "Водка",
                        Strength = 40,
                        Volume = 7
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
