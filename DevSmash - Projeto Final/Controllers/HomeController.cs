using DevSmash___Projeto_Final.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DevSmash___Projeto_Final.Controllers
{
    public class HomeController : Controller
    {
        private readonly SiteContext _context;

        public HomeController(SiteContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View(_context.Servicos.Take(3).ToList());
        }
    }
}