using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Gerenciamento.Projetos.Entities;

namespace Gerenciamento.Projetos.Repositories.Abstractions
{
    public interface ILancamentoRepository
    {
        Task AddLancamentoAsync(Lancamento lancamento);
        Task UpdateLancamentoAsync(Lancamento lancamento);
        Task RemoveLancamentoAsync(Lancamento lancamento);
        Task<Lancamento> FindByIdAsync(Guid id);
        Task<ICollection<Lancamento>> FindLancamentosComColaboradoresEProjetosAsync();
    }
}
