using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pokemon
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            TransparencyKey = Color.Black;
            this.ShowInTaskbar = false;

            Thread th = new Thread(() =>
            {
                Thread.Sleep(2000);
                this.Close();
                Application.Run(new MainWindow());
            });
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

    }
}
