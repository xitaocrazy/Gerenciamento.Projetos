using Gerenciamento.Projetos;
using Gerenciamento.Projetos.WebApi.Graph.Colaborador.Types;
using Gerenciamento.Projetos.WebApi.Graph.Projeto.Types;
using GraphQL.Types;

namespace Gerenciamento.Projetos.WebApi.Graph.Lancamento.Types
{
    public class LancamentoType : ObjectGraphType<Entities.Lancamento>
    {
        public LancamentoType()
        {
            Field(l => l.Id, type: typeof(GuidGraphType));
            Field(l => l.ColaboradorId, type: typeof(GuidGraphType));
            Field(l => l.ProjetoId, type: typeof(GuidGraphType));
            Field(l => l.QuantidadeDeHoras);
            Field(l => l.Colaborador, type: typeof(ColaboradorType));
            Field(l => l.Projeto, type: typeof(ProjetoType));
        }
    }
}
