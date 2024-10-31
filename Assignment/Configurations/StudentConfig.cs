using Assignment.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Configurations
{
    internal class StudentConfig : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.HasKey(s => s.Id);
            builder.Property(s => s.FName).HasColumnType("varchar").HasMaxLength(50).IsRequired();
            builder.Property(s => s.LName).HasColumnType("varchar").HasMaxLength(50).IsRequired();
            builder.Property(s => s.Address).HasColumnType("varchar").HasMaxLength(100);
            builder.Property(s => s.Age).HasColumnType("int").IsRequired();
            builder.Property(s => s.Dept_Id).HasColumnType("int");
        }
    }
}
