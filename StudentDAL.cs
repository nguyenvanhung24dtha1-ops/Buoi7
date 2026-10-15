using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuanLySinhVienCRUD
{
    public class StudentDAL
    {
        // Lấy toàn bộ danh sách sinh viên
        public async Task<List<Student>> GetAllAsync()
        {
            using (var context = new AppDbContext())
            {
                return await context.Students.ToListAsync();
            }
        }

        // Thêm sinh viên mới
        public async Task AddAsync(Student student)
        {
            using (var context = new AppDbContext())
            {
                context.Students.Add(student);
                await context.SaveChangesAsync();
            }
        }

        // Cập nhật thông tin sinh viên
        public async Task UpdateAsync(Student student)
        {
            using (var context = new AppDbContext())
            {
                var sv = await context.Students.FindAsync(student.Id);
                if (sv != null)
                {
                    sv.FullName = student.FullName;
                    sv.Grade = student.Grade;
                    await context.SaveChangesAsync();
                }
            }
        }

        // Xóa sinh viên theo ID
        public async Task DeleteAsync(int id)
        {
            using (var context = new AppDbContext())
            {
                var sv = await context.Students.FindAsync(id);
                if (sv != null)
                {
                    context.Students.Remove(sv);
                    await context.SaveChangesAsync();
                }
            }
        }

        // Lọc sinh viên đạt (điểm >= 5) giảm dần theo điểm
        public async Task<List<Student>> GetPassedStudentsAsync()
        {
            using (var context = new AppDbContext())
            {
                return await context.Students
                    .Where(sv => sv.Grade >= 5)
                    .OrderByDescending(sv => sv.Grade)
                    .ToListAsync();
            }
        }
    }
}