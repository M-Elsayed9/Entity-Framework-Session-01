using Assignment.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Assignment.Configurations
{
    internal class DepartmentConfig : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.HasKey(d => d.Id);
            builder.Property(d => d.Name).HasColumnType("varchar").HasMaxLength(50).IsRequired();
            builder.Property(d => d.InstId).HasColumnType("int").IsRequired();
            builder.Property(d => d.Hiring_Date);
        }
    }
}
