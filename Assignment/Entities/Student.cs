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
    internal class Student
    {
        public int Id { get; set; }
        [MinLength(2)]
        public string FName { get; set; }
        [MinLength(2)]
        public string LName { get; set; }
        [MinLength(2)]
        public string? Address { get; set; }
        [Range(18, 30, ErrorMessage = "Age must be between 18 and 30.")]
        public int? Age { get; set; }

        public int? Dept_Id { get; set; }

    }
}
