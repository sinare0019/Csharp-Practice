using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Practice_1.Domain
{
    public class Teacher
    {
        [Key]
        public int Id { get; set; }
        [Column(TypeName = "nvarchar(200)")]
        [Required]
        public string Name { get; set; }
        [Column(TypeName = "nvarchar(200)")]
        [Required]
        public string FamilyName { get; set; }
        [NotMapped]
        public ICollection<Student> Students { get; set; }
    }
}
