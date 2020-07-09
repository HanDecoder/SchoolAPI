using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;


namespace StudentAPI.Models
{
    public class SeedIfNeeded
    {
        public static void CheckAndFill(DataContext context)
        {
            if (context.Database.GetPendingMigrations().Any())
                context.Database.Migrate();
            if(!context.Students.Any())
            {
                context.Students.AddRange(
                    new Student { Name = "A. Nafi", Father = "Hasan", Mother = "Unknown", City = "Naogaon" },
                    new Student { Name = "Usha A. Khan", Father = "Oli", Mother = "Unknown", City = "Naogaon" },
                    new Student { Name = "Sirat", Father = "Rafiq", Mother = "Ruma", City = "Naogaon" },
                    new Student { Name = "Unknown", Father = "Unknown", Mother = "Unknown", City = "Naogaon" },
                    new Student { Name = "Unknown", Father = "Unknown", Mother = "Unknown", City = "Naogaon" },
                    new Student { Name = "Unknown", Father = "Unknown", Mother = "Unknown", City = "Naogaon" });
            }
            context.SaveChanges();
        }
    }
}
