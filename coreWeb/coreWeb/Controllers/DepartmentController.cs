using System;
using System.Threading.Tasks;
using coreWeb.Models;
using coreWeb.services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace coreWeb.Controllers
{
    public class DepartmentController:Controller
    {
        private readonly IDepartmentService _departmentService;
        private readonly IOptions<coreWebOptions> _coreWebOptions;

        public DepartmentController(IDepartmentService departmentService,IOptions<coreWebOptions> coreWebOptions)
        {
            _departmentService = departmentService;
            _coreWebOptions = coreWebOptions;
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
