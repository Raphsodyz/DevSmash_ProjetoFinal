using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DevSmash___Projeto_Final.Controllers
{
    public class AdmPanelController : Controller
    {
        [Authorize]
        public IActionResult Index()
        {
            return View();
        }
    }
}
