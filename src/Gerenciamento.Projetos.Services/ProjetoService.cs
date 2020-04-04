using System;
using Gerenciamento.Projetos.Entities;
using Softplan.Common.Core.Entities;
using Softplan.Common.Repositories.Abstractions;
using Softplan.Common.Services.Abstractions.Services;
using Softplan.Common.Services.Abstractions.Validations;

namespace Gerenciamento.Projetos.Services
{
    public class ProjetoService: CrudService<Projeto, SimpleId<Guid>>
    {
        public ProjetoService(IReadWriteRepository<Projeto, SimpleId<Guid>> repository, ICrudValidator<Projeto> validators) :
            base(repository, validators)
        {
        }
    }
}