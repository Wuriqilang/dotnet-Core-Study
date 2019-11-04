using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using coreWeb.Models;

namespace coreWeb.services
{
    public interface IDepartmentService
    {
        Task<IEnumerable<Department>> GetAll();
        Task<Department> GetById(int id);
        Task<CompanySummary> GetCompanySummary();
        Task Add(Department department);
    }
}
