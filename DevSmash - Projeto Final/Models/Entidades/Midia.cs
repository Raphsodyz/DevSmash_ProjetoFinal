using System;
using System.Collections.Generic;

namespace DevSmash___Projeto_Final.Models.Entidades
{
    public partial class Midia
    {
        public int Id { get; set; }
        public string Nome { get; set; } = null!;
        public string? Alt { get; set; }
        public string Link { get; set; } = null!;
    }
}
