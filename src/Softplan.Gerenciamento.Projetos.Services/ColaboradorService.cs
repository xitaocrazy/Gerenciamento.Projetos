using Softplan.Common.Core.Entities;
using Softplan.Common.Repositories.Abstractions;
using Softplan.Common.Services.Abstractions.Services;
using Softplan.Common.Services.Abstractions.Validations;
using Softplan.Gerenciamento.Projetos.Entities;

namespace Softplan.Gerenciamento.Projetos.Services
{
    public class ColaboradorService : CrudService<Colaborador, SimpleId<int>>
    {
        public ColaboradorService(IReadWriteRepository<Colaborador, SimpleId<int>> repository, ICrudValidator<Colaborador> validators) :
            base(repository, validators)
        {
        }
    }
}