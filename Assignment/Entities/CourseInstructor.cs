using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Entities
{
    // by fluent API
    internal class CourseInstructor
    {
        public int InsId { get; set; }
        public int Course_Id { get; set; }
        [Range(0, 5, ErrorMessage = "Invalid Evaluation must be between 0 and 5")]
        public int Evaluate { get; set; }
    }
}
