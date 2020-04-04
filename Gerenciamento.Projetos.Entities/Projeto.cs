using System;
using System.Collections.Generic;
using Softplan.Common.Core.Entities;

namespace Gerenciamento.Projetos.Entities
{
    public class Projeto : SimpleId<Guid>
    {
        private readonly IList<Lancamento> _lancamentos;

        public Projeto()
        {
            _lancamentos = new List<Lancamento>();
        }

        public void AddLancamento(Lancamento lancamento)
        {
            lancamento.Projeto = this;
            _lancamentos.Add(lancamento);
        }

        public string Nome { get; set; }
        public string Descricao { get; set; }
        public IList<Lancamento> Lancamentos => _lancamentos;
    }
}
