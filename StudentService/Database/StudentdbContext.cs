using Microsoft.EntityFrameworkCore;
using StudentService.Database.Entities;

namespace StudentService.Database
{
    public class StudentdbContext:DbContext
    {
        public StudentdbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Student> Students { get; set; }
    }
}
