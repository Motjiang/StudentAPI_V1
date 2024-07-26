using System.ComponentModel.DataAnnotations;

namespace StudentAPI_V1.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Grade { get; set; }
        public string Email { get; set; }
    }
}
