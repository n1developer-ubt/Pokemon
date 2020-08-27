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
using Syncfusion.DataSource.Extensions;
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

            roundControls.ForEach(c =>
            {
                string val = null;

                try
                {
                    val = game.Pokemons[c.AccessibleName];
                }
                catch (Exception e)
                {
                    
                }

                if (val == null)
                {
                    c.Image = null;
                    return;
                }

                if (!File.Exists(val))
                    return;

                using (var bmpTemp = new Bitmap(val))
                {
                    c.Image = new Bitmap(bmpTemp);
                }
            });
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
