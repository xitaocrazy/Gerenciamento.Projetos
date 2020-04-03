using System;
using Softplan.Common.Core.Entities;
using Softplan.Common.Graph.Abstractions;
using Softplan.Common.Graph.SchemaExtension;
using Gerenciamento.Projetos;
using Gerenciamento.Projetos.WebApi.Graph.Colaborador.Types;
using Gerenciamento.Projetos.WebApi.Graph.Schema;

namespace Gerenciamento.Projetos.WebApi.Graph.Colaborador
{
    public class ColaboradorSchemaExtensions : SchemaExtension<GerenciamentoSchema>
    {
        protected override void OnExtend(IExtensibleMutationType mutation)
        {
            mutation.From<Entities.Colaborador, SimpleId<Guid>>()
                .Create<ColaboradorCreateType, ColaboradorType>()
                .Update<ColaboradorUpdateType, ColaboradorType>()
                .Delete<ColaboradorType>();
        }

        protected override void OnExtend(IExtensibleQueryType query)
        {
            query.From<Entities.Colaborador, SimpleId<Guid>, ColaboradorType>()
                .GetById()
                .List("colaboradores");
        }
    }
}
