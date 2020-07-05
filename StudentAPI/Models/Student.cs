using System.ComponentModel.DataAnnotations;

namespace StudentAPI.Models
{
    public class Student
    {
        [Required]
        public string Name { get; set; }

        [Range(1, 255)]
        public long StudentID { get; set; }
        public string Father { get; set; }
        public string Mother { get; set; }

        [Required]
        public string City { get; set; }
        public string Country { get; set; } = "Bangladesh";
    }
}
