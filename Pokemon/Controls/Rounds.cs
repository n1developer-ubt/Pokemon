using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UBTStandardLibrary.Dialog;
using System.Net.Http.Headers;
using UBTStandardLibrary.Forms;

namespace Pokemon.Controls
{
    public partial class Rounds : UserControl
    {
        public Rounds()
        {
            InitializeComponent();
        }

        private void label1_DoubleClick(object sender, EventArgs e)
        {
            if (!(sender is Label l))
                return;
            //InputDialog c = new InputDialog("Enter Name",new List<Input> { new Input{Hint="Name", IsMandatory = false, Name = "name", Value = l.Text}},null, ToolBoxProp.Exit);
            //if (c.ShowIt() == ResultType.OK)
            //{
            //    var result = c.Output.First(x => x.Name.Equals("name")).Value;

            //    l.Text = result;
            //}
        }

    }
}
