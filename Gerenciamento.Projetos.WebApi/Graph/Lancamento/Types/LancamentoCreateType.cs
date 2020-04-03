using Gerenciamento.Projetos;
using Gerenciamento.Projetos.WebApi.Graph.Colaborador.Types;
using Softplan.Common.Graph.Abstractions;
using Softplan.Common.Graph.Types;

namespace Gerenciamento.Projetos.WebApi.Graph.Lancamento.Types
{
    public class LancamentoCreateType : InputObjectGraphType<Entities.Lancamento>
    {
        public LancamentoCreateType(IDescriptionProvider descriptionProvider) : base(descriptionProvider)
        {
            Field(l => l.QuantidadeDeHoras);
            Field(l => l.ColaboradorId, type: typeof(GuidGraphType));
            Field(l => l.ProjetoId, type: typeof(GuidGraphType));
            Field(l => l.Colaborador, false, typeof(ColaboradorType));
        }
    }
}
