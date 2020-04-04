using System;
using System.Collections.Generic;
using Softplan.Common.Core.Entities;

namespace Gerenciamento.Projetos.Repositories.Models
{
    public class ProjetoModel : SimpleId<Guid>
    {
        private readonly IList<LancamentoModel> _lancamentos;

        public ProjetoModel()
        {
            _lancamentos = new List<LancamentoModel>();
        }

        public void AddLancamento(LancamentoModel lancamento)
        {
            lancamento.Projeto = this;
            _lancamentos.Add(lancamento);
        }

        public string Nome { get; set; }
        public string Descricao { get; set; }
        public IList<LancamentoModel> Lancamentos => _lancamentos;
    }
}
