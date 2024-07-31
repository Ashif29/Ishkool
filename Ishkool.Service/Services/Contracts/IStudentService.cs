using Ishkool.Core.Models.Student;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ishkool.Service.Services.Contracts
{
    public interface IStudentService
    {
        Task <List<Student>> GetAllAsync ();

        Task<Student> GetAsync (int id);

        Task CreateAsync (Student student);
        Task UpdateAsync (Student student);

        Task RemoveAsync (Student student);

    }
}
