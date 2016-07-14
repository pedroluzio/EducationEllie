using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Text;

namespace Ellie
{
    public partial class MessageBoard : Form
    {
        public MessageBoard(String Mensagem)
        {
            InitializeComponent();
            this.lblTitulo.Text = Mensagem;
        }
        //MessageBoard MsgBoard; 
        //DialogResult result = DialogResult.No;
        //public void Show(String Mensagem)
        //{
        //    //MsgBoard = new MessageBoard();
        //    this.lblTitulo.Text = Mensagem;
        //    //return result;
        //}

        private void btnSim_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Yes;
            this.Close();
        }

        private void lblSim_Click(object sender, EventArgs e)
        {

            this.DialogResult = DialogResult.Yes;
            this.Close();
        }

        private void btnNao_Click(object sender, EventArgs e)
        {

            this.DialogResult = DialogResult.No;
            this.Close();
        }

        private void lblNao_Click(object sender, EventArgs e)
        {

            this.DialogResult = DialogResult.No;
            this.Close();
        }

        private void MessageBoard_Load(object sender, EventArgs e)
        {
            try
            {
                System.Drawing.Text.PrivateFontCollection privateFonts = new PrivateFontCollection();
                privateFonts.AddFontFile("Crayon.ttf");
                System.Drawing.Font font = new Font(privateFonts.Families[0], 25);
                lblNao.Font = font;
                lblSim.Font = font;
                lblTitulo.Font = font;
            }
            catch (Exception ex)
	{
                MessageBox.Show(ex.Message);
            }
            }
        }
    }
