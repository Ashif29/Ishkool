using Ishkool.Core.Models.Student;
using Ishkool.Repository.DataAccess;
using Ishkool.Repository.Repositories.Contracts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ishkool.Repository.Repositories.Implementations
{
    public class StudentRepository : IStudentRepository
    {
        private readonly ApplicationDbContext _db;

        public StudentRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task CreateAsync(Student student)
        {
            await _db.Students.AddAsync(student);
            await _db.SaveChangesAsync();
        }

        public async Task<List<Student>> GetAllAsync()
        {
            return await _db.Students.ToListAsync();
        }

        public async Task<Student> GetByIdAsync(int id)
        {
            return await _db.Students.FirstOrDefaultAsync(s => s.Id == id);
        }

        public async Task RemoveAsync(Student student)
        {
            _db.Students.Remove(student);
            await _db.SaveChangesAsync();
        }

        public async Task SaveAsync()
        {
            await _db.SaveChangesAsync();
        }

        public async Task UpdateAsync(Student student)
        {
            _db.Students.Update(student);
            await _db.SaveChangesAsync();
        }
    }
}
