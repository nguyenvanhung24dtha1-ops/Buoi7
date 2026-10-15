using Microsoft.EntityFrameworkCore;

namespace QuanLySinhVienCRUD
{
    public class AppDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=StudentDb;Trusted_Connection=True;TrustServerCertificate=True;");
        }
    }
}