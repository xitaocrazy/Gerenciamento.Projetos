using GraphQL;
using Softplan.Common.Graph.SchemaExtension;

namespace Softplan.Gerenciamento.Projetos.WebApi.Graph.Schema
{
    public class GerenciamentoSchema : ExtensibleSchema
    {
        public GerenciamentoSchema(IDependencyResolver dependencyResolver) : base(dependencyResolver)
        {
        }
    }
}