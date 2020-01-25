using CopaDeFilmes.Dominio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CopaDeFilmes.Dominio
{
    public class SegundaFase : ISegundaFase
    {
        private readonly IComparaFilmes _comparaFilmes;
        public SegundaFase(IComparaFilmes comparaFilmes)
        {
            _comparaFilmes = comparaFilmes;
        }
        public List<Filme> DefinirFilmesVencedores(List<Filme> filmes)
        {
            if (filmes.Count != 4)
                throw new ArgumentException("Para disputa da segunda fase são necessários 4 filmes");

            var vencedorA = filmes.ElementAt(0);
            var vencedorB = filmes.ElementAt(1);
            var vencedorAFase2 = _comparaFilmes.ObterFilmeVencedor(vencedorA, vencedorB);

            var vencedorC = filmes.ElementAt(2);
            var vencedorD = filmes.ElementAt(3);
            var vencedorBFase2 = _comparaFilmes.ObterFilmeVencedor(vencedorC, vencedorD);

            var listaVencedores = new List<Filme>();
            listaVencedores.Add(vencedorAFase2);
            listaVencedores.Add(vencedorBFase2);

            return listaVencedores;
        }
    }
}
