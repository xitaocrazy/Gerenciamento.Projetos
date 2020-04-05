using Softplan.Common.Core.Entities;
using Softplan.Common.Repositories.Abstractions;
using Softplan.Common.Services.Abstractions.Services;
using Softplan.Common.Services.Abstractions.Validations;
using Softplan.Gerenciamento.Projetos.Entities;

namespace Softplan.Gerenciamento.Projetos.Services
{
    public class LancamentoService: CrudService<Lancamento, SimpleId<int>>
    {
        public LancamentoService(IReadWriteRepository<Lancamento, SimpleId<int>> repository, ICrudValidator<Lancamento> validators) :
            base(repository, validators)
        {
        }
    }
}