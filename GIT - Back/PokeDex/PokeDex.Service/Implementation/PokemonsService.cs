using Newtonsoft.Json;
using PokeDex.Service.Implementation.Interface;
using PokeDex.Service.Implementation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace PokeDex.Service.Implementation
{
    public class PokemonsService: IPokemonsService
    {
        public PokemonsService()
        {

        }

        public List<Pokemons> GetPokemons()
        {
            HttpClient httpClient = new HttpClient();

            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, $"https://pokeapi.co/api/v2/pokemon/");

            HttpResponseMessage response = httpClient.SendAsync(request).Result;

            string result = response.Content.ReadAsStringAsync().Result;

            PokemonsResponse Pokedex = JsonConvert.DeserializeObject<PokemonsResponse>(result);

            List<Pokemons> retorno = Pokedex.results;

            return retorno;
        }
    }

    
}
