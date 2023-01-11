using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PokeDex.Service.Implementation;
using PokeDex.Service.Implementation.Model;

namespace PokeDex.Service.Implementation.Interface
{
    public interface IPokemonsService
    {
        List<Pokemons> GetPokemons();
    }
}
