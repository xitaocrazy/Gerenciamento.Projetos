using Softplan.Common.Core.Entities;

namespace Softplan.Gerenciamento.Projetos.Entities
{
    public class Lancamento : SimpleId<int>
    {
        public int ColaboradorId { get; set; }
        public int ProjetoId { get; set; }
        public int QuantidadeDeHoras { get; set; }
        public Colaborador Colaborador {get; set; }
        public Projeto Projeto { get; set; }
    }
}
