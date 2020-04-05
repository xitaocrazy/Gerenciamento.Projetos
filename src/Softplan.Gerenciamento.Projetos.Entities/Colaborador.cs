using System.Collections.Generic;
using Softplan.Common.Core.Entities;

namespace Softplan.Gerenciamento.Projetos.Entities
{
    public class Colaborador : SimpleId<int>
    {
        public Colaborador()
        {
            Lancamentos = new List<Lancamento>();
        }

        public string Nome { get; set; }
        public IList<Lancamento> Lancamentos { get; set; }
    }
}
