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

        public string PokemonTypePath = Path.Combine(Application.StartupPath, "PokemonType");

        public Player()
        {
            InitializeComponent();
            banT.Parent = pbBan;
            t1.Parent = pb1;
            t2.Parent = pb2;
            t3.Parent = pb3;
            t4.Parent = pb4;
            t5.Parent = pb5;
            t6.Parent = pb6;
        }

        public void UpdateRound(string round, PokemonImageType imageType)
        {
            List<PictureBox> roundControls = pnlRounds.Controls.OfType<Panel>().SelectMany(x => x.Controls.OfType<PictureBox>()).ToList();

            var l = roundControls.SelectMany(x => x.Controls.OfType<PictureBox>()).ToList();

            roundControls.AddRange(l);

            var cc = roundControls.FirstOrDefault(f => round.Equals(f.AccessibleName));
            var cc1 = roundControls.FirstOrDefault(f => f.AccessibleName.Equals(round+"T",StringComparison.CurrentCultureIgnoreCase));
            
            try
            {
                if (imageType.Image== null || imageType.Image.Equals(""))
                {
                    cc.Image = null;
                    cc1.Image = null;
                    GameData.Pokemons.Remove(round);
                }
                else
                {
                    using (var tmp = new Bitmap(imageType.Image))
                    {
                        cc.Image = new Bitmap(tmp);
                    }

                    cc1.Image = GetBitmap(imageType.PokemonType);
                    
                    if(cc1.Image== null)
                        cc1.Hide();
                    else cc1.Show();

                    GameData.Pokemons[round] = imageType;
                }

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

            List<PictureBox> roundControls = pnlRounds.Controls.OfType<Panel>().SelectMany(x => x.Controls.OfType<PictureBox>()).ToList();

            var l = roundControls.SelectMany(x => x.Controls.OfType<PictureBox>()).ToList();

            roundControls.AddRange(l);

            roundControls.Where(x=>!game.Pokemons.ContainsKey(x.AccessibleName)||!game.Pokemons.ContainsKey(x.AccessibleName.Replace("T",""))).ForEach(x =>
                {
                    x.Image = null;
                });

            game.Pokemons.ForEach(p =>
            {
                var r = roundControls.FirstOrDefault(f => f.AccessibleName.Equals(p.Key));
                var r1 = roundControls.FirstOrDefault(f => f.AccessibleName.Equals(p.Key+"T", StringComparison.CurrentCultureIgnoreCase));

                if (p.Value.Image == null || !File.Exists(p.Value.Image))
                {
                    r.Image = null;
                    r1.Image = null;
                    return;
                }

                using (var bmpTemp = new Bitmap(p.Value.Image))
                {
                    r.Image = new Bitmap(bmpTemp);
                }

                r1.Image = GetBitmap(p.Value.PokemonType);
            });
        }

        private Bitmap GetBitmap(PokemonType p)
        {
            var xp = Path.Combine(PokemonTypePath, p + ".png");
            try
            {
                using (var bmpTemp = new Bitmap(xp))
                {
                    //bmpTemp.MakeTransparent(Color.Black);
                    var x = new Bitmap(bmpTemp);
                    //x.MakeTransparent();
                    return x;
                }
            }
            catch (Exception e)
            {
                //MessageBox.Show(e.Message);
            }
            

            return null;
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

    public enum PokemonType
    {
        BestBuddy,
        MegaEvolution,
        Purified,
        Shadow,
        None
    }
}
