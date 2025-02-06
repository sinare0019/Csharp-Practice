using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Practice_1.Domain
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        [Column(TypeName = "nvarchar(200)")]
        [Required]
        public string Name { get; set; }
        [Column(TypeName = "nvarchar(200)")]
        [Required]
        public string FamilyName { get; set; }
        public Teacher Teacher { get; set; }
        [ForeignKey("Teacher_Id")]
        [Required]
        public int Teacher_Id { get; set; }
    }
}
