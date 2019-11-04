using System;
using System.Threading.Tasks;
using coreWeb.services;
using Microsoft.AspNetCore.Mvc;

namespace coreWeb.ViewComponents
{
    public class CompanySummaryViewComponent:ViewComponent
    {
        private readonly IDepartmentService _departmentService;

        public CompanySummaryViewComponent(IDepartmentService departmentService)
        {
            _departmentService = departmentService;
        }

        public async Task<IViewComponentResult> InvokeAsync(string title)
        {
            ViewBag.Title = title;
            var summary = await _departmentService.GetCompanySummary();
            return View(summary);
        }
    }
}
