using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Gerenciamento.Projetos.Repositories;
using Gerenciamento.Projetos.Repositories.Profiles;
using Gerenciamento.Projetos.WebApi.Graph.Schema;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Softplan.Common.AspNetCore.WebApi.Abstractions;
using Softplan.Common.AspNetCore.WebApi.Abstractions.Extensions;
using Softplan.Common.Graph.Extensions;
using Softplan.Common.Graph.SchemaExtension;
using Softplan.Common.MultiTenancy.EntityFrameworkCore.Abstractions.Extensions;
using IHostingEnvironment = Microsoft.AspNetCore.Hosting.IHostingEnvironment;

namespace Gerenciamento.Projetos.WebApi
{
    public class Startup : WebApiBaseStartup
    {
        public Startup(IConfiguration configuration, IHostingEnvironment hostingEnvironment) : base(configuration, hostingEnvironment)
        {
        }

        public override void ConfigureServices(IServiceCollection services)
        {
            services.AddMultiTenancyDbContext<GerenciamentoContext>("MP", false, ServiceLifetime.Singleton);
            services.AddSingleton<IExtensibleSchema, GerenciamentoSchema>();
            services.AddCorsPolicy(Configuration);
            base.ConfigureServices(services);
        }

        public override void Configure(IApplicationBuilder app)
        {
            base.Configure(app);
            app.UseGraphQL<IExtensibleSchema>("GRP");
        }

        protected override void ConfigureAutoMapper(
IServiceProvider services,
IMapperConfigurationExpression configuration)
        {
            configuration.AddProfile<ColaboradorProfile>();
            configuration.AddProfile<LancamentoProfile>();
            configuration.AddProfile<ProjetoProfile>();
        }

    }
}
