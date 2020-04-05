using AutoMapper;
using Softplan.Gerenciamento.Projetos.Entities;
using Softplan.Gerenciamento.Projetos.Repositories.Models;

namespace Softplan.Gerenciamento.Projetos.Repositories.Profiles
{
    public class ColaboradorProfile : Profile
    {
        public ColaboradorProfile()
        {
            CreateMap<ColaboradorModel, Colaborador>();
            CreateMap<Colaborador, ColaboradorModel>();
        }
    }
}
