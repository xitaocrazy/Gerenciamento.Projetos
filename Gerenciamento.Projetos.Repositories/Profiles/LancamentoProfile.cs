using AutoMapper;
using Gerenciamento.Projetos.Entities;
using Gerenciamento.Projetos.Repositories.Models;

namespace Gerenciamento.Projetos.Repositories.Profiles
{
    public class LancamentoProfile : Profile
    {
        public LancamentoProfile()
        {
            CreateMap<LancamentoModel, Lancamento>();
            CreateMap<Lancamento, LancamentoModel>();
        }
    }
}
