using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Ef03.Data.Models
{
    public class Department
    {
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        public int Ins_ID { get; set; }
        [ForeignKey("Ins_ID")]
        public Instructor Instructor { get; set; }
        public DateTime HiringDate { get; set; }

        public ICollection<Student> students { get; set; }
        public ICollection<Instructor> Instructors { get; set; }

    }
}
