using AutoMapper;
using Softplan.Common.Core.Entities;
using Softplan.Common.Repositories.EntityFrameworkCore;
using Softplan.Gerenciamento.Projetos.Entities;
using Softplan.Gerenciamento.Projetos.Repositories.Models;

namespace Softplan.Gerenciamento.Projetos.Repositories.Repositories
{
    public class ColaboradorRepository : MappedRepository<Colaborador, SimpleId<int>, ColaboradorModel, GerenciamentoContext>
    {
        public ColaboradorRepository(IMapper mapper, IRepositoryService<GerenciamentoContext> repositoryService) : base(mapper, repositoryService)
        {
        }
    }
}
