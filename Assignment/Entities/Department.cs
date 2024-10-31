﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Entities
{
    internal class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int instId { get; set; }
        public DateTime? Hiring_Date { get; set; }
            
    }
}
