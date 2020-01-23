using CopaDeFilmes.Dominio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CopaDeFilmes.Dominio
{
    public class ComparaFilmes : IComparaFilmes
    {
        public Filme ObterFilmeVencedor(Filme filmeA, Filme filmeB)
        {
            if (filmeA.Nota > filmeB.Nota)
                return filmeA;           

            else if (filmeB.Nota > filmeA.Nota)
                return filmeB;
            else
            {
                var lista = new List<Filme>();
                lista.Add(filmeA);
                lista.Add(filmeB);

                return lista.OrderBy(x => x.Titulo).FirstOrDefault();
            }

        }
    }
}
