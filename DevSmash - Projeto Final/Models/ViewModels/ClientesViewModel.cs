using DevSmash___Projeto_Final.Models.Entidades;
using System.ComponentModel.DataAnnotations;

namespace DevSmash___Projeto_Final.Models.ViewModels
{
    public class ClientesViewModel
    {
        [Key]
        public int FormId { get; set; }

        [Required]
        [Display(Name = "Nome")]
        [StringLength(50, ErrorMessage = "Digite um nome válido.", MinimumLength = 3)]
        public string FormNome { get; set; } = null!;

        [Required]
        [EmailAddress]
        [Display(Name = "E-mail")]
        [StringLength(70, ErrorMessage = "Digite um nome válido.", MinimumLength = 8)]
        public string FormEmail { get; set; } = null!;

        [Phone]
        [Display(Name = "Telefone")]
        [StringLength(70, ErrorMessage = "Digite um telefone válido.", MinimumLength = 8)]
        public string FormTelefone { get; set; } = null!;

        [Display(Name = "CPF")]
        [StringLength(70, ErrorMessage = "Digite um CPF válido.", MinimumLength = 11)]
        public string FormCpf { get; set; } = null!;

        [StringLength(8000, ErrorMessage = "Digite um comentário válido", MinimumLength = 3)]
        public string FormMensagem { get; set; } = null!;

        public IEnumerable<Servico> Servicos { get; set; }
    }
}
