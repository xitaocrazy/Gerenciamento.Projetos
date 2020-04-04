using Gerenciamento.Projetos.Repositories.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Gerenciamento.Projetos.Repositories.Maps
{
    public class LancamentoModelMap : IEntityTypeConfiguration<LancamentoModel>
    {
        public void Configure(EntityTypeBuilder<LancamentoModel> builder)
        {
            builder.ToTable("lancamento");
            builder.HasKey(c => c.Id);
            
            builder.Property(c => c.Id)
                .HasColumnName("idLancamento")
                .ValueGeneratedOnAdd();
            
            builder.Property(c => c.ColaboradorId)
                .HasColumnName("idColaborador")
                .ValueGeneratedOnAdd();
            
            builder.Property(c => c.ProjetoId)
                .HasColumnName("idProjeto")
                .ValueGeneratedOnAdd();
            
            builder.Property(c => c.QuantidadeDeHoras)
                .HasColumnName("quantidadeHoras");
            
            builder.HasOne(l => l.Colaborador)
                .WithMany(c => c.Lancamentos)
                .HasForeignKey(l => l.ColaboradorId)
                .HasPrincipalKey(c => c.Id);
            
            builder.HasOne(l => l.Projeto)
                .WithMany(p => p.Lancamentos)
                .HasForeignKey(l => l.ProjetoId)
                .HasPrincipalKey(p => p.Id);
        }
    }
}