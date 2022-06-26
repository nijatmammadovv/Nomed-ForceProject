using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Nomed_Force_Project.Data_Access_Layer;
using Nomed_Force_Project.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Nomed_Force_Project.Controllers
{
    public class HomeController : Controller
    {
        private AppDbContext _context { get; }
        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View(_context.Teams.ToList());
        }
        public List<Team> Teams { get; set; }
    }
}
