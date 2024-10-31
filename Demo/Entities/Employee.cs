using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Entities
{
    // EF core supports 4 ways for mapping classes in dataase (Table, view, function)
    // 1. By Convention [Default Behaviour]
    // 2. Data Annotation
    // 3. Fluent API -- (Override OnModelCreating())
    // 4. Class Configuration -- (Override OnModelCreating())

    //POCO Class
    // Plain old CLR Object
    //internal class Employee
    //{
    //    #region 1- By Convention [Default Behaviour]
    //    //public int Id { get; set; }
    //    // public numeric (int-double-decimal) property named [Id , ClassName + Id] =>PK with identity (1,1)
    //    //public string? EmpName { get; set; }  nvarchar(max)
    //    //reference type : allow null [optional]  nvarchar(max)
    //    //reference type : not allow null [required]  nvarchar(max)
    //    //nullable string : allow null [optional] =>  nvarchar(max)
    //    //
    //    //public decimal Salary { get; set; }
    //    //value type : not allow null [required]  decimal(18,2)=> for validation
    //    //public int? Age { get; set; }
    //    //nullable <int> : allow null[optional] int
    //    #endregion

    //    #region 2- Data Annotation
    //    [Key]
    //    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]//(1,1)
    //    public int EmpId { get; set; }

    //    [Required]//frontend
    //    [Column(TypeName = "varchar")]
    //    [MaxLength(50)]
    //    public string? EmpName { get; set; }

    //    [Column(TypeName = "Money")]
    //    //[DataType(DataType.Currency)]//same as above
    //    public decimal Salary { get; set; }

    //    [Range(22, 50)]
    //    public int? Age { get; set; }

    //    [EmailAddress]
    //    [DataType(DataType.EmailAddress)]
    //    public string Email { get; set; }

    //    [StringLength(50, MinimumLength = 5, ErrorMessage = "invalid address")]
    //    public string Address { get; set; }

    //    [Phone]
    //    public string Phone { get; set; }

    //    [DataType(DataType.Password)]
    //    public string Password { get; set; }

    //    [NotMapped]
    //    public int TotalSalary { get; set; }

    //    #endregion
    //}

    #region Fluent API
    internal class Employee
    {
        
        public int EmpId { get; set; }

        public string? EmpName { get; set; }

        public decimal Salary { get; set; }

        public int? Age { get; set; }

        public string Email { get; set; }

        public string Address { get; set; }

        public string Phone { get; set; }

        public string Password { get; set; }

        public int TotalSalary { get; set; }

    }
    #endregion
}
