using DevSmash___Projeto_Final.Models.Entidades;

namespace DevSmash___Projeto_Final.Models.ViewModels
{
    public class PaginaInicialViewModel
    {
        public IEnumerable<Post> Posts { get; set; }
        public IEnumerable<Servico> Servicos { get; set; }
    }
}
