using System;
using Gerenciamento.Projetos.Entities;
using Softplan.Common.Core.Entities;
using Softplan.Common.Repositories.Abstractions;
using Softplan.Common.Services.Abstractions.Services;
using Softplan.Common.Services.Abstractions.Validations;

namespace Gerenciamento.Projetos.Services
{
    public class LancamentoService: CrudService<Lancamento, SimpleId<Guid>>
    {
        public LancamentoService(IReadWriteRepository<Lancamento, SimpleId<Guid>> repository, ICrudValidator<Lancamento> validators) :
            base(repository, validators)
        {
        }
    }
}