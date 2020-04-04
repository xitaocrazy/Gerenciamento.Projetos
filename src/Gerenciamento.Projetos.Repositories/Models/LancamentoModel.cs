using System;
using Softplan.Common.Core.Entities;

namespace Gerenciamento.Projetos.Repositories.Models
{
    public class LancamentoModel : SimpleId<Guid>
    {
        public Guid ColaboradorId { get; set; }
        public Guid ProjetoId { get; set; }
        public int QuantidadeDeHoras { get; set; }
        public ColaboradorModel Colaborador {get; set; }
        public ProjetoModel Projeto { get; set; }
    }
}
