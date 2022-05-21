using Microsoft.AspNetCore.Mvc;
using DotNetCorePortfolio.Data;
using DotNetCorePortfolio.Models;

namespace DotNetCorePortfolio.Controllers
{
    public class ContactController : Controller
    {
        private readonly AppDbContext _context;

        public ContactController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult LeaveMessage(string fullname, string email, string message)
        {
            _context.Message.Add(new Message()
                {
                    FullName = fullname,
                    Email = email,
                    Body = message,
                    CreatedAt = DateTime.Now
                }
            );

            try
            {
                _context.SaveChanges();
                ViewData["Message"] = $"A message from {fullname}, {email} has been sent successfully. Message Body: {message}";
                TempData["MessageSent"] = true;
            }
            catch (Exception ex)
            {
                ViewData["Message"] = $"Oops, something went wrong! {ex.Message}";
                TempData["MessageSent"] = false;
            }

            return RedirectToAction("Index", "Home", "page-contact");
        }

    }
}
