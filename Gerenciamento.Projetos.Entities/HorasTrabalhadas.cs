using System;
using Softplan.Common.Core.Entities;

namespace Gerenciamento.Projetos.Entities
{
    public class HorasTrabalhadas : SimpleId<Guid>
    {
        public int QuantidadeDeHoras { get; set; }
    }
}
