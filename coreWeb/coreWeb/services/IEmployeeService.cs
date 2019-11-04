using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using coreWeb.Models;

namespace coreWeb.services
{
    public interface IEmployeeService
    {
        Task Add(Employee employee);
        Task<IEnumerable<Employee>> GetByDepartmentId(int departmentId);
        Task<Employee> Fire(int Id);
    }
}
