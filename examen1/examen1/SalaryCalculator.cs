using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examen1
{
    public class SalaryCalculator
    {
        public decimal CalculateTotalSalary(IEnumerable<Employee> employees)
        {
            decimal totalSalary = 0;

            Parallel.ForEach(employees, employee =>
            {

                lock (this)
                {
                    totalSalary += employee.Salary;
                }
            });

            return totalSalary;
        }
    }
}