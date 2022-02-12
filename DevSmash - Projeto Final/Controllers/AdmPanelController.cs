using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DevSmash___Projeto_Final.Controllers
{
    [Authorize]
    public class AdmPanelController : Controller
    {
        private readonly SiteContext _siteContext;

        public AdmPanelController(SiteContext siteContext)
        {
            _siteContext = siteContext;
        }
        
        public IActionResult Index()
        {
            return View(_siteContext.AdmPanelViewModels.ToList());
        }
    }
}
