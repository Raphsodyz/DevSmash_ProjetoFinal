using AutoMapper;
using DevSmash___Projeto_Final.Models.Entidades;
using DevSmash___Projeto_Final.Models.ViewModels;

namespace DevSmash___Projeto_Final.Aplicação
{
    public class SiteMapper : Profile
    {
        public SiteMapper()
        {
            CreateMap<Cliente, ClientesViewModel>()
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
        }
    }
}
