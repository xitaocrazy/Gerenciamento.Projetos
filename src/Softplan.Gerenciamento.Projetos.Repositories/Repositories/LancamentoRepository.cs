using AutoMapper;
using Softplan.Common.Core.Entities;
using Softplan.Common.Repositories.EntityFrameworkCore;
using Softplan.Gerenciamento.Projetos.Entities;
using Softplan.Gerenciamento.Projetos.Repositories.Models;

namespace Softplan.Gerenciamento.Projetos.Repositories.Repositories
{
    public class LancamentoRepository : MappedRepository<Lancamento, SimpleId<int>, LancamentoModel, GerenciamentoContext>
    {
        public LancamentoRepository(IMapper mapper, IRepositoryService<GerenciamentoContext> repositoryService) : base(mapper, repositoryService)
        {
        }
    }
}
