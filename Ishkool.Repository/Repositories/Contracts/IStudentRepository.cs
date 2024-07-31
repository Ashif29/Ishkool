using Ishkool.Core.Models.Student;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ishkool.Repository.Repositories.Contracts
{
    public interface IStudentRepository
    {
        Task<List<Student>> GetAllAsync ();

        Task<Student> GetByIdAsync (int id);

        Task CreateAsync(Student student);
        Task UpdateAsync(Student student);
        Task RemoveAsync(Student student);
        Task SaveAsync();
    }

}
