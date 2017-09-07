using DiagnostisktTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiagnostisktTest.Data
{
    public class DBInitializer
    {
        public static void Initialize(ApplicationDbContext context)
        {
            var vhs = new ProductCategory{ Name = "VHS"};
            context.Add(vhs);
            var dvd = new ProductCategory { Name = "DVD" };
            context.Add(dvd);
            var tv = new ProductCategory { Name = "TV" };
            context.Add(tv);
            context.SaveChanges();
        }
    }
}
