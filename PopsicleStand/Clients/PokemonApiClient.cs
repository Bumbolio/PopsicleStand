using Newtonsoft.Json;
using RestEase;

namespace PopsicleStand.Clients
{
    // We receive a JSON response, so define a class to deserialize the json into

    public class PokemonResponse
    {
        [JsonProperty("count")]
        public int Count { get; set; }
        [JsonProperty("next")]
        public string Next { get; set; }
        [JsonProperty("previous")]
        public string Previous { get; set; }
        [JsonProperty("results")]
        public List<Pokemon> Pokemon { get; set; }
    }

    public class Pokemon
    {
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("url")]
        public string Url { get; set; }
    }

    // Define an interface representing the API
    // GitHub requires a User-Agent header, so specify one
    [Header("User-Agent", "RestEase")]
    public interface IPokemonApi
    {
        // The [Get] attribute marks this method as a GET request
        // The "users" is a relative path the a base URL, which we'll provide later
        // "{userId}" is a placeholder in the URL: the value from the "userId" method parameter is used
        [Get("pokemon")]
        Task<PokemonResponse> GetPokemonAsync();
    }
}
