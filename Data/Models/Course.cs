using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Ef03.Data.Models
{
    public class Course
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }
        public int Duration { get; set; }

        public int Top_ID { get; set; }
        public Topic Topic { get; set; }

        public ICollection<StudCourse> StudentCourses { get; set; }
    }
}
