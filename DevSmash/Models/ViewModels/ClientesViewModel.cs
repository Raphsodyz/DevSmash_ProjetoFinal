using DevSmash___Projeto_Final.Models.Entidades;
using System.ComponentModel.DataAnnotations;

namespace DevSmash___Projeto_Final.Models.ViewModels
{
    public class ClientesViewModel
    {
        public FaleConoscoViewModel FalesConosco { get; set; }
        public IEnumerable<Servico> Servicos { get; set; }
    }
}
