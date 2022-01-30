using System;
using System.Collections.Generic;

namespace DevSmash___Projeto_Final.Models.Entidades
{
    public partial class Servico
    {
        public int Id { get; set; }
        public string Nome { get; set; } = null!;
        public string Descricao { get; set; } = null!;
        public int? Valor { get; set; }
        public string? Icone { get; set; }
        public string? Imagem { get; set; }
        public string? DescricaoFront { get; set; }
    }
}
