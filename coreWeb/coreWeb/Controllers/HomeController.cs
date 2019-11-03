using System;
using coreWeb.services;
using Microsoft.AspNetCore.Mvc;

namespace coreWeb.Controllers
{
    public class HomeController:Controller
    {
        public HomeController(IClock clock)
        {
        }
    }
}
