using CopaDeFilmes.Dominio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CopaDeFilmes.Dominio
{
    public class Classificacao : IClassificacao
    {
        
        public List<Filme> ObterClassificacaoFinal(List<Filme> filmes)
        {
            if (filmes.Count != 2)
                throw new Exception("Para a classificação final são necessários 2 filmes");

            var filmeA = filmes.ElementAt(0);
            var filmeB = filmes.ElementAt(1);

            if (filmeA.Nota > filmeB.Nota || filmeB.Nota > filmeA.Nota)
                return filmes.OrderBy(x => x.Nota).ToList();
            else            
                return filmes.OrderBy(x => x.Titulo).ToList();
            
        }
    }
}
