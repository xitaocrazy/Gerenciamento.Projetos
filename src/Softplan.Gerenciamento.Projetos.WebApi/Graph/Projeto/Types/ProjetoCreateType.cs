using Softplan.Common.Graph.Abstractions;
using Softplan.Common.Graph.Types;

namespace Softplan.Gerenciamento.Projetos.WebApi.Graph.Projeto.Types
{
    public class ProjetoCreateType : InputObjectGraphType<Entities.Projeto>
    {
        public ProjetoCreateType(IDescriptionProvider descriptionProvider) : base(descriptionProvider)
        {
            Field(p => p.Nome);
            Field(p => p.Descricao);
        }
    }
}
