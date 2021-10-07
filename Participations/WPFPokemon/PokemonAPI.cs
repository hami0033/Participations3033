using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace WPFPokemon
{
    public class PokemonAPI
    {
        [JsonProperty("results")]
        public List<AllResults> Results { get; set; }
    }

    public class AllResults
    {
        public string name { get; set; }
        public string url { get; set; }


        public override string ToString()
        {
            string output = name;
            return output;
        }
    }
}
