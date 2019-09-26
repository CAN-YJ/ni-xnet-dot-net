using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//
using NI = NationalInstruments.UI.WindowsForms;
namespace NiXnetTestApp
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void switch1_StateChanged(object sender, NationalInstruments.UI.ActionEventArgs e)
        {
            if (!((NI.Switch)sender).Value)
            {
                MessageBox.Show("---");
            }
        }
    }
}
