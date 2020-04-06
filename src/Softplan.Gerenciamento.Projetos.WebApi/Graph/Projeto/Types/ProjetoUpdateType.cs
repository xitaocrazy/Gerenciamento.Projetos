using Softplan.Common.Graph.Abstractions;

namespace Softplan.Gerenciamento.Projetos.WebApi.Graph.Projeto.Types
{
    public class ProjetoUpdateType : ProjetoCreateType
    {
        public ProjetoUpdateType(IDescriptionProvider provider) : base(provider)
        {
            Field(p => p.Id);
        }
    }
}
