using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Gerenciamento.Projetos.Entities;
using Gerenciamento.Projetos.Repositories;
using Gerenciamento.Projetos.Repositories.Abstractions;
using Gerenciamento.Projetos.Repositories.Profiles;
using Gerenciamento.Projetos.Repositories.Repositories;
using Gerenciamento.Projetos.WebApi;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Softplan.Common.Test.AspNetCore.Fixtures;
using Xunit;

namespace Gerenciamento.Projetos.Test.Repositories
{
    public class LancamentoRepositoryTest
    {
        private TestServerFixture _fixture;
        private ILancamentoRepository _repository;

        public LancamentoRepositoryTest()
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
                services.AddScoped<ILancamentoRepository, LancamentoRepository>();
            };
            _repository = _fixture.Resolve<ILancamentoRepository>();
        }

        ~LancamentoRepositoryTest()
        {
            _repository = default;
        }

        [Fact]
        public async Task ShouldSaveALancamentoIntoTheDatabase()
        {
            var lancamento = CriarLancamento(10);
            await _repository.AddLancamentoAsync(lancamento);
            var lancamentoFromDatabase = await _repository.FindByIdAsync(lancamento.Id);
            Assert.NotNull(lancamentoFromDatabase);
        }

        private Lancamento CriarLancamento(int quantidade)
        {
            var colaborador = new Colaborador
            {
                Id = Guid.NewGuid(),
                Nome = "Guido"
            };
            var projeto = new Projeto
            {
                Id = Guid.NewGuid(),
                Nome = "abc",
                Descricao = "teste"
            };
            var lancamento = new Lancamento
            {
                Id = Guid.NewGuid(),
                ColaboradorId = colaborador.Id,
                ProjetoId = projeto.Id,
                Colaborador = colaborador,
                Projeto = projeto,
                QuantidadeDeHoras = quantidade
            };
            return lancamento;
        }

        [Fact]
        public async Task ShouldSaveALancamentoWithColaboradorIntoTheDatabase()
        {
            var lancamento = CriarLancamento(20);
            await _repository.AddLancamentoAsync(lancamento);
            var lancamentosComColaboradorEProjeto = await _repository.FindLancamentosComColaboradoresEProjetosAsync();
            Assert.NotNull(lancamentosComColaboradorEProjeto.FirstOrDefault());
            Assert.NotNull(lancamentosComColaboradorEProjeto.FirstOrDefault().Colaborador);
            Assert.NotNull(lancamentosComColaboradorEProjeto.FirstOrDefault().Projeto);
        }

        [Fact]
        public async Task ShouldDeleteALancamentoFromTheDatabase()
        {
            //Given
            var lancamento = CriarLancamento(30);
            //When
            await _repository.AddLancamentoAsync(lancamento);
            await _repository.RemoveLancamentoAsync(lancamento);
            //Then
            var lancamentoFromDatabase = await _repository.FindByIdAsync(lancamento.Id);
            Assert.Null(lancamentoFromDatabase);
        }

        [Fact]
        public async Task ShouldNotDeleteALancamentoFromTheDatabaseIfHeDoesNotExist()
        {
            //Given
            var lancamento = CriarLancamento(40);
            //Then
            await Assert.ThrowsAsync<DbUpdateConcurrencyException>(async () => await _repository.RemoveLancamentoAsync(lancamento));
        }
    }
}
