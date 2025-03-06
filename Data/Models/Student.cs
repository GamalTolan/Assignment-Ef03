using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Ef03.Data.Models
{
    public class Student
    {
        public int ID { get; set; }
        [MaxLength(50)]
        [Required]
        public string FName { get; set; }
        public string LName { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }
        public int Dep_Id { get; set; }

        public Department Department { get; set; }

        public ICollection<StudCourse> StudentCourses { get; set; }
    }
}
