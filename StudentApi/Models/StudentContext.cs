using System;
using Microsoft.EntityFrameworkCore;
using StudentApi.Models;
namespace StudentApi.Models
{
    public class StudentContext : DbContext
    {
        public StudentContext(DbContextOptions<StudentContext>options)
            : base(options)
        {
        }
        public DbSet<Student> Student { get; set; }
    }
}
