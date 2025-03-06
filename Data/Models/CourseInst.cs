using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Ef03.Data.Models
{
    public class CourseInst
    {
        
        public int InstID { get; set; }
        public Instructor Instructor { get; set; }
        public int CourseID { get; set; }
        public Course Course { get; set; }
        public string Evaluate { get; set; }
    }
}
