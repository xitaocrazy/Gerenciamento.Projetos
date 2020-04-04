using System;
using Gerenciamento.Projetos.Entities;
using Softplan.Common.Core.Entities;
using Softplan.Common.Repositories.Abstractions;
using Softplan.Common.Services.Abstractions.Services;
using Softplan.Common.Services.Abstractions.Validations;

namespace Gerenciamento.Projetos.Services
{
    public class ColaboradorService : CrudService<Colaborador, SimpleId<Guid>>
    {
        public ColaboradorService(IReadWriteRepository<Colaborador, SimpleId<Guid>> repository, ICrudValidator<Colaborador> validators) :
            base(repository, validators)
        {
        }
    }
}