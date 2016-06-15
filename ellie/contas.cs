using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ellie
{
    public partial class contas : Form
    {
        Boolean _sound;
        public contas(Boolean sound = true)
        {
            InitializeComponent();
            this._sound = sound;
        }

        public void numeroEscolhido(int num)
        {
            lblResultado.Text += num;
        }

        int n1, n2, sinal;//1-Soma 2-Subtração 3-Multiplicacao

        public void mudaNumeros(Boolean mantem)
        {
            Random rdn = new Random();
            n1 = rdn.Next(2, 9);
            do
            {
                n2 = rdn.Next(1, 9);
            } while (n2 >= n1);
            sinal = mantem ? sinal : rdn.Next(1, Convert.ToInt32(lbl_certas.Text)>10?4:3);
            switch (n1)
            {
                case 1:
                    picNum1.Image = Properties.Resources.btn1;
                    break;
                case 2:
                    picNum1.Image = Properties.Resources.btn2;
                    break;
                case 3:
                    picNum1.Image = Properties.Resources.btn3;
                    break;
                case 4:
                    picNum1.Image = Properties.Resources.btn4;
                    break;
                case 5:
                    picNum1.Image = Properties.Resources.btn5;
                    break;
                case 6:
                    picNum1.Image = Properties.Resources.btn6;
                    break;
                case 7:
                    picNum1.Image = Properties.Resources.btn7;
                    break;
                case 8:
                    picNum1.Image = Properties.Resources.btn8;
                    break;
                case 9:
                    picNum1.Image = Properties.Resources.btn9;
                    break;
            }
            switch (n2)
            {
                case 1:
                    picNum2.Image = Properties.Resources.btn1;
                    break;
                case 2:
                    picNum2.Image = Properties.Resources.btn2;
                    break;
                case 3:
                    picNum2.Image = Properties.Resources.btn3;
                    break;
                case 4:
                    picNum2.Image = Properties.Resources.btn4;
                    break;
                case 5:
                    picNum2.Image = Properties.Resources.btn5;
                    break;
                case 6:
                    picNum2.Image = Properties.Resources.btn6;
                    break;
                case 7:
                    picNum2.Image = Properties.Resources.btn7;
                    break;
                case 8:
                    picNum2.Image = Properties.Resources.btn8;
                    break;
                case 9:
                    picNum2.Image = Properties.Resources.btn9;
                    break;
            }

            switch (sinal)
            {
                case 1:
                    picSinal.Image = Properties.Resources.mais;
                    break;
                case 2:
                    picSinal.Image = Properties.Resources.menos;
                    break;
                case 3:
                    picSinal.Image = Properties.Resources.vezes;
                    break;
            }

        }

        public void certo()
        {
            if (_sound)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.certo);
                player.Play();
                Thread.Sleep(2000);
            }
            lbl_certas.Tag = Convert.ToInt32(lbl_certas.Tag) + 1;
            lbl_certas.Text = lbl_certas.Tag.ToString();

            btnApaga.PerformClick();
            mudaNumeros(false);

        }

        public void errado()
        {
            if (_sound)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.errado);
                player.Play();
                Thread.Sleep(2000);
            }
            lbl_errado.Tag = Convert.ToInt32(lbl_errado.Tag) + 1;
            lbl_errado.Text = lbl_errado.Tag.ToString();

            btnApaga.PerformClick();
            mudaNumeros(true);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            numeroEscolhido(1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            numeroEscolhido(3);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            numeroEscolhido(2);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            numeroEscolhido(4);

        }

        private void button7_Click(object sender, EventArgs e)
        {
            numeroEscolhido(7);

        }

        private void button8_Click(object sender, EventArgs e)
        {
            numeroEscolhido(8);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            numeroEscolhido(5);

        }

        private void button6_Click(object sender, EventArgs e)
        {
            numeroEscolhido(6);

        }

        private void button9_Click(object sender, EventArgs e)
        {
            numeroEscolhido(9);

        }

        private void btnEnvia_Click(object sender, EventArgs e)
        {
            switch (sinal)
            {
                case 1:
                    if (n1 + n2 == Convert.ToInt32(lblResultado.Text))
                        certo();
                    else
                        errado();
                    break;

                case 2:
                    if (n1 - n2 == Convert.ToInt32(lblResultado.Text))
                        certo();
                    else
                        errado();
                    break;
                case 3:
                    if (n1 * n2 == Convert.ToInt32(lblResultado.Text))
                        certo();
                    else
                        errado();
                    break;
            }

            
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Queres mesmo sair?", "Sair?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                this.Close();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            numeroEscolhido(0);
        }

        private void contas_Load(object sender, EventArgs e)
        {
            System.Drawing.Text.PrivateFontCollection privateFonts = new PrivateFontCollection();
            privateFonts.AddFontFile("Crayon.ttf");
            System.Drawing.Font font = new Font(privateFonts.Families[0], 50);
            lblResultado.Font = font;
            label1.Font = font;
            mudaNumeros(false);
            btnApaga.PerformClick();
        }

        private void btnApaga_Click(object sender, EventArgs e)
        {
            lblResultado.Text = " ";
        }
    }
}
