using System;
using System.Threading.Tasks;
using coreWeb.Models;
using coreWeb.services;
using Microsoft.AspNetCore.Mvc;

namespace coreWeb.Controllers
{
    public class DepartmentController:Controller
    {
        private readonly IDepartmentService _departmentService;

        public DepartmentController(IDepartmentService departmentService)
        {
            _departmentService = departmentService;
        }

        public async Task<IActionResult> Index()
        {
            ViewBag.Title = "Deapartment Index";
            var departments = await _departmentService.GetAll();
            return View(departments);
        }

        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.Title = "Add Department";
            return View(new Department());
        }

        [HttpPost]
        public async Task<IActionResult> Add(Department model)
        {
            if (ModelState.IsValid)
            {
                await _departmentService.Add(model);
            }

            return RedirectToAction(nameof(Index));
        }
    }
}
