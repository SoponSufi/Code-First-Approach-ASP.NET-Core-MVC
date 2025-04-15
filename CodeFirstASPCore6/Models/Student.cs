using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirstASPCore6.Models
{
    public class Student
    {
        [Key]
        public int ID { get; set; }

        [Column("StudentName", TypeName ="nvarchar(50)")]
        [Required]
        public string Name { get; set; }

        [Column("StudentGender", TypeName = "nvarchar(50)")]
        [Required]
        public string Gender { get; set; }
        [Required]
        public int Age { get; set; }
        [Required]
        public string Standrad { get; set; }



    }
}
