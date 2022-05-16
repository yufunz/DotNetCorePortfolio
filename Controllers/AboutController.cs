using Microsoft.AspNetCore.Mvc;

namespace DotNetCorePortfolio.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
