using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examen1
{
    public interface IEmployeeRepository
    {
        Task AddAsync(Employee employee);
        Task RemoveAsync(int id);
        Task<Employee> GetAsync(int id);
        Task<IEnumerable<Employee>> GetAllAsync();
        Task SaveToFileAsync(string filePath);
        Task LoadFromFileAsync(string filePath);
    }
}
