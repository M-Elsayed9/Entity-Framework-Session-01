using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Entities
{
    // by Configuration
    internal class Instructor
    {
        public int Id { get; set; }
        [MinLength(2)]
        public string Name { get; set; }
        public decimal? Bonus { get; set; }
        public decimal Salary { get; set; }
        public decimal Hour_Rate { get; set; }
        public string? Address { get; set; }
        public int? Dept_Id { get; set; }
        
    }
}
