using AutoMapper;
using Softplan.Gerenciamento.Projetos.Entities;
using Softplan.Gerenciamento.Projetos.Repositories.Models;

namespace Softplan.Gerenciamento.Projetos.Repositories.Profiles
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
