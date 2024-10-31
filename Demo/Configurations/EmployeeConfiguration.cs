using Demo.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Configurations
{


    internal class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.HasKey(e => e.EmpId);

            builder.Property(e => e.EmpId /*or "EmpId" or nameof(Employee.EmpId) */).UseIdentityColumn(1, 1);

            builder.Property(e => e.EmpName).HasColumnType("varchar").HasMaxLength(50).HasDefaultValue("EMpl").IsRequired();

            builder.Property(e => e.Salary).HasColumnType("Money");

            builder.Property(e => e.Age).HasColumnType("int");

            builder.Property(e => e.Email).HasColumnType("varchar").HasMaxLength(50);

            builder.Property(e => e.Address).HasMaxLength(50);
        }
    }
}
