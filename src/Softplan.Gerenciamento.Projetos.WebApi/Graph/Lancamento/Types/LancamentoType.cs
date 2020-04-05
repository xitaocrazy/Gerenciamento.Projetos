using Softplan.Common.Graph.Abstractions;
using Softplan.Common.Graph.Types;
using Softplan.Gerenciamento.Projetos.WebApi.Graph.Colaborador.Types;
using Softplan.Gerenciamento.Projetos.WebApi.Graph.Projeto.Types;

namespace Softplan.Gerenciamento.Projetos.WebApi.Graph.Lancamento.Types
{
    public class LancamentoType : ObjectGraphType<Entities.Lancamento>
    {
        public LancamentoType(IDescriptionProvider descriptionProvider) : base(descriptionProvider)
        {
            Field(l => l.Id);
            Field(l => l.QuantidadeDeHoras);
            Field(l => l.Colaborador, type: typeof(ColaboradorType));
            Field(l => l.Projeto, type: typeof(ProjetoType));
        }
    }
}
