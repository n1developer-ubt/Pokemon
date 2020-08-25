using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pokemon
{
    public partial class Input : Form
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
