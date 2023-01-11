using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PokeDex.Service.Implementation.Model;
using PokeDex.Service.Implementation.Interface;

namespace PokeDex.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PokemonsController : Controller
    {

        private readonly IPokemonsService _pokemonsService;

        public PokemonsController(IPokemonsService pokemonsService)
        {
            _pokemonsService = pokemonsService;
        }

        [HttpGet("GetPokemons")]
        public List<Pokemons> GetPokemons(){
            return _pokemonsService.GetPokemons();
        }
    }
}
