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
                    new Student { Name = "Sadman S.", Roll = 21, StudentClass = 10, BloodGroup = "O-", SscGpa = 5.00, Section = "D", Father = "Unknown", Mother = "Unknown", BirthDate = "Unknown", City = "Naogaon" },
                    new Student { Name = "Sadman S.", Roll = 22, StudentClass = 10, BloodGroup = "O-", SscGpa = 5.00, Section = "D", Father = "Unknown", Mother = "Unknown", BirthDate = "Unknown", City = "Naogaon" },
                    new Student { Name = "Sadman S.", Roll = 23, StudentClass = 10, BloodGroup = "O-", SscGpa = 5.00, Section = "D", Father = "Unknown", Mother = "Unknown", BirthDate = "Unknown", City = "Naogaon" },
                    new Student { Name = "Sadman S.", Roll = 24, StudentClass = 10, BloodGroup = "O-", SscGpa = 5.00, Section = "D", Father = "Unknown", Mother = "Unknown", BirthDate = "Unknown", City = "Naogaon" },
                    new Student { Name = "Sadman S.", Roll = 25, StudentClass = 10, BloodGroup = "O-", SscGpa = 5.00, Section = "D", Father = "Unknown", Mother = "Unknown", BirthDate = "Unknown", City = "Naogaon" },
                    new Student { Name = "Sadman S.", Roll = 26, StudentClass = 10, BloodGroup = "O-", SscGpa = 5.00, Section = "D", Father = "Unknown", Mother = "Unknown", BirthDate = "Unknown", City = "Naogaon" },
                    new Student { Name = "Sadman S.", Roll = 27, StudentClass = 10, BloodGroup = "O-", SscGpa = 5.00, Section = "D", Father = "Unknown", Mother = "Unknown", BirthDate = "Unknown", City = "Naogaon" },
                    new Student { Name = "Sadman S.", Roll = 28, StudentClass = 10, BloodGroup = "O-", SscGpa = 5.00, Section = "D", Father = "Unknown", Mother = "Unknown", BirthDate = "Unknown", City = "Naogaon" },
                    new Student { Name = "Sadman S.", Roll = 29, StudentClass = 10, BloodGroup = "O-", SscGpa = 5.00, Section = "D", Father = "Unknown", Mother = "Unknown", BirthDate = "Unknown", City = "Naogaon" },
                    new Student { Name = "Sadman S.", Roll = 30, StudentClass = 10, BloodGroup = "O-", SscGpa = 5.00, Section = "D", Father = "Unknown", Mother = "Unknown", BirthDate = "Unknown", City = "Naogaon" },
                    new Student { Name = "Sadman S.", Roll = 31, StudentClass = 10, BloodGroup = "O-", SscGpa = 5.00, Section = "D", Father = "Unknown", Mother = "Unknown", BirthDate = "Unknown", City = "Naogaon" },
                    new Student { Name = "Sadman S.", Roll = 32, StudentClass = 10, BloodGroup = "O-", SscGpa = 5.00, Section = "D", Father = "Unknown", Mother = "Unknown", BirthDate = "Unknown", City = "Naogaon" },
                    new Student { Name = "Sadman S.", Roll = 33, StudentClass = 10, BloodGroup = "O-", SscGpa = 5.00, Section = "D", Father = "Unknown", Mother = "Unknown", BirthDate = "Unknown", City = "Naogaon" },
                    new Student { Name = "Sadman S.", Roll = 34, StudentClass = 10, BloodGroup = "O-", SscGpa = 5.00, Section = "D", Father = "Unknown", Mother = "Unknown", BirthDate = "Unknown", City = "Naogaon" },
                    new Student { Name = "Sadman S.", Roll = 35, StudentClass = 10, BloodGroup = "O-", SscGpa = 5.00, Section = "D", Father = "Unknown", Mother = "Unknown", BirthDate = "Unknown", City = "Naogaon" },
                    new Student { Name = "Sadman S.", Roll = 36, StudentClass = 10, BloodGroup = "O-", SscGpa = 5.00, Section = "D", Father = "Unknown", Mother = "Unknown", BirthDate = "Unknown", City = "Naogaon" },
                    new Student { Name = "Sadman S.", Roll = 37, StudentClass = 10, BloodGroup = "O-", SscGpa = 5.00, Section = "D", Father = "Unknown", Mother = "Unknown", BirthDate = "Unknown", City = "Naogaon" },
                    new Student { Name = "Sadman S.", Roll = 38, StudentClass = 10, BloodGroup = "O-", SscGpa = 5.00, Section = "D", Father = "Unknown", Mother = "Unknown", BirthDate = "Unknown", City = "Naogaon" },
                    new Student { Name = "Sadman S.", Roll = 39, StudentClass = 10, BloodGroup = "O-", SscGpa = 5.00, Section = "D", Father = "Unknown", Mother = "Unknown", BirthDate = "Unknown", City = "Naogaon" },
                    new Student { Name = "Sadman S.", Roll = 40, StudentClass = 10, BloodGroup = "O-", SscGpa = 5.00, Section = "D", Father = "Unknown", Mother = "Unknown", BirthDate = "Unknown", City = "Naogaon" },
                    new Student { Name = "Sadman S.", Roll = 41, StudentClass = 10, BloodGroup = "O-", SscGpa = 5.00, Section = "D", Father = "Unknown", Mother = "Unknown", BirthDate = "Unknown", City = "Naogaon" },
                    new Student { Name = "Sadman S.", Roll = 42, StudentClass = 10, BloodGroup = "O-", SscGpa = 5.00, Section = "D", Father = "Unknown", Mother = "Unknown", BirthDate = "Unknown", City = "Naogaon" },
                    new Student { Name = "Sadman S.", Roll = 43, StudentClass = 10, BloodGroup = "O-", SscGpa = 5.00, Section = "D", Father = "Unknown", Mother = "Unknown", BirthDate = "Unknown", City = "Naogaon" },
                    new Student { Name = "Sadman S.", Roll = 44, StudentClass = 10, BloodGroup = "O-", SscGpa = 5.00, Section = "D", Father = "Unknown", Mother = "Unknown", BirthDate = "Unknown", City = "Naogaon" },
                    new Student { Name = "Sadman S.", Roll = 45, StudentClass = 10, BloodGroup = "O-", SscGpa = 5.00, Section = "D", Father = "Unknown", Mother = "Unknown", BirthDate = "Unknown", City = "Naogaon" },
                    new Student { Name = "Sadman S.", Roll = 46, StudentClass = 10, BloodGroup = "O-", SscGpa = 5.00, Section = "D", Father = "Unknown", Mother = "Unknown", BirthDate = "Unknown", City = "Naogaon" },
                    new Student { Name = "Sadman S.", Roll = 47, StudentClass = 10, BloodGroup = "O-", SscGpa = 5.00, Section = "D", Father = "Unknown", Mother = "Unknown", BirthDate = "Unknown", City = "Naogaon" },
                    new Student { Name = "Sadman S.", Roll = 48, StudentClass = 10, BloodGroup = "O-", SscGpa = 5.00, Section = "D", Father = "Unknown", Mother = "Unknown", BirthDate = "Unknown", City = "Naogaon" },
                    new Student { Name = "Sadman S.", Roll = 49, StudentClass = 10, BloodGroup = "O-", SscGpa = 5.00, Section = "D", Father = "Unknown", Mother = "Unknown", BirthDate = "Unknown", City = "Naogaon" },
                    new Student { Name = "Sadman S.", Roll = 50, StudentClass = 10, BloodGroup = "O-", SscGpa = 5.00, Section = "D", Father = "Unknown", Mother = "Unknown", BirthDate = "Unknown", City = "Naogaon" }
                    );
            }
            context.SaveChanges();
        }
    }
}
