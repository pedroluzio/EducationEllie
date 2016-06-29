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
        // Define o controlador do jogo
        EllieLogicShared.GameControl game_juntarcores;

        // Define se as notificações de áudio serão emitidas
        Boolean _sound;

        // Lista de imagens das cores
        private PictureBox[] pics;

        // Lista da ultima jogada, contendo sequencia de cores sorteadas
        private int[] jogada_recente;

        // Lista de cores disponíveis no jogo
        List<Bitmap> cores;        

        // Cores que serão pares
        int CorPar;

        int cor;//0-Amarelo 1-Branco 2-Azul 3-Verde 4-Vermelho 5-Laranja 6-Rosa

        Image corTentativa;


        public frmJuntarCores(Boolean sound)
        {
            InitializeComponent();

            pics = new PictureBox[] { picCor1, picCor2, picCor3, picCor4, picCor5, picCor6, picCor7, picCor8 };

            this._sound = sound;         

        }

        private void frmParesCores_Load(object sender, EventArgs e)
        {
            this.game_juntarcores = new GameControl();

            game_juntarcores.inicializar(placar1);            

            cores = new List<Bitmap> { Properties.Resources.corAmarelo, Properties.Resources.corBranco, Properties.Resources.corAzul, Properties.Resources.corVerde, Properties.Resources.corVermelho, Properties.Resources.corLaranja, Properties.Resources.corRosa, };

            geraCor(cor);         

            
        }


        public ICollection<PictureBox> Pics
        {
            get { return Pics; }
        }


        /// <summary>
        /// Gera cores aleatórias e define nos componentes gráficos
        /// </summary>
        /// <param name="corAtual">0-Amarelo 1-Branco 2-Azul 3-Verde 4-Vermelho 5-Laranja 6-Rosa</param>
        private void geraCor(int corAtual)
        {
            Random rdn = new Random();

            // Escolhe a cor par da jogada
            do
                CorPar = cor = rdn.Next(0, cores.Count);
            while (CorPar == corAtual);

           

            // Escolhe duas posições para a cor

            int posicao_cor_par1 = rdn.Next(0, 8);
            
            int posicao_cor_par2 = 0;

            // Gera posição diferente para a cor par
            do
                posicao_cor_par2 = rdn.Next(0, 8); // Gera uma cor aleatória
            while (posicao_cor_par2 == posicao_cor_par1);

            // Define as imagens dos PIctureBox nas posições sorteadas

            pics[posicao_cor_par1].Image = cores[CorPar];
            pics[posicao_cor_par1].Click += new EventHandler(pic_Click);
            pics[posicao_cor_par2].Image = cores[CorPar];
            pics[posicao_cor_par2].Click += new EventHandler(pic_Click);

            cores.RemoveAt(CorPar);


            // Percorre a lista de imagens 
            for (int i = 0; i < pics.Length; i++)
            {
                int cor_sorteada = -1;

                do
                    cor_sorteada = rdn.Next(0, cores.Count);
                while (cor_sorteada == CorPar);

                // Configura cor na posição

                if (i != posicao_cor_par1 && posicao_cor_par2 != i)
                    if (cores.Count > 0)
                    {
                        pics[i].Image = cores[cor_sorteada];
                        pics[i].Click += new EventHandler(pic_Click);
                        cores.RemoveAt(cor_sorteada);
                    }
            }

            /*            
            foreach (PictureBox picAll in pics)
                picAll.BorderStyle = BorderStyle.None;
            */
        }
       



        private void pic_Click(object sender, EventArgs e)
        {
            PictureBox pic = sender as PictureBox;

            pic.BorderStyle = BorderStyle.Fixed3D;

            // Verifica se é a primeira jogada
            if (corTentativa == null)
            {
                corTentativa = pic.Image;                
                pic.BorderStyle = BorderStyle.FixedSingle;
            }
            else
            {
                game_juntarcores.fazerJogada(corTentativa, pic.Image);
                pic.BorderStyle = BorderStyle.FixedSingle;

                corTentativa = null;

                geraCor(0);
            }            
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Queres mesmo sair?", "Sair?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                game_juntarcores.encerrar();
                this.Close();
            }
        }
    }
}
