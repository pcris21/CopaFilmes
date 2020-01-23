using System.Collections.Generic;
using System.Threading.Tasks;

namespace CopaDeFilmes.Dominio.Interfaces
{
    public interface IServicoFilmes
    {
        Task<IEnumerable<Filme>> ObterFilmes();
    }
}
