using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Models;

namespace WebAPI.Interfaces
{
    public class IStudent
    {
        public interface IStudentRepository
        {
            Task<IEnumerable<Student>> GetAllAsync();
            Task<Student> GetByIdAsync(int id);
            Task AddAsync(Student student);
            Task UpdateAsync(Student student);
            Task DeleteAsync(int id);
        }
    }
}
