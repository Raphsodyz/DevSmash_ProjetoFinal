using DevSmash___Projeto_Final.Models.Entidades;

namespace DevSmash___Projeto_Final.Models.ViewModels
{
    public class ClientesViewModel
    {
        public IEnumerable<Servico> Servicos { get; set; }
        public Cliente Clientes { get; set; }
    }
}
