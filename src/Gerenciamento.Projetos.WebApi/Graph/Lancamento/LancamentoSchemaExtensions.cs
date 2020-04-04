
using System;
using Gerenciamento.Projetos.WebApi.Graph.Lancamento.Types;
using Gerenciamento.Projetos.WebApi.Graph.Schema;
using Softplan.Common.Core.Entities;
using Softplan.Common.Graph.Abstractions;
using Softplan.Common.Graph.SchemaExtension;

namespace Gerenciamento.Projetos.WebApi.Graph.Lancamento
{
    public class LancamentoSchemaExtensions : SchemaExtension<GerenciamentoSchema>
    {
        protected override void OnExtend(IExtensibleMutationType mutation)
        {
            mutation.From<Entities.Lancamento, SimpleId<Guid>>()
                .Create<LancamentoCreateType, LancamentoType>()
                .Update<LancamentoUpdateType, LancamentoType>()
                .Delete<LancamentoType>();
        }

        protected override void OnExtend(IExtensibleQueryType query)
        {
            query.From<Entities.Lancamento, SimpleId<Guid>, LancamentoType>()
                .GetById()
                .List("lancamentos");
        }
    }
}
