using Softplan.Common.Graph.Abstractions;

namespace Softplan.Gerenciamento.Projetos.WebApi.Graph.Colaborador.Types
{
    public class ColaboradorUpdateType : ColaboradorCreateType
    {
        public ColaboradorUpdateType(IDescriptionProvider provider) : base(provider)
        {
            Field(c => c.Id);
        }
    }
}
