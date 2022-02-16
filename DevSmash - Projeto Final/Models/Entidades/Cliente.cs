using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DevSmash___Projeto_Final.Models.Entidades
{
    public partial class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string? Telefone { get; set; } = null!;
        public string? Cpf { get; set; } = null!;
        public string? Mensagem { get; set; } = null!;
    }
}
