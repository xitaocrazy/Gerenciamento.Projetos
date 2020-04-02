using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Gerenciamento.Projetos.Entities;
using Gerenciamento.Projetos.Repositories.Abstractions;
using Gerenciamento.Projetos.Repositories.Models;
using Microsoft.EntityFrameworkCore;
using Softplan.Common.Core.Entities;
using Softplan.Common.Repositories.EntityFrameworkCore;

namespace Gerenciamento.Projetos.Repositories.Repositories
{
    public class LancamentoRepository : MappedRepository<Lancamento, SimpleId<Guid>, LancamentoModel, GerenciamentoContext>, ILancamentoRepository
    {
        public LancamentoRepository(IMapper mapper, IRepositoryService<GerenciamentoContext> repositoryService) : base(mapper, repositoryService)
        {
        }

        public async Task AddLancamentoAsync(Lancamento lancamento)
        {
            await AddAsync(lancamento);
        }

        public async Task<Lancamento> FindByIdAsync(Guid id)
        {
            return await GetByIdAsync(new SimpleId<Guid> {Id = id});
        }

        public async Task<ICollection<Lancamento>> FindLancamentosComColaboradoresEProjetosAsync()
        {
            var lancamentos = await RepositoryService.GetQueryableAsync<LancamentoModel>(default);
            lancamentos = lancamentos.Include(l => l.Colaborador).Include(l => l.Projeto);
            return Mapper.Map<ICollection<LancamentoModel>, ICollection<Lancamento>>(await lancamentos.ToListAsync());
        }

        public async Task RemoveLancamentoAsync(Lancamento lancamento)
        {
            await DeleteAsync(lancamento);
        }

        public async Task UpdateLancamentoAsync(Lancamento lancamento)
        {
            await UpdateAsync(lancamento);
        }
    }
}
