using AutoMapper;
using Softplan.Common.Core.Entities;
using Softplan.Common.Repositories.EntityFrameworkCore;
using Softplan.Gerenciamento.Projetos.Entities;
using Softplan.Gerenciamento.Projetos.Repositories.Models;

namespace Softplan.Gerenciamento.Projetos.Repositories.Repositories
{
    public class ProjetoRepository : MappedRepository<Projeto, SimpleId<int>, ProjetoModel, GerenciamentoContext>
    {
        public ProjetoRepository(IMapper mapper, IRepositoryService<GerenciamentoContext> repositoryService) : base(mapper, repositoryService)
        {
        }
    }
}
