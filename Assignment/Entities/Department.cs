using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Entities
{
    // by Configuration
    internal class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int InstId { get; set; }
        public DateOnly? Hiring_Date { get; set; }
            
    }
}
