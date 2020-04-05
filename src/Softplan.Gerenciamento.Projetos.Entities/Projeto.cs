using System.Collections.Generic;
using Softplan.Common.Core.Entities;

namespace Softplan.Gerenciamento.Projetos.Entities
{
    public class Projeto : SimpleId<int>
    {
        public Projeto()
        {
            Lancamentos = new List<Lancamento>();
        }

        public string Nome { get; set; }
        public string Descricao { get; set; }
        public IList<Lancamento> Lancamentos { get; set; }
    }
}
