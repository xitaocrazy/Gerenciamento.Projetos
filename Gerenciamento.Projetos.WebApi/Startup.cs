using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using Gerenciamento.Projetos.Repositories;
using Gerenciamento.Projetos.Repositories.Profiles;
using Gerenciamento.Projetos.WebApi.Graph.Schema;
using Softplan.Common.AspNetCore.WebApi.Abstractions;
using Softplan.Common.AspNetCore.WebApi.Abstractions.Extensions;
using Softplan.Common.Graph.Extensions;
using Softplan.Common.Graph.SchemaExtension;
using Softplan.Common.MultiTenancy.EntityFrameworkCore.Abstractions.Extensions;

namespace Gerenciamento.Projetos.WebApi
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
