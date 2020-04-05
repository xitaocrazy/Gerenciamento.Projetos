using Softplan.Common.Core.Entities;
using Softplan.Common.Graph.Abstractions;
using Softplan.Common.Graph.SchemaExtension;
using Softplan.Gerenciamento.Projetos.WebApi.Graph.Lancamento.Types;
using Softplan.Gerenciamento.Projetos.WebApi.Graph.Schema;

namespace Softplan.Gerenciamento.Projetos.WebApi.Graph.Lancamento
{
    public class LancamentoSchemaExtensions : SchemaExtension<GerenciamentoSchema>
    {
        protected override void OnExtend(IExtensibleMutationType mutation)
        {
            mutation.From<Entities.Lancamento, SimpleId<int>>()
                .Create<LancamentoCreateType, LancamentoType>()
                .Update<LancamentoUpdateType, LancamentoType>()
                .Delete<LancamentoType>();
        }

        protected override void OnExtend(IExtensibleQueryType query)
        {
            query.From<Entities.Lancamento, SimpleId<int>, LancamentoType>()
                .GetById()
                .List("lancamentos");
        }
    }
}
