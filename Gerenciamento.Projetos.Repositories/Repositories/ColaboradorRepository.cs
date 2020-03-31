using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Gerenciamento.Projetos.Entities;
using Gerenciamento.Projetos.Repositories.Abstractions;
using Microsoft.EntityFrameworkCore;
using Softplan.Common.Core.Entities;
using Softplan.Common.Repositories.EntityFrameworkCore;

namespace Gerenciamento.Projetos.Repositories.Repositories
{
    public class ColaboradorRepository : MappedRepository<Colaborador, SimpleId<Guid>, Colaborador, GerenciamentoContext>, IColaboradorRepository
    {
        public ColaboradorRepository(IMapper mapper, IRepositoryService<GerenciamentoContext> repositoryService) : base(mapper, repositoryService)
        {
        }

        public async Task AddColaboradorAsync(Colaborador colaborador)
        {
            await AddAsync(colaborador);
        }

        public async Task<Colaborador> FindByIdAsync(Guid id)
        {
            return await GetByIdAsync(new SimpleId<Guid> {Id = id});
        }

        public async Task<ICollection<Colaborador>> FindColaboradoresComLancamentos()
        {
            var colaboradores = await RepositoryService.GetQueryableAsync<Colaborador>(default);
            colaboradores = colaboradores.Include(c => c.Lancamentos);
            return await colaboradores.ToListAsync();
        }

        public async Task RemoveColaboradorAsync(Colaborador colaborador)
        {
            await DeleteAsync(colaborador);
        }

        public async Task UpdateColaboradorAsync(Colaborador colaborador)
        {
            await UpdateAsync(colaborador);
        }
    }
}
