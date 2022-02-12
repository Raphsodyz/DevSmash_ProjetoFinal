using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DevSmash___Projeto_Final.Models.Entidades
{
    public partial class Cliente
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Nome")]
        [StringLength(50, ErrorMessage = "Digite um nome válido.", MinimumLength = 3)]
        public string Nome { get; set; } = null!;

        [Required]
        [EmailAddress]
        [Display(Name = "E-mail")]
        [StringLength(70, ErrorMessage = "Digite um nome válido.", MinimumLength = 8)]
        public string Email { get; set; } = null!;

        [Phone]
        [Display(Name = "Telefone")]
        [StringLength (70, ErrorMessage = "Digite um telefone válido.", MinimumLength = 8)]
        public string Telefone { get; set; } = null!;

        [Display(Name = "CPF")]
        [StringLength (70, ErrorMessage = "Digite um CPF válido.", MinimumLength = 11)]
        public string Cpf { get; set; } = null!;

        [StringLength (8000, ErrorMessage = "Digite um comentário válido", MinimumLength = 3)]
        public string Mensagem { get; set; } = null!;
    }
}
