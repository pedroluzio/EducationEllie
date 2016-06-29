using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using EllieLogicShared;

namespace Ellie
{
    public partial class frmJuntarCores : Form
    {
        EllieLogicShared.GameControl GameControl;
        Boolean _sound;
        public frmJuntarCores(Boolean sound)
        {
            InitializeComponent();
            pics = new PictureBox[] { picCor1, picCor2, picCor3, picCor4, picCor5, picCor6, picCor7, picCor8 };
            this._sound = sound;
            GameControl = new GameControl();
        }
        private PictureBox[] pics;
        public ICollection<PictureBox> Pics
        {
            get { return Pics; }
        }
        
        Bitmap[] cores;
        int cor;//0-Amarelo 1-Branco 2-Azul 3-Verde 4-Vermelho 5-Laranja 6-Rosa
        int jogada;
        Image corTentativa;

        private void geraCor(int corAtual)
        {
            Random rdn = new Random();
            do
                cor = rdn.Next(0, 6);
            while (cor == corAtual);
            foreach (PictureBox pic in pics)
                pic.Image = null;

            int picParaNovaCor; ;
            for (int i = 0; i < cores.Length; i++)
            {
                do
                    picParaNovaCor = rdn.Next(0, pics.Length - 1);
                while (pics[picParaNovaCor].Image != null);
                pics[picParaNovaCor].Image = cores[i];
            }
            foreach (PictureBox pic in pics)
                pic.Image = pic.Image == null ? cores[cor] : pic.Image;
            foreach (PictureBox picAll in pics)
                picAll.BorderStyle = BorderStyle.None;

            jogada = 1;
        }

        private void certo()
        {
            if (_sound)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.certo);
                player.Play();
                Thread.Sleep(2000);
            }
            lblCertas.Tag = Convert.ToInt32(lblCertas.Tag) + 1;
            lblCertas.Text = lblCertas.Tag.ToString();
            jogada = 1;
            geraCor(cor);
        }

        private void errado()
        {
            if (_sound)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.errado);
                player.Play();
                Thread.Sleep(2000);
            }
            lblErradas.Tag = Convert.ToInt32(lblErradas.Tag) + 1;
            lblErradas.Text = lblErradas.Tag.ToString();
            jogada = 1;
        }

        private void pic_Click(object sender, EventArgs e)
        {
            PictureBox pic = sender as PictureBox;
            pic.BorderStyle = BorderStyle.Fixed3D;
            if (jogada == 1)
            {
                corTentativa = pic.Image;
                jogada++;
            }
            else
            {
                if (corTentativa == pic.Image)
                    GameControl.validarJogada();// certo();
                else
                {
                    foreach (PictureBox picAll in pics)
                        picAll.BorderStyle = BorderStyle.None;
                    errado();
                }
            }

            
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Queres mesmo sair?", "Sair?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                this.Close();
        }

        private void frmParesCores_Load(object sender, EventArgs e)
        {
            this.GameControl = new GameControl();

            cores = new Bitmap[] { Properties.Resources.corAmarelo, Properties.Resources.corBranco, Properties.Resources.corAzul, Properties.Resources.corVerde, Properties.Resources.corVermelho, Properties.Resources.corLaranja, Properties.Resources.corRosa, };
            foreach (PictureBox pic in pics)
                pic.Click += new EventHandler(pic_Click);

            geraCor(cor);
        }
    }
}
