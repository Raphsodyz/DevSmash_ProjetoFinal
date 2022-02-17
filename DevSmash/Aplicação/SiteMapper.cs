using AutoMapper;
using DevSmash___Projeto_Final.Models.Entidades;
using DevSmash___Projeto_Final.Models.ViewModels;

namespace DevSmash___Projeto_Final.Aplicação
{
    public class SiteMapper : Profile
    {
        public SiteMapper()
        {
            CreateMap<Cliente, FaleConoscoViewModel>()
                .ForMember(
                    view => view.FormId,
                    client => client.MapFrom(src => src.Id))
                .ForMember(
                    view => view.FormNome,
                    client => client.MapFrom(src => src.Nome))
                .ForMember(
                    view => view.FormEmail,
                    client => client.MapFrom(src => src.Email))
                .ForMember(
                    view => view.FormTelefone,
                    client => client.MapFrom(src => src.Telefone))
                .ForMember(
                    view => view.FormCpf,
                    client => client.MapFrom(src => src.Cpf))
                .ForMember(
                    view => view.FormMensagem,
                    client => client.MapFrom(src => src.Mensagem));

            CreateMap<FaleConoscoViewModel, Cliente>()
                .ForMember(
                    view => view.Nome,
                    client => client.MapFrom(src => src.FormNome))
                .ForMember(
                    view => view.Email,
                    client => client.MapFrom(src => src.FormEmail))
                .ForMember(
                    view => view.Telefone,
                    client => client.MapFrom(src => src.FormTelefone))
                .ForMember(
                    view => view.Cpf,
                    client => client.MapFrom(src => src.FormCpf))
                .ForMember(
                    view => view.Mensagem,
                    client => client.MapFrom(src => src.FormMensagem));
        }

    }
}
