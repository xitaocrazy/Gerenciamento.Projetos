using Gerenciamento.Projetos;
using GraphQL.Types;

namespace Gerenciamento.Projetos.WebApi.Graph.Projeto.Types
{
    public class ProjetoType : ObjectGraphType<Entities.Projeto>
    {
        public ProjetoType()
        {
            Field(p => p.Id, type: typeof(GuidGraphType));
            Field(p => p.Nome);
            Field(p => p.Descricao);
        }
    }
}
