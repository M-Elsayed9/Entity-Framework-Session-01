using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Entities
{
    internal class Instructor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double? Bonus { get; set; }
        public decimal Salary { get; set; }
        public int Hour_Rate { get; set; }
        public string? Address { get; set; }
        public int? Dept_Id { get; set; }
        
    }
}
