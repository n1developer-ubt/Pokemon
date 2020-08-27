using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Syncfusion.WinForms.Controls;

namespace Pokemon
{
    public partial class Input : SfForm
    {
        public Input(string name)
        {
            InitializeComponent();
            Text = name;
        }

        public string TextValue { get; private set; } = null;

        private void button1_Click(object sender, EventArgs e)
        {
            TextValue = txtValue.Text;
            Close();
        }
    }
}
