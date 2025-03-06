using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Ef03.Data.Models
{
    public class Instructor
    {
        public int ID { get; set; }
        public string? Name { get; set; }
        public decimal Salary { get; set; }
        public decimal Bouns { get; set; }
        public string Address { get; set; }
        public decimal HourRate { get; set; }
        public int Dept_ID { get; set; }
        [ForeignKey("Dept_ID")]
        public Department Department { get; set; }
    }
}
