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

            try
            {
                temp = text.Substring(text.IndexOf("[contar]") + 10);
                temp = temp.Substring(temp.IndexOf("mudar") + 6, temp.IndexOf("\r\n", temp.IndexOf("mudar")) - (temp.IndexOf("mudar") + 6));
                nudContarMudar.Value = Convert.ToInt32(temp);

                temp = text.Substring(text.IndexOf("[contas]") + 10);
                temp = temp.Substring(temp.IndexOf("multiplicacao") + 14, temp.IndexOf("\r\n", temp.IndexOf("multiplicacao")) - (temp.IndexOf("multiplicacao") + 14));
                nudContasMultiplicacao.Value = Convert.ToInt32(temp);

                temp = text.Substring(text.IndexOf("[contas]") + 10);
                temp = temp.Substring(temp.IndexOf("tempo") + 6, temp.IndexOf("\r\n", temp.IndexOf("tempo")) - (temp.IndexOf("tempo") + 6));
                nudTempoAjuda.Value = Convert.ToInt32(temp);

                temp = text.Substring(text.IndexOf("[contas]") + 9);
                temp = temp.Substring(temp.IndexOf("ajuda") + 6, temp.IndexOf("\r\n", temp.IndexOf("ajuda")) - (temp.IndexOf("ajuda") + 6));
                cheAjuda.Checked = Convert.ToBoolean(temp);

                temp = text.Substring(text.IndexOf("[geral]") + 9);
                temp = temp.Substring(temp.IndexOf("som") + 4, temp.IndexOf("\r\n", temp.IndexOf("som")) - (temp.IndexOf("som") + 4));
                cheSom.Checked = Convert.ToBoolean(temp);
                
            }
            catch { }
            sr.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("[geral]");
            sb.AppendLine("som=" + cheSom.Checked.ToString());
            sb.AppendLine("[contar]");
            sb.AppendLine("mudar=" + nudContarMudar.Value);
            sb.AppendLine("[contas]");
            sb.AppendLine("multiplicacao=" + nudContasMultiplicacao.Value);
            sb.AppendLine("tempo=" + nudTempoAjuda.Value);
            sb.AppendLine("ajuda=" + cheAjuda.Checked.ToString());
            sb.AppendLine("********");

            TextWriter tw = new StreamWriter("config.ini");

            tw.Write(sb);
            
            tw.Close();

            // Salvar os dados no próprio 

           // Properties.Settings.Default["juntar_cores_max_jogadas"] = nudQuantidadeJogadasJuntarCores.Value.ToString();
           // Properties.Settings.Default.Save(); 

            this.Close();
        }

        private void opcoes_Load(object sender, EventArgs e)
        {

        }
        
    }
}
