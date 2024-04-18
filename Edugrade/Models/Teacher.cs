using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Edugrade.Models
{
    public class Teacher
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Firstname { get; set; }

        [Required]
        [MaxLength(50)]
        public string Lastname { get; set; }

        [MaxLength(100)]
        public string Fullname => $"{Firstname} {Lastname}";

        [Required]
        [Column(TypeName = "varchar(20)")]
        [DisplayName("Phone Number")]
        public string PhoneNumber { get; set; }

        [Required]
        [MaxLength(100)]
        public string Email { get; set; }

        [DisplayName("Date of Birth")]
        public DateTime DateOfBirth { get; set; }

        //Relationships
        public ICollection<Enrollment>? Enrollments { get; set; }
    }
}
