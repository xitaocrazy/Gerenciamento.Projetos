using AutoMapper;
using Gerenciamento.Projetos.Entities;
using Gerenciamento.Projetos.Repositories.Models;

namespace Gerenciamento.Projetos.Repositories.Profiles
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
