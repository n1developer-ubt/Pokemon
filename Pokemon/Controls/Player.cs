using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UBTStandardLibrary.Dialog;
using System.Net.Http.Headers;
using UBTStandardLibrary.Forms;

namespace Pokemon.Controls
{
    public partial class Player : UserControl
    {
        public PlayerGame GameData { get; set; }

        public delegate void GameDataUpdated(PlayerGame gameData);

        public event GameDataUpdated Updated;

        public Player()
        {
            InitializeComponent();
        }

        public void UpdateRound(string round, string imagePath)
        {
            var roundControls = pnlRounds.Controls.OfType<PictureBox>();
            var cc = roundControls.FirstOrDefault(f => round.Equals(f.AccessibleName));

            try
            {
                using (var tmp = new Bitmap(imagePath))
                {
                    cc.Image = new Bitmap(tmp);
                }

                GameData.Pokemons[round] = imagePath;

                Updated?.Invoke(GameData);
            }
            catch (Exception e)
            {
                
            }
        }

        public void LoadData(PlayerGame game)
        {
            GameData = game;

            lblPlayerName.Text = game.Name;

            var roundControls = pnlRounds.Controls.OfType<PictureBox>();

            foreach (var pokemon in game.Pokemons)
            {
                if(!File.Exists(pokemon.Value))
                    continue;
                var cc = roundControls.FirstOrDefault(f => pokemon.Key.Equals(f.AccessibleName));

                if (cc == null)
                    continue;

                using (var bmpTemp = new Bitmap(pokemon.Value))
                {
                   cc.Image = new Bitmap(bmpTemp);
                }
            }
        }

        private void lblPlayerName_Click(object sender, EventArgs e)
        {

        }

        private void lblPlayerName_DoubleClick(object sender, EventArgs e)
        {
            using (Input i = new Input("Enter New Name"))
            {
                i.ShowDialog();

                if (i.TextValue != null)
                {
                    (sender as Label).Text = i.TextValue;
                    GameData.Name = i.TextValue;
                    Updated?.Invoke(GameData);
                }
            }
        }
    }
}
