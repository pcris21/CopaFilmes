using CopaDeFilmes.Dominio;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace CopaDeFilmes.Teste
{
    public class ClassificacaoTeste
    {

        [Fact]
        public void NaoDeveAnalisarListaDeFilmesSeQuantidadeDiferenteDois()
        {
            //arrange
            var lista = new List<Filme>();
            lista.Add(new Filme { Id = "tt7784604", Titulo = "Hereditário", Ano = 2018, Nota = 7.8 });

            var classificacao = new Classificacao();
           
            //act / assert
            Assert.Throws<ArgumentException>(() => classificacao.ObterClassificacaoFinal(lista));
        }

        [Fact]
        public void DeveAnalisarListaERetornaListaComPPrimeiroESegundoColocado()
        {
            //arrange
            var listaEntrada = new List<Filme>();
            listaEntrada.Add(new Filme { Id = "tt5463162", Titulo = "Deadpool 2", Ano = 2018, Nota = 8.1 });
            listaEntrada.Add(new Filme { Id = "tt3606756", Titulo = "Os Incríveis 2", Ano = 2018, Nota = 8.5 });

            //act
            var classificacao = new Classificacao();

            var resultado = classificacao.ObterClassificacaoFinal(listaEntrada);

            //assert          
            Assert.Equal(2, resultado.Count);
            Assert.Equal(listaEntrada[1].Id, resultado[0].Id);
            Assert.Equal(listaEntrada[0].Id, resultado[1].Id);


        }

    }
}
