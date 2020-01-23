using Newtonsoft.Json;
using System.Collections;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace CopaDeFilmes.Dominio
{
    public class ServicoFilmes
    {
        public async Task<IEnumerable<Filme>> ObterFilmes()
        {
            IEnumerable<Filme> retorno;
            using (var client = new  HttpClient())
            {
                using (var api  = await client.GetAsync("http://copafilmes.azurewebsites.net/api/filmes"))
                {
                    var apiResult = await api.Content.ReadAsStringAsync();
                    retorno = JsonConvert.DeserializeObject<IEnumerable<Filme>>(apiResult);
                }

                return retorno;

            }
        }

    }
}
