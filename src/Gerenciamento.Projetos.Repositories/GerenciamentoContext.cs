using System;
using Microsoft.EntityFrameworkCore;
using Softplan.Common.MultiTenancy.EntityFrameworkCore.Abstractions;

namespace Gerenciamento.Projetos.Repositories
{
    public class GerenciamentoContext : MultiTenancyDbContext
    {
        public GerenciamentoContext(IServiceProvider serviceProvider) : base(serviceProvider)
        {
        }

        protected override void OnMultiTenancyModelCreating(ModelBuilder modelBuilder)
        { 
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(GerenciamentoContext).Assembly);
        }
    }
}
