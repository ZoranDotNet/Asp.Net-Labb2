using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Edugrade.Models
{
    public class SchoolClass
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        [DisplayName("Class Name")]
        public string ClassName { get; set; }


        //Relationships
        public ICollection<Student>? Students { get; set; } = new List<Student>();


    }
}
