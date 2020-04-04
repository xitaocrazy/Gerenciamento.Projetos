
using Softplan.Common.Graph.Abstractions;
using Softplan.Common.Graph.Types;

namespace Gerenciamento.Projetos.WebApi.Graph.Projeto.Types
{
    public class ProjetoType : ObjectGraphType<Entities.Projeto>
    {
        public ProjetoType(IDescriptionProvider descriptionProvider) : base(descriptionProvider)
        {
            Field(p => p.Id, type: typeof(GuidGraphType));
            Field(p => p.Nome);
            Field(p => p.Descricao);
        }
    }
}
