using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Entities
{
    internal class Course
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        
        [Required]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Invalid course name")]
        [Column("CourseName", TypeName = "varchar(50)")]
        public string Name { get; set; }
        [Required]
        [Range(1, 4, ErrorMessage = "Duration must be between 1 and 4 hours")]
        public int? Duration { get; set; }
        [Required]
        [StringLength(maximumLength: 1000, MinimumLength = 20, ErrorMessage = "Invalid course description")]
        public string? Description { get; set; }
        [Required]

        public int? Top_Id { get; set; }
    }
}
