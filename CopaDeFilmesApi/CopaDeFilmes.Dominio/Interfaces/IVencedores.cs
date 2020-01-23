using System.Collections.Generic;

namespace CopaDeFilmes.Dominio.Interfaces
{
    public interface IVencedores
    {
        List<Filme> DefinirFilmesVencedores(List<Filme> filmes);
    }
}
