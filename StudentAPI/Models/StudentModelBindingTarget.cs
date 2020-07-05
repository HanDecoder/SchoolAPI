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

        [Required]
        public string City { get; set; }

        public Student ToStudent() => new Student() {
            Name = this.Name,
            Father = this.Father,
            Mother = this.Mother,
            City = this.City
        };
    }
}
