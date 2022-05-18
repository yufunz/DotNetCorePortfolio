using DotNetCorePortfolio.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using DotNetCorePortfolio.Data;
using Microsoft.EntityFrameworkCore;

namespace DotNetCorePortfolio.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        
        public async Task<IActionResult> Index()
        {
            var model = new ListModel();
            model.SkillModel = await _context.Skill.ToListAsync();
            model.ExperienceModel = await _context.Experience.ToListAsync();
            model.ProjectModel = await _context.Project.ToListAsync();

            return View(model);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}