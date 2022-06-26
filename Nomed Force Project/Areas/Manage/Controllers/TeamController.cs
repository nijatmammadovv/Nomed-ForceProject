using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Nomed_Force_Project.Data_Access_Layer;
using Nomed_Force_Project.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Nomed_Force_Project.Areas.Manage.Controllers
{
    [Area("Manage")]
    public class TeamController : Controller
    {
        private AppDbContext _context { get; }
        public IWebHostEnvironment _env { get; }
        public TeamController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }
        public IActionResult Index()
        {
            return View(_context.Teams.ToList());
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Team team)
        {
            if (!ModelState.IsValid) return View(team);
            if (team.ImageUrl != null)
            {
                if (team.ImageUrl.ContentType != "image/jpeg" && team.ImageUrl.ContentType != "image/png" && team.ImageUrl.ContentType != "image/wepb")
                {
                    ModelState.AddModelError("", "Faylin tipi kriteriyalara uygun deyil");
                    return View(team);
                }
                if (team.ImageUrl.Length / 1024 > 3000)
                {
                    ModelState.AddModelError("", "Faylin olcusu coxdur");
                    return View(team);
                }
                string filename = team.ImageUrl.FileName;
                if (filename.Length > 64)
                {
                    filename.Substring(filename.Length - 64, 64);

                }
                string newFileName = Guid.NewGuid().ToString() + filename;
                string path = Path.Combine(_env.WebRootPath, "assets", "images", newFileName);
                using (FileStream fs = new FileStream(path, FileMode.Create))
                {
                    team.ImageUrl.CopyTo(fs);
                }
                team.Image = newFileName;
                _context.Teams.Add(team);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View();
        }
        public IActionResult Delete(int id)
        {
            Team team = _context.Teams.Find(id);
            if (team == null) return NotFound();
            if (System.IO.File.Exists(Path.Combine(_env.WebRootPath, "assets", "images", team.Image)))
                System.IO.File.Delete(Path.Combine(_env.WebRootPath, "assets", "images", team.Image));
            _context.Teams.Remove(team);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Edit(int id)
        {
            Team team = _context.Teams.FirstOrDefault(t => t.Id == id);
            if (team == null) return NotFound();
            return View(team);
        }
        [HttpPost]
        public IActionResult Edit(Team team)
        {
            Team team1 = _context.Teams.FirstOrDefault(t => t.Id == team.Id);
            if (team == null) return NotFound();
            if (team.ImageUrl != null)
            {
                if (team.ImageUrl.ContentType != "image/jpeg" && team.ImageUrl.ContentType != "image/png" && team.ImageUrl.ContentType != "image/wepb")
                {
                    ModelState.AddModelError("", "Faylin tipi png ve ya jpeg olmalidir");
                    return View(team);
                }
                if (team.ImageUrl.Length / 1024 > 3000)
                {
                    ModelState.AddModelError("", "Faylin olcusu max 3mb ola biler");
                    return View(team);
                }
                string filename = team.ImageUrl.FileName;
                if (filename.Length > 64)
                {
                    filename.Substring(filename.Length - 64, 64);

                }
                string newFileName = Guid.NewGuid().ToString() + filename;
                string path = Path.Combine(_env.WebRootPath, "assets", "images", newFileName);
                using (FileStream fs = new FileStream(path, FileMode.Create))
                {
                    team.ImageUrl.CopyTo(fs);
                }
                team1.Image = newFileName;
                team1.Fullname = team.Fullname;
                team1.SpecialtyName = team.SpecialtyName;
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View();
        }
    }
}
