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
using Syncfusion.WinForms.Controls;

namespace Pokemon
{
    public partial class Settings : SfForm
    {
        public static string BackgroundImagePath = Path.Combine(Application.StartupPath, "Background");
        public Settings()
        {
            InitializeComponent();

            if (File.Exists(Properties.Settings.Default.BackgroundImagePath))
            {
                try
                {
                    try
                    {
                        using (var b = new Bitmap(Properties.Settings.Default.BackgroundImagePath))
                        {
                            pb.Image = new Bitmap(b);
                        }
                    }
                    catch (Exception exception)
                    {

                    }
                }
                catch (Exception e)
                {
                    
                }
            }

        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Multiselect = false;
                ofd.Filter = "Image File(*.png, *.jpg, *.jpeg)|*.png;*.jpg;*.jpeg";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    if (!Directory.Exists(BackgroundImagePath))
                        Directory.CreateDirectory(BackgroundImagePath);

                    var newFileName = Path.Combine(BackgroundImagePath, "background" + Path.GetExtension(ofd.FileName));

                    Properties.Settings.Default.BackgroundImagePath = newFileName;
                    Properties.Settings.Default.Save();

                    File.Copy(ofd.FileName, newFileName, true);

                    try
                    {
                        using (var b = new Bitmap(newFileName))
                        {
                            pb.Image = new Bitmap(b);
                        }
                    }
                    catch (Exception exception)
                    {
                        
                    }
                }
            }
        }
    }
}
