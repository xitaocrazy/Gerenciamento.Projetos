using System;
using System.Threading.Tasks;
using AutoMapper;
using Gerenciamento.Projetos.Entities;
using Gerenciamento.Projetos.Repositories.Abstractions;
using Softplan.Common.Core.Entities;
using Softplan.Common.Repositories.EntityFrameworkCore;

namespace Gerenciamento.Projetos.Repositories.Repositories
{
    public class ProjetoRepository : MappedRepository<Projeto, SimpleId<Guid>, Projeto, GerenciamentoContext>, IProjetoRepository
    {
        public ProjetoRepository(IMapper mapper, IRepositoryService<GerenciamentoContext> repositoryService) : base(mapper, repositoryService)
        {
        }

        public async Task AddProjetoAsync(Projeto projeto)
        {
            await AddAsync(projeto);
        }

        public async Task<Projeto> FindByIdAsync(Guid id)
        {
            return await GetByIdAsync(new SimpleId<Guid> {Id = id});
        }

        public async Task RemoveProjetoAsync(Projeto projeto)
        {
            await DeleteAsync(projeto);
        }

        public async Task UpdateProjetoAsync(Projeto projeto)
        {
            await UpdateAsync(projeto);
        }
    }
}
