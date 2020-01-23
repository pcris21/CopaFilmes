using System.Collections.Generic;

namespace CopaDeFilmes.Dominio.Interfaces
{
    public interface IClassificacao
    {
        List<Filme> ObterClassificacaoFinal(List<Filme> filmes);
    }
}
