
using System;
using Gerenciamento.Projetos.WebApi.Graph.Projeto.Types;
using Gerenciamento.Projetos.WebApi.Graph.Schema;
using Softplan.Common.Core.Entities;
using Softplan.Common.Graph.Abstractions;
using Softplan.Common.Graph.SchemaExtension;

namespace Gerenciamento.Projetos.WebApi.Graph.Projeto
{
    public class ProjetoSchemaExtensions : SchemaExtension<GerenciamentoSchema>
    {
        protected override void OnExtend(IExtensibleMutationType mutation)
        {
            mutation.From<Entities.Projeto, SimpleId<Guid>>()
                .Create<ProjetoCreateType, ProjetoType>()
                .Update<ProjetoUpdateType, ProjetoType>()
                .Delete<ProjetoType>();
        }

        protected override void OnExtend(IExtensibleQueryType query)
        {
            query.From<Entities.Projeto, SimpleId<Guid>, ProjetoType>()
                .GetById()
                .List("projetos");
        }
    }
}
