using CopaDeFilmes.Dominio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CopaDeFilmes.Dominio
{
    public class ResultadoFinal : IResultadoFinal
    {
        private readonly IPrimeiraFase _primeiraFase;
        private readonly ISegundaFase _segundaFase;
        private readonly IClassificacao _classificacao;
        public ResultadoFinal(IPrimeiraFase primeiraFase, ISegundaFase segundaFase, IClassificacao classificacao)
        {
            _primeiraFase = primeiraFase;
            _segundaFase = segundaFase;
            _classificacao = classificacao;
        }
        public List<Filme> FilmesVencedores(List<Filme> filmes)
        {
            var listaOrdenada = filmes.OrderBy(x => x.Titulo).ToList();

            var resultadoPrimeiraFase = _primeiraFase.FilmesVencedores(listaOrdenada);

            var resultadoSegundaFase = _segundaFase.FilmesVencedores(resultadoPrimeiraFase);

            var resultadoFinal = _classificacao.ObterClassificacaoFinal(resultadoSegundaFase);

            return resultadoFinal;
        }

       
    }
}
