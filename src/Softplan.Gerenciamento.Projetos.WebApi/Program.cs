using Microsoft.AspNetCore.Hosting;
using Softplan.Common.AspNetCore.Abstractions;

namespace Softplan.Gerenciamento.Projetos.WebApi
{
    public class Program
    {
        public static void Main(string[] args) =>
            CreateHostBuilder(args).Build().Run();

        private static IWebHostBuilder CreateHostBuilder(string[] args) =>
            SoftplanWebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
