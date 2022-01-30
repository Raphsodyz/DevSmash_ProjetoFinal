namespace DevSmash___Projeto_Final.Models.ViewModels
{
    public class ServicoViewModel
    {
        public int IdServico { get; set; }
        public string NomeServico { get; set; } = null!;
        public int? ValorServico { get; set; }
        public string? IconeFront { get; set; }
        public string? ImagemFront { get; set; }
        public string? DescricaoView { get; set; }
        public string DescricaoCompleta { get; set; } = null!;
    }
}
