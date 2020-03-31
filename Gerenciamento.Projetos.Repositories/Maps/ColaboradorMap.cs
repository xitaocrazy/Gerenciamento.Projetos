using Gerenciamento.Projetos.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Gerenciamento.Projetos.Repositories.Maps
{
    public class ColaboradorMap : IEntityTypeConfiguration<Colaborador>
    {
        public void Configure(EntityTypeBuilder<Colaborador> builder)
        {
            builder.ToTable("colaborador").HasKey(c => c.Id);
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
