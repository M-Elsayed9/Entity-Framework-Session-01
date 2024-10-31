using Assignment.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Assignment.Configurations
{
    internal class InstructorConfig : IEntityTypeConfiguration<Instructor>
    {
        public void Configure(EntityTypeBuilder<Instructor> builder)
        {
            builder.HasKey(i => i.Id);
            builder.Property(i => i.Name).HasColumnType("varchar").HasMaxLength(50).IsRequired().HasMaxLength(50);
            builder.Property(i => i.Bonus).HasColumnType("Money");
            builder.Property(i => i.Salary).HasColumnType("Money").IsRequired();
            builder.Property(i => i.Hour_Rate).HasColumnType("decimal(8,2)").IsRequired();
            builder.Property(i => i.Address).HasColumnType("varchar").HasMaxLength(100);
            builder.Property(i => i.Dept_Id).HasColumnType("int");
        }
    }
}
