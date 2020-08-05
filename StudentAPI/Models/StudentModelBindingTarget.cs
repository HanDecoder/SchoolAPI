using System.ComponentModel.DataAnnotations;

namespace StudentAPI.Models
{
    public class StudentModelBindingTarget
    {
        [Required]
        public string Name { get; set; }

        public long StudentID { get; set; }
        public string Father { get; set; }
        public string Mother { get; set; }
        public long StudentClass { get; set; }
        public string Section { get; set; }
        public string BloodGroup { get; set; }
        public double SscGpa { get; set; }
        public string BirthDate { get; set; }
        public long Roll { get; set; }
        [Required]
        public string City { get; set; }

        public Student ToStudent() => new Student() {
            Name = this.Name,
            Father = this.Father,
            Mother = this.Mother,
            City = this.City,
            StudentClass = this.StudentClass,
            Section = this.Section,
            Roll = this.Roll,
            BloodGroup = this.BloodGroup,
            SscGpa = this.SscGpa,
            BirthDate = this.BirthDate,
        };
    }
}
