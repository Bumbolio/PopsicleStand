using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PopsicleStand.Clients;
using PopsicleStand.Entities;
using RestEase;

namespace PopsicleStand.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PokemonController : ControllerBase
    {
        // GET: api/Pokemon
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Pokemon>>> GetPokemon()
        {
            IPokemonApi api = RestClient.For<IPokemonApi>("https://pokeapi.co/api/v2/");

            var pokemon = await api.GetPokemonAsync();

            return pokemon.Pokemon;
        }
    }
}
