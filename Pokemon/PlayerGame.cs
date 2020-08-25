using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon
{
    public class PlayerGame
    {
        public string Index { get; set; }
        public string Name { get; set; }
        public Dictionary<string, string> Pokemons { get; set; } = new Dictionary<string, string>();
    }
}
