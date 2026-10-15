using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace QuanLySinhVienCRUD
{
    public class StudentBUS
    {
        public async Task<List<Student>> GetAllStudentsAsync()
        {
            using var context = new StudentDbContext();
            return await context.Students.ToListAsync();
        }

        public async Task AddStudentAsync(string name, string gradeStr)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new System.Exception("Họ tên không được để trống!");

            if (!double.TryParse(gradeStr, out double grade) || grade < 0 || grade > 10)
                throw new System.Exception("Điểm phải là số từ 0 đến 10!");

            using var context = new StudentDbContext();
            context.Students.Add(new Student { FullName = name, Grade = grade });
            await context.SaveChangesAsync();
        }

        public async Task UpdateStudentAsync(int id, string name, string gradeStr)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new System.Exception("Họ tên không được để trống!");

            if (!double.TryParse(gradeStr, out double grade) || grade < 0 || grade > 10)
                throw new System.Exception("Điểm phải là số từ 0 đến 10!");

            using var context = new StudentDbContext();
            var sv = await context.Students.FindAsync(id);
            if (sv != null)
            {
                sv.FullName = name;
                sv.Grade = grade;
                await context.SaveChangesAsync();
            }
        }

        public async Task DeleteStudentAsync(int id)
        {
            using var context = new StudentDbContext();
            var sv = await context.Students.FindAsync(id);
            if (sv != null)
            {
                context.Students.Remove(sv);
                await context.SaveChangesAsync();
            }
        }

        public async Task<List<Student>> GetPassedStudentsAsync()
        {
            using var context = new StudentDbContext();
            // Sử dụng LINQ để lọc sinh viên có điểm >= 5
            return await context.Students.Where(s => s.Grade >= 5.0).ToListAsync();
        }
    }
}