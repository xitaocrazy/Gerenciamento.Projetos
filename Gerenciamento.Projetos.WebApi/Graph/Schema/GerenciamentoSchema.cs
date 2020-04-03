using GraphQL;
using Softplan.Common.Graph.SchemaExtension;

namespace Gerenciamento.Projetos.WebApi.Graph.Schema
{
    /// <summary>
    /// Schema: Gestão de Processos
    /// </summary>
    public class GerenciamentoSchema : ExtensibleSchema
    {
        public GerenciamentoSchema(IDependencyResolver resolver) : base(resolver)
        {
        }
    }
}