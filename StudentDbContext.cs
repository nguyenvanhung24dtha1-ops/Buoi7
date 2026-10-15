using Microsoft.EntityFrameworkCore;

namespace QuanLySinhVienCRUD
{
    public class StudentDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=QuanLySinhVienDB;Trusted_Connection=True;TrustServerCertificate=True;");
            }
        }