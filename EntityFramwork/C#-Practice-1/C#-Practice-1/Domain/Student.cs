using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Practice_1.Domain
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string FamilyName { get; set; }
        public Teacher Teacher { get; set; }
        [ForeignKey("Teacher_Id")]
        public int Teacher_Id { get; set; }
    }
}
