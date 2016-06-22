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

namespace Ellie
{
    public partial class frmOpcoes : Form
    {
        public frmOpcoes()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("config.ini");
            string text = sr.ReadToEnd();
            String temp;
            temp = text.Substring(text.IndexOf("[contar]") + 10);
            temp = temp.Substring(temp.IndexOf("sair") + 5, temp.IndexOf("\r\n")-(temp.IndexOf("sair") + 5));
            nud_contarSair.Value = Convert.ToInt32(temp);

            temp = text.Substring(text.IndexOf("[contar]") + 10);
            temp = temp.Substring(temp.IndexOf("mudar") + 6, temp.IndexOf("\r\n", temp.IndexOf("mudar")) - (temp.IndexOf("mudar") + 6));
            nud_contarMudar.Value = Convert.ToInt32(temp);
            sr.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("[contar]");
            sb.AppendLine("sair=" + nud_contarSair.Value);
            sb.AppendLine("mudar=" + nud_contarMudar.Value);
            sb.AppendLine("********");

            TextWriter tw = new StreamWriter("config.ini");

            tw.Write(sb);
            
            tw.Close();
            this.Close();
        }

        private void opcoes_Load(object sender, EventArgs e)
        {

        }
    }
}
