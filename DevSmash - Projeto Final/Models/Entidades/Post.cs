using System;
using System.Collections.Generic;

namespace DevSmash___Projeto_Final.Models.Entidades
{
    public partial class Post
    {
        public int Id { get; set; }
        public string Titulo { get; set; } = null!;
        public string? Autor { get; set; }
        public string Conteudo { get; set; } = null!;
        public DateTime Criacao { get; set; }
    }
}
