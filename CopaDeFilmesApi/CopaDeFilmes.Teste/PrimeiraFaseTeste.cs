using CopaDeFilmes.Dominio;
using CopaDeFilmes.Dominio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace CopaDeFilmes.Teste
{
    public class PrimeiraFaseTeste
    {
       
        [Fact]
        public void NaoDeveAnalisarListaDeFilmesSeQuantidadeDiferenteOito()
        {
            //arrange
            var lista = new List<Filme>() ;
            lista.Add(new Filme { Id = "tt3606756", Titulo = "Os Incríveis 2", Ano = 2018, Nota = 8.5 });
            lista.Add(new Filme { Id = "tt7784604", Titulo = "Hereditário", Ano = 2018, Nota = 7.8 });

            var comparaFilmes = new ComparaFilmes();
            var primeiraFase = new PrimeiraFase(comparaFilmes);

            //act / assert
            Assert.Throws<ArgumentException>(() => primeiraFase.DefinirFilmesVencedores(lista));           

        }

        [Fact]
        public void DeveAnalisarListaDeFilmesEClassificarQuatroFilmes()
        {
            //arrange
            var listaEntrada = new List<Filme>();
            listaEntrada.Add(new Filme { Id = "tt3606756", Titulo = "Os Incríveis 2", Ano = 2018, Nota = 8.5 }); //1
            listaEntrada.Add(new Filme { Id = "tt7784604", Titulo = "Hereditário", Ano = 2018, Nota = 7.8 });//2
            listaEntrada.Add(new Filme { Id = "tt4881806", Titulo = "Jurassic World: Reino Ameaçado 2", Ano = 2018, Nota = 6.7 });//3
            listaEntrada.Add(new Filme { Id = "tt5164214", Titulo = "Oito Mulheres e um Segredo", Ano = 2018, Nota = 6.3 });//4
            listaEntrada.Add(new Filme { Id = "tt5463162", Titulo = "Deadpool 2", Ano = 2018, Nota = 8.1 });//5
            listaEntrada.Add(new Filme { Id = "tt2854926", Titulo = "Te Peguei!", Ano = 2018, Nota = 7.1 });//6
            listaEntrada.Add(new Filme { Id = "tt1365519", Titulo = "Tomb Raider: A Origem", Ano = 2018, Nota = 6.5 });//7
            listaEntrada.Add(new Filme { Id = "tt1825683", Titulo = "Pantera Negra", Ano = 2018, Nota = 7.5 });//8
           
            var listaSaida = new List<Filme>();
            listaSaida.Add(new Filme { Id = "tt3606756", Titulo = "Os Incríveis 2", Ano = 2018, Nota = 8.5 });
            listaSaida.Add(new Filme { Id = "tt7784604", Titulo = "Hereditário", Ano = 2018, Nota = 7.8 });
            listaSaida.Add(new Filme { Id = "tt2854926", Titulo = "Te Peguei!", Ano = 2018, Nota = 7.1 });
            listaSaida.Add(new Filme { Id = "tt5463162", Titulo = "Deadpool 2", Ano = 2018, Nota = 8.1 });

            var comparaFilmes = new ComparaFilmes();
            var primeiraFase = new PrimeiraFase(comparaFilmes);

            //act
            var resultado = primeiraFase.DefinirFilmesVencedores(listaEntrada);

           //assert
            Assert.Equal(4, resultado.Count);
            Assert.Equal(listaSaida[0].Id,resultado[0].Id);
            Assert.Equal(listaSaida[1].Id, resultado[1].Id);
            Assert.Equal(listaSaida[2].Id, resultado[2].Id);
            Assert.Equal(listaSaida[3].Id, resultado[3].Id);




        }




    }
}
