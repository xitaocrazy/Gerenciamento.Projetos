using Softplan.Common.Core.Entities;

namespace Softplan.Gerenciamento.Projetos.Repositories.Models
{
    public class LancamentoModel : SimpleId<int>
    {
        public int ColaboradorId { get; set; }
        public int ProjetoId { get; set; }
        public int QuantidadeDeHoras { get; set; }
        public ColaboradorModel Colaborador {get; set; }
        public ProjetoModel Projeto { get; set; }
    }
}
