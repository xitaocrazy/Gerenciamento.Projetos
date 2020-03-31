using System;
using System.Collections.Generic;
using Softplan.Common.Core.Entities;

namespace Gerenciamento.Projetos.Entities
{
    public class Colaborador : SimpleId<Guid>
    {
        private readonly IList<Lancamento> _lancamentos;

        public Colaborador()
        {
            _lancamentos = new List<Lancamento>();
        }

        public void AddLancamento(Lancamento lancamento)
        {
            lancamento.Colaborador = this;
            _lancamentos.Add(lancamento);
        }

        public string Nome { get; set; }
        public IList<Lancamento> Lancamentos
        {
            get
            {
return _lancamentos;
            }
        }
    }
}
