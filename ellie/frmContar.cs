using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ellie
{
    public partial class frmContar : Form
    {
        int abelhas = 0;
        Boolean _sound;
        PictureBox[] PicArray;
        public frmContar(Boolean sound = true)
        {
            InitializeComponent();
            _sound = sound;
            PicArray = new PictureBox[] { picImg1, picImg2, picImg3, picImg4, picImg5, picImg6, picImg7, picImg8, picImg9 };
        }

        Bitmap image = new Bitmap(50, 50);
        int obj;
        bool fullscreen = false;


        private void Form1_Load(object sender, EventArgs e)
        {
            
            Random rnd = new Random(); obj = rnd.Next(1, 4);
            //1-Calculadora  2-Livro  3-Mochila
            string txt = "";
            switch (obj)
            {
                case 1:
                    txt = "Quantas calculadoras ";
                    break;
                case 2:
                    txt = "Quantos livros ";
                    break;
                case 3:
                    txt = "Quantas Mochilas ";
                    break;
            }
            txt += "estão no quadro?";
            label1.Text = txt;
            foreach (PictureBox pics in PicArray)
            {
                switch (obj)
                {
                    case 1:
                        pics.BackgroundImage = Properties.Resources.calc;
                        break;
                    case 2:
                        pics.BackgroundImage = Properties.Resources.livro;
                        break;
                    case 3:
                        pics.BackgroundImage = Properties.Resources.mochila;
                        break;
                }
            }
            desenhaAbelhas();

        }

        public int gera(int x)
        {
            Random rdn = new Random();
            int temp;
            do
            {
                temp = rdn.Next(1, x);
            } while (temp == abelhas);
            abelhas = temp;
            return abelhas;
        }

        public void desenhaAbelhas()
        {
            
            int j = gera(10);

            for (int i = 0; i < PicArray.Length; i++)
            {
                PicArray[i].Visible = i < j ? true : false;
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

            desenhaAbelhas();
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
            desenhaAbelhas();
        }

        public void numeroEscolhido(int num)
        {
            if (num == abelhas)
                certo();
            else
                errado();
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

        private void contar_MaximumSizeChanged(object sender, EventArgs e)
        {
        }

        private void button10_Click(object sender, EventArgs e)
        {
            fullscreen = !fullscreen;
            if (fullscreen)
            {
                this.WindowState = FormWindowState.Maximized;
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                this.Bounds = Screen.PrimaryScreen.Bounds;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                this.Size = new Size(976, 590);
                this.CenterToScreen();
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Queres mesmo sair?", "Sair?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                this.Close();
        }


    }

}
