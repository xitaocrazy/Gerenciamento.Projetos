using Gerenciamento.Projetos.Repositories.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Gerenciamento.Projetos.Repositories.Maps
{
    public class ProjetoModelMap : IEntityTypeConfiguration<ProjetoModel>
    {
        public void Configure(EntityTypeBuilder<ProjetoModel> builder)
        {
            builder.ToTable("projeto");
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Id)
                .HasColumnName("idProjeto")
                .ValueGeneratedOnAdd();
            builder.Property(p => p.Nome)

                .HasColumnName("nome")
                .HasMaxLength(30);

            builder.Property(p => p.Descricao)
                .HasColumnName("descricao");

            builder.HasMany(p => p.Lancamentos)
                .WithOne(l => l.Projeto)
                .HasForeignKey(l => l.ProjetoId)
                .HasPrincipalKey(p => p.Id);
        }
    }
}
