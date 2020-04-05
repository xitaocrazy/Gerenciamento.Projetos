using System;
using AutoMapper;
using Softplan.Gerenciamento.Projetos.Repositories;
using Softplan.Gerenciamento.Projetos.Repositories.Profiles;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Softplan.Common.AspNetCore.WebApi.Abstractions;
using Softplan.Common.AspNetCore.WebApi.Abstractions.Extensions;
using Softplan.Common.Graph.Extensions;
using Softplan.Common.Graph.SchemaExtension;
using Softplan.Common.MultiTenancy.EntityFrameworkCore.Abstractions.Extensions;
using Softplan.Gerenciamento.Projetos.WebApi.Graph.Schema;

namespace Softplan.Gerenciamento.Projetos.WebApi
{
    public class Startup : WebApiBaseStartup
    {
        private readonly IHostingEnvironment _env;
        public Startup(IConfiguration configuration, IHostingEnvironment env) : base(configuration, env) => _env = env;

        public override void ConfigureServices(IServiceCollection services)
        {
            services.AddMultiTenancyDbContext<GerenciamentoContext>("MP", false, ServiceLifetime.Singleton);
            services.AddSingleton<IExtensibleSchema, GerenciamentoSchema>();
            services.AddCorsPolicy(Configuration);
            base.ConfigureServices(services);
        }

        public override void Configure(IApplicationBuilder app)
        {
            app.UseCors(_env.IsDevelopment() ? "DevelopmentCorsPolicy" : "ProductionCorsPolicy");
            base.Configure(app);
            app.UseGraphQL<IExtensibleSchema>("GRP");
        }

        protected override void ConfigureAutoMapper(IServiceProvider services, IMapperConfigurationExpression configuration)
        {
            configuration.AddProfile<ColaboradorProfile>();
            configuration.AddProfile<LancamentoProfile>();
            configuration.AddProfile<ProjetoProfile>();
        }
    }
}
