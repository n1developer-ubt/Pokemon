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

namespace Pokemon.Controls
{
    public partial class PokemonImage : UserControl
    {
        private string Path { get; set; }
        public int Id { get; set; }
        public static string PokemonImagePath = System.IO.Path.Combine(Application.StartupPath, "Pokemon");

        public static Pokemons P { get; set; }
        public PokemonImage(string path)
        {
            InitializeComponent();


            pbImage.SizeMode = PictureBoxSizeMode.StretchImage;

            Path = path;
            Image img;

            using (var bmpTemp = new Bitmap(path))
            {
                img = new Bitmap(bmpTemp);
                pbImage.Image = img;
            }
            //pbImage.Image = Image.FromFile(path);
            
            lblName.Text = System.IO.Path.GetFileNameWithoutExtension(path);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void renameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var i = new Input("Rename");

            i.ShowDialog();

            if (i.TextValue != null)
            {
                if(!Rename(i.TextValue))
                {
                    MessageBox.Show("Unable to rename!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool Rename(string newName)
        {
            try
            {
                if (!Directory.Exists(PokemonImagePath))
                    Directory.CreateDirectory(PokemonImagePath);

                var newPath = System.IO.Path.Combine(PokemonImagePath, newName + System.IO.Path.GetExtension(Path));

                File.Move(Path,newPath);
                lblName.Text = newName;
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(File.Exists(Path))
                File.Delete(Path);

            P.RemoveControl(this);
        }
    }
}
