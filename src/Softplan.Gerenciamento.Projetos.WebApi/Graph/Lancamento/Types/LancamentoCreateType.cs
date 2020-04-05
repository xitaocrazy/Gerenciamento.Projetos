using Softplan.Common.Graph.Abstractions;
using Softplan.Common.Graph.Types;

namespace Softplan.Gerenciamento.Projetos.WebApi.Graph.Lancamento.Types
{
    public class LancamentoCreateType : InputObjectGraphType<Entities.Lancamento>
    {
        public LancamentoCreateType(IDescriptionProvider descriptionProvider) : base(descriptionProvider)
        {
            Field(l => l.QuantidadeDeHoras);
            Field(l => l.ColaboradorId);
            Field(l => l.ProjetoId);
        }
    }
}
