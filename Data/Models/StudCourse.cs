using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Ef03.Data.Models
{
    [PrimaryKey(nameof(Course_ID),nameof(Stud_ID))]
    public class StudCourse
    {
        
        public int Stud_ID { get; set; }
        public Student Student { get; set; }
        public int Course_ID { get; set; }
        public Course Course { get; set; }
        public decimal Grade { get; set; }
    }
}
