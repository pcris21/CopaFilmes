using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CopaDeFilmes.Dominio;
using CopaDeFilmes.Dominio.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CopaDeFilmes.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CopaDeFilmesController : ControllerBase
    {
        private readonly IResultadoFinal _resultadoFinal;
        private readonly IServicoFilmes _servico;
        public CopaDeFilmesController(IResultadoFinal resultadoFinal, IServicoFilmes servico)
        {
            _resultadoFinal = resultadoFinal;
            _servico = servico;
        }

        [HttpGet]
        [Route("v1/filmes")]
        public Task<IEnumerable<Filme>> Get()
        {
            return _servico.ObterFilmes();
        }

        [HttpPost]
        [Route("v1/filmes")]
        public IEnumerable<Filme> Post(List<Filme> filmes)
        {
            return _resultadoFinal.DefinirFilmesVencedores(filmes);
        }
    }
}