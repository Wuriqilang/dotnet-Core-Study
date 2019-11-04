using System;
using System.ComponentModel.DataAnnotations;

namespace coreWeb.Models
{
    public class Department
    {
        public int Id { get; set; }

        [Display(Name = "部门名称")]
        public string Name { get; set; }
        public string Location { get; set; }
        public int EmployeeCount { get; set; }
    }
}
