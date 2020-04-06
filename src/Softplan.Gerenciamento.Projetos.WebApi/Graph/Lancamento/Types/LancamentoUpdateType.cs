﻿using Softplan.Common.Graph.Abstractions;

namespace Softplan.Gerenciamento.Projetos.WebApi.Graph.Lancamento.Types
{
    public class LancamentoUpdateType : LancamentoCreateType
    {
        public LancamentoUpdateType(IDescriptionProvider provider) : base(provider)
        {
            Field(l => l.Id);
        }
    }
}
