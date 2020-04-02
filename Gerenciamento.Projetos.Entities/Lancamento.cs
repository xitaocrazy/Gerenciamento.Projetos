using System;
using Softplan.Common.Core.Entities;

namespace Gerenciamento.Projetos.Entities
{
    public class Lancamento : SimpleId<Guid>
    {
        public Guid ColaboradorId { get; set; }
        public Guid ProjetoId { get; set; }
        public int QuantidadeDeHoras { get; set; }
        public Colaborador Colaborador {get; set; }
        public Projeto Projeto { get; set; }
    }
}
