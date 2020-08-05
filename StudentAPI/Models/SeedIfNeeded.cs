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
                    new Student { Name = "A. Nafi", Roll = 1, StudentClass = 10, Section = "D", SscGpa = 5.00, BloodGroup = "B+", Father = "Hasan", Mother = "Unknown", BirthDate="Unknown", City = "Bogra" },
                    new Student { Name = "Usha A. Khan", Roll = 2, StudentClass = 10, BloodGroup = "A+", SscGpa = 5.00, Section = "D", Father = "Oli", Mother = "Unknown", BirthDate = "Unknown", City = "Naogaon" },
                    new Student { Name = "Sirat", Roll = 3, StudentClass = 10, BloodGroup = "B+", SscGpa = 5.00, Section = "D", Father = "Rafiqul Islam", Mother = "Ruma Parvin", BirthDate = "25 Oct 2005", City = "Naogaon" },
                    new Student { Name = "Farhan Sadique", Roll = 1, StudentClass = 10, BloodGroup = "B+", SscGpa = 5.00, Section = "C", Father = "Unknown", Mother = "Unknown", BirthDate = "Unknown", City = "Naogaon" },
                    new Student { Name = "A. Faisal", Roll = 5, StudentClass = 10, BloodGroup = "O+", SscGpa = 5.00, Section = "D", Father = "Unknown", Mother = "Unknown", BirthDate = "24 Sept 2005", City = "Naogaon" },
                    new Student { Name = "Sadman S.", Roll = 9, StudentClass = 10, BloodGroup = "AB+", SscGpa = 5.00, Section = "C", Father = "Unknown", Mother = "Unknown", BirthDate = "Unknown", City = "Naogaon" },
                    new Student { Name = "Sadman S.", Roll = 34, StudentClass = 9, BloodGroup = "B+", SscGpa = 5.00, Section = "D", Father = "Unknown", Mother = "Unknown", BirthDate = "Unknown", City = "Naogaon" },
                    new Student { Name = "Sadman S.", Roll = 20, StudentClass = 10, BloodGroup = "O-", SscGpa = 5.00, Section = "D", Father = "Unknown", Mother = "Unknown", BirthDate = "Unknown", City = "Naogaon" });
            }
            context.SaveChanges();
        }
    }
}
