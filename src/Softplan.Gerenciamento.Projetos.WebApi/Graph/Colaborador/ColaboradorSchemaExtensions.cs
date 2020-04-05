using Softplan.Common.Core.Entities;
using Softplan.Common.Graph.Abstractions;
using Softplan.Common.Graph.SchemaExtension;
using Softplan.Gerenciamento.Projetos.WebApi.Graph.Colaborador.Types;
using Softplan.Gerenciamento.Projetos.WebApi.Graph.Schema;

namespace Softplan.Gerenciamento.Projetos.WebApi.Graph.Colaborador
{
    public class ColaboradorSchemaExtensions : SchemaExtension<GerenciamentoSchema>
    {
        protected override void OnExtend(IExtensibleMutationType mutation)
        {
            mutation.From<Entities.Colaborador, SimpleId<int>>()
                .Create<ColaboradorCreateType, ColaboradorType>()
                .Update<ColaboradorUpdateType, ColaboradorType>()
                .Delete<ColaboradorType>();
        }

        protected override void OnExtend(IExtensibleQueryType query)
        {
            query.From<Entities.Colaborador, SimpleId<int>, ColaboradorType>()
                .GetById()
                .List("colaboradores");
        }
    }
}
