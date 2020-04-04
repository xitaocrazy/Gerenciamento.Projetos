using GraphQL;
using Softplan.Common.Graph.SchemaExtension;

namespace Gerenciamento.Projetos.WebApi.Graph.Schema
{
    public class GerenciamentoSchema : ExtensibleSchema
    {
        public GerenciamentoSchema(IDependencyResolver dependencyResolver) : base(dependencyResolver)
        {
        }
    }
}