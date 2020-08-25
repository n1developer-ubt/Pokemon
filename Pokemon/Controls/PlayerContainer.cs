using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pokemon.Controls
{
    public partial class PlayerContainer : UserControl
    {
        public List<PlayerGame> GameData = new List<PlayerGame>();

        public delegate void GameDataUpdated(List<PlayerGame> gameData);

        public event GameDataUpdated Updated;

        public PlayerContainer()
        {
            InitializeComponent();
            var ctrls = pnlPlayers.Controls.OfType<Player>();
            foreach (var player in ctrls)
            {
                var d = new PlayerGame() {Index = player.AccessibleName, Name = "Player " + player.AccessibleName};
                GameData.Add(d);
                player.Updated+=PlayerOnUpdated;
                GameData.Add(d);
            }
        }

        private void PlayerOnUpdated(PlayerGame gamedata)
        {
            var c = GameData.FirstOrDefault(x => x.Index.Equals(gamedata.Index));
            c.Name = gamedata.Name;
            c.Pokemons= gamedata.Pokemons;

            Updated?.Invoke(GameData);
        }

        public void LoadPreviousGame(List<PlayerGame> game)
        {
            GameData = game;
            var ctrls = pnlPlayers.Controls.OfType<Player>();

            foreach (var ctrl in ctrls)
            {
                ctrl.LoadData(game.First(x=>x.Index.Equals(ctrl.AccessibleName)));
            }
        }
    }
}
