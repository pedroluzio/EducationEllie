using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ellie
{
    public partial class mascote : Form
    {
        public mascote(string text)
        {
            _text = text;
            InitializeComponent();
        }
        string _text;
        Boolean aberto;
        int qt = 0;
        private void mascote_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.Gray;
            this.TransparencyKey = Color.Gray;
            if (_text == "início")            
                label1.Text = "Bem Vindo!";
            if (_text == "ajuda nome")
                label1.Text = "Para te poder ajudar";
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (aberto)
                pictureBox1.Image = Properties.Resources.mascote;
            else
                pictureBox1.Image = Properties.Resources.mascote1;

            aberto = !aberto;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if(_text=="início")
            {
                nome nome = new nome();
                nome.ShowDialog();
                this.Close();
            }
            if(_text=="ajuda nome")
            {
                if(qt==2)
                {
                    this.Close();
                }
                if(qt==1)
                {
                    label1.Text = "Usa as letras do quadro.";
                    qt++;
                }
                if (qt == 0)
                {
                    label1.Text = "Quero saber o teu nome.";
                    qt++;
                }
            }

        }
    }
}
