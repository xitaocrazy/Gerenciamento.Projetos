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
    public class ColaboradorRepository : MappedRepository<Colaborador, SimpleId<Guid>, ColaboradorModel, GerenciamentoContext>, IColaboradorRepository
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
