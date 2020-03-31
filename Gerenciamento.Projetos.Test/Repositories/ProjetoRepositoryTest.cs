using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Gerenciamento.Projetos.Entities;
using Gerenciamento.Projetos.Repositories;
using Gerenciamento.Projetos.Repositories.Abstractions;
using Gerenciamento.Projetos.Repositories.Repositories;
using Gerenciamento.Projetos.WebApi;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Softplan.Common.Test.AspNetCore.Fixtures;
using Xunit;

namespace Gerenciamento.Projetos.Test.Repositories
{
    public class ProjetoRepositoryTest
    {
        private TestServerFixture _fixture;
        private IProjetoRepository _repository;

        public ProjetoRepositoryTest()
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
                services.AddScoped<IProjetoRepository, ProjetoRepository>();
            };
            _repository = _fixture.Resolve<IProjetoRepository>();
        }

        ~ProjetoRepositoryTest()
        {
            _repository = default;
        }

        [Fact]
        public async Task ShouldSaveAColaboratorIntoTheDatabase()
        {
            var projeto = new Projeto
            {
                Id = Guid.NewGuid(),
                Nome = "Guido",
                Descricao = "abc"
            };
            await _repository.AddProjetoAsync(projeto);
            var projetoFromDatabase = _repository.FindByIdAsync(projeto.Id);
            Assert.NotNull(projetoFromDatabase);
        }

        [Fact]
        public async Task ShouldSaveAColaboratorWithLancamentosIntoTheDatabase()
        {
            var projeto = new Projeto
            {
                Id = Guid.NewGuid(),
                Nome = "Guido",
                Descricao = "abc"
            };
            var colaborador = new Colaborador
            {
                Id = Guid.NewGuid(),
                Nome = "Guido"
            };
            var horas = new HorasTrabalhadas
            {
                Id = Guid.NewGuid(),
                QuantidadeDeHoras = 10
            };
            var lancamento = new Lancamento
            {
                ProjetoId = projeto.Id,
                ColaboradorId = colaborador.Id,
                HorasTrabalhadasId = horas.Id,
                Colaborador = colaborador,
                Projeto = projeto,
                Horas = horas
            };
            projeto.AddLancamento(lancamento);
            await _repository.AddProjetoAsync(projeto);
            var projetosFromDatabase = await _repository.FindProjetosComLancamentos();
            Assert.NotNull(projetosFromDatabase.FirstOrDefault());
            Assert.NotEmpty(projetosFromDatabase.FirstOrDefault().Lancamentos);
        }

        [Fact]
        public async Task ShouldUpdateAColaboratorIntoTheDatabase()
        {
            //Given
            var projeto = new Projeto
            {
                Id = Guid.NewGuid(),
                Nome = "Guido",
                Descricao = "abc"
            };
            //When
            await _repository.AddProjetoAsync(projeto);
            projeto.Nome = "Icaro";
            await _repository.UpdateProjetoAsync(projeto);
            var projetoAtualizado = await _repository.FindByIdAsync(projeto.Id);
            //Then
            Assert.NotNull(projetoAtualizado);
            Assert.Equal(projetoAtualizado.Id.ToString(), projeto.Id.ToString());
            Assert.Equal(projetoAtualizado.Nome, projeto.Nome);
        }

        [Fact]
        public async Task ShouldNotUpdateAColaboratorIntoTheDatabaseIfHeDoesNotExists()
        {
            //Given
            var projeto = new Projeto
            {
                Id = Guid.NewGuid(),
                Nome = "Guido",
                Descricao = "abc"
            };
            //When
            projeto.Nome = "Icaro";
            //Then
            await Assert.ThrowsAsync<DbUpdateConcurrencyException>(async () => await _repository.UpdateProjetoAsync(projeto));
        }

        [Fact]
        public async Task ShouldDeleteAColaboratorFromTheDatabase()
        {
            //Given
            var projeto = new Projeto
            {
                Id = Guid.NewGuid(),
                Nome = "Guido",
                Descricao = "abc"
            };
            //When
            await _repository.AddProjetoAsync(projeto);
            await _repository.RemoveProjetoAsync(projeto);
            //Then
            var projetoFromDatabase = await _repository.FindByIdAsync(projeto.Id);
            Assert.Null(projetoFromDatabase);
        }

        [Fact]
        public async Task ShouldNotDeleteAColaboratorFromTheDatabaseIfHeDoesNotExist()
        {
            //Given
            var projeto = new Projeto
            {
                Id = Guid.NewGuid(),
                Nome = "Guido",
                Descricao = "abc"
            };
            //Then
            await Assert.ThrowsAsync<DbUpdateConcurrencyException>(async () => await _repository.RemoveProjetoAsync(projeto));
        }
    }
}
