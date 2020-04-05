using Softplan.Common.Graph.Abstractions;
using Softplan.Common.Graph.Types;

namespace Softplan.Gerenciamento.Projetos.WebApi.Graph.Colaborador.Types
{
    public class ColaboradorCreateType : InputObjectGraphType<Entities.Colaborador>
    {
        public ColaboradorCreateType(IDescriptionProvider descriptionProvider) : base(descriptionProvider)
        {
            Field(c => c.Nome);
        }
    }
}
