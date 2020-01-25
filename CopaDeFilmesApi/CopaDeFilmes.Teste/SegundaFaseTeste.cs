using CopaDeFilmes.Dominio;
using System;
using System.Collections.Generic;
using Xunit;

namespace CopaDeFilmes.Teste
{
    public class SegundaFaseTeste
    {
       
        [Fact]
        public void NaoDeveAnalisarListaDeFilmesSeQuantidadeDiferenteQuatro()
        {
            //arrange
            var lista = new List<Filme>();
            lista.Add(new Filme { Id = "tt3606756", Titulo = "Os Incríveis 2", Ano = 2018, Nota = 8.5 });
            lista.Add(new Filme { Id = "tt7784604", Titulo = "Hereditário", Ano = 2018, Nota = 7.8 });

            var comparaFilmes = new ComparaFilmes();
            var segundaFase = new SegundaFase(comparaFilmes);

            //act / assert
            Assert.Throws<ArgumentException>(() => segundaFase.DefinirFilmesVencedores(lista));
        }

        [Fact]
        public void DeveAnalisarListaDeFilmesEClassificarDoisFilmes()
        {
            //arrange
            var listaEntrada = new List<Filme>();
            listaEntrada.Add(new Filme { Id = "tt3606756", Titulo = "Os Incríveis 2", Ano = 2018, Nota = 8.5 });
            listaEntrada.Add(new Filme { Id = "tt7784604", Titulo = "Hereditário", Ano = 2018, Nota = 7.8 });
            listaEntrada.Add(new Filme { Id = "tt2854926", Titulo = "Te Peguei!", Ano = 2018, Nota = 7.1 });
            listaEntrada.Add(new Filme { Id = "tt5463162", Titulo = "Deadpool 2", Ano = 2018, Nota = 8.1 });

            var listaSaida = new List<Filme>();
            listaSaida.Add(new Filme { Id = "tt3606756", Titulo = "Os Incríveis 2", Ano = 2018, Nota = 8.5 });
            listaSaida.Add(new Filme { Id = "tt5463162", Titulo = "Deadpool 2", Ano = 2018, Nota = 8.1 });

            var comparaFilmes = new ComparaFilmes();
            var segundafase = new SegundaFase(comparaFilmes);

            //act
            var resultado = segundafase.DefinirFilmesVencedores(listaEntrada);

            //assert
            Assert.Equal(2, resultado.Count);
            Assert.Equal(listaSaida[0].Id, resultado[0].Id);
            Assert.Equal(listaSaida[1].Id, resultado[1].Id);
        }

       
    }
}
