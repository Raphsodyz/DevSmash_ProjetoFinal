using System;
using System.Collections.Generic;

namespace DevSmash___Projeto_Final.Models.Entidades
{
    public partial class Integrante
    {
        public int Id { get; set; }
        public string Nome { get; set; } = null!;
        public string Funcao { get; set; } = null!;
        public string RedeSocial { get; set; } = null!;
        public string Sobre { get; set; } = null!;
        public string Foto { get; set; }
    }
}
