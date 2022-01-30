using AutoMapper;
using DevSmash___Projeto_Final.Models.Entidades;
using DevSmash___Projeto_Final.Models.ViewModels;

namespace DevSmash___Projeto_Final.Aplicação
{
    public class SiteMapper : Profile
    {
        public SiteMapper()
        {
            CreateMap<Servico, ServicoViewModel>()
                .ForMember(
                    view => view.IdServico,
                    serv => serv.MapFrom(src => src.Id))
                .ForMember(
                    view => view.NomeServico,
                    serv => serv.MapFrom(src => src.Nome))
                .ForMember(
                    view => view.IconeFront,
                    serv => serv.MapFrom(src => src.Icone))
                .ForMember(
                    view => view.DescricaoView,
                    serv => serv.MapFrom(src => src.DescricaoFront))
                .ForMember(
                    view => view.ImagemFront,
                    serv => serv.MapFrom(src => src.Imagem));
        }
    }
}
