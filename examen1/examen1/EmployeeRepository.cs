using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace examen1
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly ConcurrentDictionary<int, Employee> _employees = new ConcurrentDictionary<int, Employee>();

        public Task AddAsync(Employee employee)
        {
            return Task.Run(() => _employees[employee.Id] = employee);
        }

        public Task RemoveAsync(int id)
        {
            return Task.Run(() => _employees.TryRemove(id, out _));
        }

        public Task<Employee> GetAsync(int id)
        {
            return Task.Run(() =>
            {
                _employees.TryGetValue(id, out var employee);
                return employee;
            });
        }

        public Task<IEnumerable<Employee>> GetAllAsync()
        {
            return Task.Run(() => _employees.Values.AsEnumerable());
        }

        public Task SaveToFileAsync(string filePath)
        {
            return Task.Run(() =>
            {
                var serializer = new XmlSerializer(typeof(List<Employee>));
                using (var writer = new StreamWriter(filePath))
                {
                    serializer.Serialize(writer, _employees.Values.ToList());
                }
            });
        }

        public Task LoadFromFileAsync(string filePath)
        {
            return Task.Run(() =>
            {
                var serializer = new XmlSerializer(typeof(List<Employee>));
                using (var reader = new StreamReader(filePath))
                {
                    var employees = (List<Employee>)serializer.Deserialize(reader);
                    _employees.Clear();
                    foreach (var employee in employees)
                    {
                        _employees[employee.Id] = employee;
                    }
                }
            });
        }
    }
}