using System.ComponentModel.DataAnnotations;

namespace Edugrade.Models
{
    public class Course
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }


        //Relationships
        public ICollection<Enrollment>? Enrollments { get; set; }
    }
}
