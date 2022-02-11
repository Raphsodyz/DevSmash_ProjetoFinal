using DevSmash___Projeto_Final.Models.Entidades;

namespace DevSmash___Projeto_Final.Models.ViewModels
{
    public class AdmPanelViewModel
    {
        public IEnumerable<Cliente> Clientes { get; set; }
        public IEnumerable<Integrante> Integrantes { get; set; }
        public IEnumerable<Post> Posts { get; set; }
        public IEnumerable<Servico> Servicos { get; set; }
    }
}
