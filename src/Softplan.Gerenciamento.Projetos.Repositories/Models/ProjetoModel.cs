using System.Collections.Generic;
using Softplan.Common.Core.Entities;

namespace Softplan.Gerenciamento.Projetos.Repositories.Models
{
    public class ProjetoModel : SimpleId<int>
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public IList<LancamentoModel> Lancamentos { get; set; }
    }
}
