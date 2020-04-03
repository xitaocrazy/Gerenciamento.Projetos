using Gerenciamento.Projetos;
using GraphQL.Types;

namespace Gerenciamento.Projetos.WebApi.Graph.Colaborador.Types
{
    public class ColaboradorType : ObjectGraphType<Entities.Colaborador>
    {
        public ColaboradorType()
        {
            Field(c => c.Id, type: typeof(GuidGraphType));
            Field(c => c.Nome);
        }
    }
}
