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
using Pokemon.Controls;
using Syncfusion.WinForms.Controls;

namespace Pokemon
{
    public partial class Pokemons : SfForm
    {
        public readonly Dictionary<string, string> imagesPath = new Dictionary<string, string>();
        public static string PokemonImagePath = Path.Combine(Application.StartupPath, "Pokemon");
        public Pokemons()
        {
            InitializeComponent();
            PokemonImage.P = this;
            LoadAll();
        }

        private int id = 0;

        private void btnImportImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image File(*.jpeg,*.png,*.jpg)|*.jpeg;*.png;*.jpg";
                ofd.Multiselect = true;

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    foreach (string file in ofd.FileNames)
                    {
                        var newPath = AddFileToFolder(file);

                        if (newPath == null)
                            continue;

                        var pb = GetImage(newPath);

                        if(pb == null)
                            continue;

                        pnlPokemons.Controls.Add(pb);
                    }
                }
            }
        }

        private void LoadAll()
        {
            if (!Directory.Exists(PokemonImagePath))
            {
                Directory.CreateDirectory(PokemonImagePath);
                return;
            }

            pnlPokemons.Controls.Clear();

            var i = Directory.GetFiles(PokemonImagePath, "*.*", SearchOption.AllDirectories)
                .Where(s => s.EndsWith(".jpg") || s.EndsWith(".jpeg") || s.EndsWith(".png"));
            foreach (string f in i)
            {
                var pb = GetImage(f);
                pnlPokemons.Controls.Add(pb);
            }
        }

        public void RemoveControl(Control c)
        {
            pnlPokemons.Controls.Remove(c);
        }

        private PokemonImage GetImage(string fileName)
        {
            try
            {
                var pb = new PokemonImage(fileName);
                pb.Size = new Size(120,150);
                
                return pb;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        private static string AddFileToFolder(string file)
        {
            if (!Directory.Exists(PokemonImagePath))
                Directory.CreateDirectory(PokemonImagePath);
            var newPath = Path.Combine(PokemonImagePath, Path.GetFileName(file));
            try
            {
                File.Copy(file, Path.Combine(PokemonImagePath,Path.GetFileName(file)), true);
                return newPath;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            var i = Directory.GetFiles(PokemonImagePath, "*.*", SearchOption.AllDirectories)
                .Where(s => s.EndsWith(".jpg") || s.EndsWith(".jpeg") || s.EndsWith(".png"));

            foreach (var f in i)
            {
                try
                {
                    File.Delete(f);
                }
                catch (Exception exception)
                {
                    
                }
            }
            pnlPokemons.Controls.Clear();
        }

        private void btnReloadAll_Click(object sender, EventArgs e)
        {
            LoadAll();
        }

        private void Pokemons_Load(object sender, EventArgs e)
        {

        }
    }
}
