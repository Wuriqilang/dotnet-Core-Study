using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using coreWeb.Models;

namespace coreWeb.services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly List<Employee> _employees = new List<Employee>();

        public EmployeeService()
        {
            _employees.Add(new Employee
            {
                Id = 1,
                DepartmentId = 1,
                FirstName = "Nick",
                LastName = "Carter",
                Gender = Gender.男
,            });
            _employees.Add(new Employee
            {
                Id = 2,
                DepartmentId = 1,
                FirstName = "Michael",
                LastName = "Jackson",
                Gender = Gender.男
            });
            _employees.Add(new Employee
            {
                Id = 3,
                DepartmentId = 1,
                FirstName = "Mariah",
                LastName = "Carey",
                Gender = Gender.女
            });
            _employees.Add(new Employee
            {
                Id = 4,
                DepartmentId = 2,
                FirstName = "Li",
                LastName = "Bai",
                Gender = Gender.男
            });
            _employees.Add(new Employee
            {
                Id = 5,
                DepartmentId = 2,
                FirstName = "Kate",
                LastName = "Winslet",
                Gender = Gender.女
            });
            _employees.Add(new Employee
            {
                Id = 6,
                DepartmentId = 2,
                FirstName = "Huixuan",
                LastName = "Thomas",
                Gender = Gender.男
            });
            _employees.Add(new Employee
            {
                Id = 7,
                DepartmentId = 3,
                FirstName = "Aviril",
                LastName = "Lavigne",
                Gender = Gender.女
            });
            _employees.Add(new Employee
            {
                Id = 8,
                DepartmentId = 3,
                FirstName = "Katy",
                LastName = "Luo",
                Gender = Gender.女
            });
            _employees.Add(new Employee
            {
                Id = 9,
                DepartmentId = 3,
                FirstName = "Michelle",
                LastName = "Monaghan",
                Gender = Gender.女
            });
        }

        public Task Add(Employee employee)
        {
            employee.Id = _employees.Max(x => x.Id) + 1;
            _employees.Add(employee);
            return Task.CompletedTask;
        }

        public Task<IEnumerable<Employee>> GetByDepartmentId(int departmentId)
        {
            return Task.Run(() => _employees.Where(x=>x.DepartmentId == departmentId));
        }

        public Task<Employee> Fire(int id)
        {
            return Task.Run(() =>
            {
                var employee = _employees.FirstOrDefault(e => e.Id == id);
                if (employee != null)
                {
                    employee.Fired = true;
                    return employee;
                }
                return null;
            });
        }

    }
}
