using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Pokemon.Controls;
using Pokemon.Properties;
using Syncfusion.WinForms.Controls;

namespace Pokemon
{
    public partial class MainWindow : SfForm
    {
        private const int Players = 8;
        private int Turn = 1;

        public MainWindow()
        {
            InitializeComponent();

            CheckForIllegalCrossThreadCalls = false;

            KeyPreview = true;

            KeyDown += OnKeyDown;

            playerContainer.Updated+=PlayerContainerOnUpdated;

            LoadDD();

            //Settings.Default.GameStatus = "";
            //Settings.Default.GameData = "";
            //Settings.Default.Save();

            if (!Properties.Settings.Default.GameData.Equals(""))
            {
                playerContainer.LoadPreviousGame(
                    JsonConvert.DeserializeObject<List<PlayerGame>>(Properties.Settings.Default.GameData));
            }

            if (!Properties.Settings.Default.GameStatus.Equals(""))
            {
                playerContainer.CurrentGameStatus =
                    JsonConvert.DeserializeObject<PlayerContainer.GameStatus>(Properties.Settings.Default.GameStatus);
            }

            UpdateStatus();

            Task.Run(() =>
            {
                pnlBackground.BackgroundImageLayout = ImageLayout.Stretch;
                try
                {
                    using (var x = new Bitmap(Properties.Settings.Default.BackgroundImagePath))
                    {
                        pnlBackground.BackgroundImage = new Bitmap(x);
                    }
                }
                catch (Exception e)
                {
                    
                }
            });
        }

        private void OnKeyDown(object sender, KeyEventArgs e)
        {
            if(e.Control &&e.Shift && e.KeyCode == Keys.S)
            {
                using (var p = new Pokemons())
                {
                    p.ShowDialog();
                }
            }

            else if (e.Control && e.Shift && e.KeyCode == Keys.A)
            {
                using (Settings s = new Settings())
                {
                    s.ShowDialog();
                }
            }
        }

        private void UpdateStatus()
        {
            var s = playerContainer.GetStatus();
            lblCurrentPlayerName.Text = s.Turn;
            lblCurrentRound.Text = s.Round;
        }

        private void LoadDD()
        {
            if (!Directory.Exists(Pokemons.PokemonImagePath))
                return;

            var i = Directory.GetFiles(Pokemons.PokemonImagePath, "*.*", SearchOption.AllDirectories)
                .Where(s => s.EndsWith(".jpg") || s.EndsWith(".jpeg") || s.EndsWith(".png"));

            cbPokemon.DataSource = i.Select(s => new FilePart() {Path = s, Name = Path.GetFileNameWithoutExtension(s)});
            cbPokemon.DisplayMember = "Name";
        }

        public class FilePart
        {
            public string Path { get; set; }
            public string Name { get; set; }
        }

        private void PlayerContainerOnUpdated(List<PlayerGame> gamedata)
        {
            Properties.Settings.Default.GameData = JsonConvert.SerializeObject(gamedata);
            Properties.Settings.Default.Save();
            UpdateStatus();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (cbPokemon.SelectedItem == null) return ;

            var item = (FilePart) cbPokemon.SelectedItem;

            if (playerContainer.PokemonSelected(item.Path))
            {
                Properties.Settings.Default.GameStatus = JsonConvert.SerializeObject(playerContainer.CurrentGameStatus);
                Properties.Settings.Default.GameData = JsonConvert.SerializeObject(playerContainer.GameData);
                Properties.Settings.Default.Save();
                UpdateStatus();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.GameData = "";
            Properties.Settings.Default.GameStatus = "";
            Properties.Settings.Default.Save();
            playerContainer.InitData();
            UpdateStatus();
        }

        private void btnReloadPokemons_Click(object sender, EventArgs e)
        {
            LoadDD();
        }
    }
}
