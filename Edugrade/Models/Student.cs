using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Edugrade.Models
{
    public class Student
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Firstname { get; set; }

        [Required]
        [MaxLength(50)]
        public string Lastname { get; set; }

        [Required]
        [MaxLength(100)]
        public string Email { get; set; }

        [Required]
        [Column(TypeName = "varchar(20)")]
        [DisplayName("Phone Number")]
        public string PhoneNumber { get; set; }

        [MaxLength(100)]
        public string Fullname => $"{Firstname} {Lastname}";

        [DisplayName("Date of Birth")]
        public DateTime DateOfBirth { get; set; }

        //Relationships

        [ForeignKey("SchoolClass")]
        public int? FkSchoolClassId { get; set; }
        public SchoolClass? SchoolClass { get; set; }

        public ICollection<Enrollment>? Enrollments { get; set; }
    }
}
