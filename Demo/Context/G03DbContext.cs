using Demo.Configurations;
using Demo.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Context
{
    internal class G03DbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = MOHAMED_PC; Database = CompanyG03DB; Trusted_Connection = true; TrustServerCertificate = True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration<Employee>(new EmployeeConfiguration());

            //modelBuilder.ApplyConfigurationsFromAssembly(modelBuilder.GetType().Assembly);
            //modelBuilder.Entity<Employee>().HasKey(e => e.EmpId);

            //modelBuilder.Entity<Employee>().Property(e => e.EmpId /*or "EmpId" or nameof(Employee.EmpId) */).UseIdentityColumn(1, 1);

            //modelBuilder.Entity<Employee>().Property(e => e.EmpName).HasColumnType("varchar").HasMaxLength(50).HasDefaultValue("EMpl").IsRequired();

            //modelBuilder.Entity<Employee>().Property(e => e.Salary).HasColumnType("Money");

            //modelBuilder.Entity<Employee>().Property(e => e.Age).HasColumnType("int");

            //modelBuilder.Entity<Employee>().Property(e => e.Email).HasColumnType("varchar").HasMaxLength(50);

            //modelBuilder.Entity<Employee>().Property(e => e.Address).HasMaxLength(50);

            //modelBuilder.Entity<Employee>(e =>
            //{
            //    e.HasKey(e => e.EmpId);

            //    e.Property(e => e.EmpId /*or "EmpId" or nameof(Employee.EmpId) */).UseIdentityColumn(1, 1);

            //    e.Property(e => e.EmpName).HasColumnType("varchar").HasMaxLength(50).HasDefaultValue("EMpl").IsRequired();

            //    e.Property(e => e.Salary).HasColumnType("Money");

            //    e.Property(e => e.Age).HasColumnType("int");

            //    e.Property(e => e.Email).HasColumnType("varchar").HasMaxLength(50);

            //    e.Property(e => e.Address).HasMaxLength(50);
            //});



            base.OnModelCreating(modelBuilder);
        }



        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
    }
}
