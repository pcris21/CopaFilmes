using CopaDeFilmes.Dominio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CopaDeFilmes.Dominio
{
    public class PrimeiraFase : IPrimeiraFase
    {
        private readonly IComparaFilmes _comparaFilmes;
        public PrimeiraFase(IComparaFilmes comparaFilmes)
        {
            _comparaFilmes = comparaFilmes;
        }
        public List<Filme> DefinirFilmesVencedores(List<Filme> filmes)
        {
            if (filmes.Count != 8)
                throw new ArgumentException("Para iniciar a disputa são necessários 8 filmes");
           

            var filme1 = filmes.ElementAt(0);
            var filme8 = filmes.ElementAt(7);
            var vencedorA = _comparaFilmes.ObterFilmeVencedor(filme1, filme8);

            var filme2 = filmes.ElementAt(1);
            var filme7 = filmes.ElementAt(6);
            var vencedorB = _comparaFilmes.ObterFilmeVencedor(filme2, filme7);

            var filme3 = filmes.ElementAt(2);
            var filme6 = filmes.ElementAt(5);
            var vencedorC = _comparaFilmes.ObterFilmeVencedor(filme3, filme6);

            var filme4 = filmes.ElementAt(3);
            var filme5 = filmes.ElementAt(4);
            var vencedorD = _comparaFilmes.ObterFilmeVencedor(filme4, filme5);

            var listaVencedores = new List<Filme>();
            listaVencedores.Add(vencedorA);
            listaVencedores.Add(vencedorB);
            listaVencedores.Add(vencedorC);
            listaVencedores.Add(vencedorD);

            return listaVencedores;
        }
    }
}
