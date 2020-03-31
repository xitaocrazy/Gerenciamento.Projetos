using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Gerenciamento.Projetos.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Softplan.Common.AspNetCore.WebApi.Abstractions;
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
            services.AddDbContext<GerenciamentoContext>(ServiceLifetime.Singleton);
            base.ConfigureServices(services);
        }

        public override void Configure(IApplicationBuilder app)
        {
            base.Configure(app);
            app.UseMvc();
            app.UseSwagger();
        }
    }
}
