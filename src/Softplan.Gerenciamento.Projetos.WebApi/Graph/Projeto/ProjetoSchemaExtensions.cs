using Softplan.Common.Core.Entities;
using Softplan.Common.Graph.Abstractions;
using Softplan.Common.Graph.SchemaExtension;
using Softplan.Gerenciamento.Projetos.WebApi.Graph.Projeto.Types;
using Softplan.Gerenciamento.Projetos.WebApi.Graph.Schema;

namespace Softplan.Gerenciamento.Projetos.WebApi.Graph.Projeto
{
    public class ProjetoSchemaExtensions : SchemaExtension<GerenciamentoSchema>
    {
        protected override void OnExtend(IExtensibleMutationType mutation)
        {
            mutation.From<Entities.Projeto, SimpleId<int>>()
                .Create<ProjetoCreateType, ProjetoType>()
                .Update<ProjetoUpdateType, ProjetoType>()
                .Delete<ProjetoType>();
        }

        protected override void OnExtend(IExtensibleQueryType query)
        {
            query.From<Entities.Projeto, SimpleId<int>, ProjetoType>()
                .GetById()
                .List("projetos");
        }
    }
}
