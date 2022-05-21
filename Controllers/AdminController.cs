using Microsoft.AspNetCore.Mvc;
using DotNetCorePortfolio.Data;
using Microsoft.EntityFrameworkCore;
using DotNetCorePortfolio.Models;
using PagedList;

namespace DotNetCorePortfolio.Views.Admin
{
    public class AdminController : Controller
    {
        private readonly AppDbContext _context;
        private PagedList<Message> messages;

        public AdminController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Admin/Messages
        public async Task<IActionResult> Messages(int page = 1)
        {
            int pageIndex = page;
            int pageSize = 10;


            IQueryable<Message> messageIQ = from m in _context.Message select m;

            int count = await messageIQ.CountAsync();


            messageIQ = messageIQ.OrderByDescending(m => m.CreatedAt);

            messages = await PagedList<Message>.CreateAsync(messageIQ.AsNoTracking(), pageIndex, pageSize);

            return View(messages);

        }
    }
}
