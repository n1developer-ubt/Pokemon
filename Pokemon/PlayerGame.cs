using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pokemon.Controls;

namespace Pokemon
{
    public class PlayerGame
    {
        public string Index { get; set; }
        public string Name { get; set; }
        public Dictionary<string, PokemonImageType> Pokemons { get; set; } = new Dictionary<string, PokemonImageType>();
    }

    public class PokemonImageType
    {
        public string Image { get; set; }
        public PokemonType PokemonType { get; set; }
    }
}
