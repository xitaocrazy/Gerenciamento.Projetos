using Softplan.Common.Graph.Abstractions;
using Softplan.Common.Graph.Types;

namespace Gerenciamento.Projetos.WebApi.Graph.Colaborador.Types
{
    public class ColaboradorType : ObjectGraphType<Entities.Colaborador>
    {
        public ColaboradorType(IDescriptionProvider descriptionProvider): base(descriptionProvider)
        {
            Field(c => c.Id, type: typeof(GuidGraphType));
            Field(c => c.Nome);
        }
    }
}
