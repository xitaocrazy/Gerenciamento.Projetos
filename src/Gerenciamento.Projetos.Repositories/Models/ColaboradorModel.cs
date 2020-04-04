using System;
using System.Collections.Generic;
using Softplan.Common.Core.Entities;

namespace Gerenciamento.Projetos.Repositories.Models
{
    public class ColaboradorModel : SimpleId<Guid>
    {
        private readonly IList<LancamentoModel> _lancamentos;

        public ColaboradorModel()
        {
            _lancamentos = new List<LancamentoModel>();
        }

        public void AddLancamento(LancamentoModel lancamento)
        {
            lancamento.Colaborador = this;
            _lancamentos.Add(lancamento);
        }

        public string Nome { get; set; }
        public IList<LancamentoModel> Lancamentos => _lancamentos;
    }
}
