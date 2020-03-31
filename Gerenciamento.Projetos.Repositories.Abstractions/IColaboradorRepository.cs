using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Gerenciamento.Projetos.Entities;

namespace Gerenciamento.Projetos.Repositories.Abstractions
{
    public interface IColaboradorRepository
    {
        Task AddColaboradorAsync(Colaborador colaborador);
        Task UpdateColaboradorAsync(Colaborador colaborador);
        Task RemoveColaboradorAsync(Colaborador colaborador);
        Task<Colaborador> FindByIdAsync(Guid id);
        Task<ICollection<Colaborador>> FindColaboradoresComLancamentos();
    }
}
