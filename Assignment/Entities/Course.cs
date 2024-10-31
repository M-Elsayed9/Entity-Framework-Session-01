﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Entities
{
    internal class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? Duration { get; set; }
        public string? Description { get; set; }
        public int? Top_Id { get; set; }
    }
}