using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EllieLogicShared
{
    public partial class EllieAjuda : UserControl
    {
        public EllieAjuda()
        {
            InitializeComponent();
        }

        private void picEllie_Click(object sender, EventArgs e)
        {
            abreAjuda(this.Parent);
        }        

        private void picHelp_Click(object sender, EventArgs e)
        {
            abreAjuda(this.Parent);
        }

        private void abreAjuda(Control parent)
        {
            MessageBox.Show(parent.Name);
        }
    }
}
