/*
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Gerenciamento.Projetos.Entities;
using Gerenciamento.Projetos.Repositories;
using Gerenciamento.Projetos.Repositories.Repositories;
using Gerenciamento.Projetos.WebApi;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Softplan.Common.Test.AspNetCore.Fixtures;
using Xunit;

namespace Gerenciamento.Projetos.Test.Repositories
{
    public class ColaboradorRepositoryTest
    {
        private TestServerFixture _fixture;

        public ColaboradorRepositoryTest()
        {
            _fixture = new TestServerFixture { Startup = typeof(Startup) };
            var configuration = new Dictionary<string, string>
            {
                ["DATABASE_PROVIDER"] = "InMemory",
                ["SUPPORTED_CULTURES"] = "pt-BR"
            };
            _fixture.ConfigureAppConfiguration = (_, builder) => builder.AddInMemoryCollection(configuration);
            _fixture.ConfigureServices = (_, services) =>
            {
                services.AddDbContext<GerenciamentoContext>(ServiceLifetime.Singleton);
                services.AddScoped<IColaboradorRepository, ColaboradorRepository>();
            };
            _repository = _fixture.Resolve<IColaboradorRepository>();
        }

        ~ColaboradorRepositoryTest()
        {
            _repository = default;
        }

        [Fact]
        public async Task ShouldSaveAColaboratorIntoTheDatabase()
        {
            var colaborador = new Colaborador
            {
                Id = Guid.NewGuid(),
                Nome = "Guido"
            };
            await _repository.AddColaboradorAsync(colaborador);
            var colaboradorFromDatabase = _repository.FindByIdAsync(colaborador.Id);
            Assert.NotNull(colaboradorFromDatabase);
        }

        [Fact]
        public async Task ShouldUpdateAColaboratorIntoTheDatabase()
        {
            //Given
            var colaborador = new Colaborador
            {
                Id = Guid.NewGuid(),
                Nome = "Guido"
            };
            //When
            await _repository.AddColaboradorAsync(colaborador);
            colaborador.Nome = "Icaro";
            await _repository.UpdateColaboradorAsync(colaborador);
            var colaboradorAtualizado = await _repository.FindByIdAsync(colaborador.Id);
            //Then
            Assert.NotNull(colaboradorAtualizado);
            Assert.Equal(colaboradorAtualizado.Id.ToString(), colaborador.Id.ToString());
            Assert.Equal(colaboradorAtualizado.Nome, colaborador.Nome);
        }

        [Fact]
        public async Task ShouldNotUpdateAColaboratorIntoTheDatabaseIfHeDoesNotExists()
        {
            //Given
            var colaborador = new Colaborador
            {
                Id = Guid.NewGuid(),
                Nome = "Guido"
            };
            //When
            colaborador.Nome = "Icaro";
            //Then
            await Assert.ThrowsAsync<DbUpdateConcurrencyException>(async () => await _repository.UpdateColaboradorAsync(colaborador));
        }

        [Fact]
        public async Task ShouldDeleteAColaboratorFromTheDatabase()
        {
            //Given
            var colaborador = new Colaborador
            {
                Id = Guid.NewGuid(),
                Nome = "Guido"
            };
            //When
            await _repository.AddColaboradorAsync(colaborador);
            await _repository.RemoveColaboradorAsync(colaborador);
            //Then
            var colaboradorFromDatabase = await _repository.FindByIdAsync(colaborador.Id);
            Assert.Null(colaboradorFromDatabase);
        }

        [Fact]
        public async Task ShouldNotDeleteAColaboratorFromTheDatabaseIfHeDoesNotExist()
        {
            //Given
            var colaborador = new Colaborador
            {
                Id = Guid.NewGuid(),
                Nome = "Guido"
            };
            //Then
            await Assert.ThrowsAsync<DbUpdateConcurrencyException>(async () => await _repository.RemoveColaboradorAsync(colaborador));
        }
    }
}
*/
