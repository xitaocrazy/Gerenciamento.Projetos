using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Softplan.Gerenciamento.Projetos.Repositories.Models;

namespace Softplan.Gerenciamento.Projetos.Repositories.Maps
{
    public class ColaboradorModelMap : IEntityTypeConfiguration<ColaboradorModel>
    {
        public void Configure(EntityTypeBuilder<ColaboradorModel> builder)
        {
            builder.ToTable("colaborador");
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Id)
                .HasColumnName("idColaborador")
                .ValueGeneratedOnAdd();

            builder.Property(c => c.Nome)
                .HasColumnName("nome")
                .HasMaxLength(30);

            builder.HasMany(c => c.Lancamentos)
                .WithOne(l => l.Colaborador)
                .HasForeignKey(l => l.ColaboradorId)
                .HasPrincipalKey(c => c.Id);
        }
    }
}
