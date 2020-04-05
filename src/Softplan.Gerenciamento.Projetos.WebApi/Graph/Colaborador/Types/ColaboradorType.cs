using Softplan.Common.Graph.Abstractions;
using Softplan.Common.Graph.Types;

namespace Softplan.Gerenciamento.Projetos.WebApi.Graph.Colaborador.Types
{
    public class ColaboradorType : ObjectGraphType<Entities.Colaborador>
    {
        public ColaboradorType(IDescriptionProvider descriptionProvider): base(descriptionProvider)
        {
            Field(c => c.Id);
            Field(c => c.Nome);
        }
    }
}
