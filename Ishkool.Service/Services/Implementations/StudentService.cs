using Ishkool.Core.Models.Student;
using Ishkool.Repository.Repositories.Contracts;
using Ishkool.Service.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ishkool.Service.Services.Implementations
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository _studentRepository;

        public StudentService(IStudentRepository studentRepository) 
        {
            _studentRepository = studentRepository;
        }

        public Task CreateAsync(Student student)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Student>> GetAllAsync()
        {
            return await _studentRepository.GetAllAsync();
        }

        public async Task<Student> GetAsync(int id)
        {
            return await _studentRepository.GetByIdAsync(id);
        }

        public async Task RemoveAsync(Student student)
        {
            await _studentRepository.RemoveAsync(student);
        }

        public async Task UpdateAsync(Student student)
        {
            await _studentRepository.UpdateAsync(student);
        }
    }
}
