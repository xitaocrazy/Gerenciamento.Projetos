using Softplan.Common.Core.Entities;
using Softplan.Common.Repositories.Abstractions;
using Softplan.Common.Services.Abstractions.Services;
using Softplan.Common.Services.Abstractions.Validations;
using Softplan.Gerenciamento.Projetos.Entities;

namespace Softplan.Gerenciamento.Projetos.Services
{
    public class ProjetoService: CrudService<Projeto, SimpleId<int>>
    {
        public ProjetoService(IReadWriteRepository<Projeto, SimpleId<int>> repository, ICrudValidator<Projeto> validators) :
            base(repository, validators)
        {
        }
    }
}