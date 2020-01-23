using System.Collections.Generic;

namespace CopaDeFilmes.Dominio.Interfaces
{
    public interface IComparaFilmes
    {
        Filme ObterFilmeVencedor(Filme filmeA, Filme filmeB);
    }
}
