using AutoMapper;
using DevSmash___Projeto_Final.Models;
using DevSmash___Projeto_Final.Models.Entidades;
using DevSmash___Projeto_Final.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DevSmash___Projeto_Final.Controllers
{
    public class HomeController : Controller
    {
        private readonly SiteContext _context;
        private readonly IMapper _mapper;

        public HomeController(SiteContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            PaginaInicialViewModel paginaInicialViewModel = new PaginaInicialViewModel();

            List<Servico> servicos = _context.Servicos.Take(3).ToList();
            List<Post> posts = _context.Posts.Take(3).ToList();
            
            paginaInicialViewModel.Servicos = _mapper.Map<List<ServicoViewModel>>(servicos);
            paginaInicialViewModel.Posts = posts;

            return View(paginaInicialViewModel);
        }
    }
}