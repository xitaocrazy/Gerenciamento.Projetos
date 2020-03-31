using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Gerenciamento.Projetos.Entities;

namespace Gerenciamento.Projetos.Repositories.Abstractions
{
    public interface IProjetoRepository
    {
        Task AddProjetoAsync(Projeto projeto);
        Task UpdateProjetoAsync(Projeto projeto);
        Task RemoveProjetoAsync(Projeto projeto);
        Task<Projeto> FindByIdAsync(Guid id);
        Task<ICollection<Projeto>> FindProjetosComLancamentos();
    }
}
