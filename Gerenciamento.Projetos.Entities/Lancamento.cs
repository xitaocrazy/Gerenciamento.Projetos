using System;
using Softplan.Common.Core.Entities;

namespace Gerenciamento.Projetos.Entities
{
    public class Lancamento : SimpleId<Guid>
    {
        public Guid ColaboradorId { get; set; }
        public Guid ProjetoId { get; set; }
        public Guid HorasTrabalhadasId { get; set; }
        public Colaborador Colaborador {get; set; }
        public Projeto Projeto { get; set; }
        public HorasTrabalhadas Horas { get; set; }
    }
}
