using Softplan.Common.Graph.Abstractions;
using Softplan.Common.Graph.Types;

namespace Softplan.Gerenciamento.Projetos.WebApi.Graph.Projeto.Types
{
    public class ProjetoType : ObjectGraphType<Entities.Projeto>
    {
        public ProjetoType(IDescriptionProvider descriptionProvider) : base(descriptionProvider)
        {
            Field(p => p.Id);
            Field(p => p.Nome);
            Field(p => p.Descricao);
        }
    }
}
