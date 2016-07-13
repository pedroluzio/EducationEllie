using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ellie
{
    public partial class frmContas : Form
    {
        public frmContas(Boolean sound = true)
        {
            InitializeComponent();
            this._sound = sound;
        }

        Boolean _sound;
        Persistencia Dados = new Persistencia();
        public void numeroEscolhido(int num)
        {
            lblResultado.Text += num;
        }

        int n1=0, n2=0, sinal=0, multiplicacao=10;//1-Soma 2-Subtração 3-Multiplicacao
        Boolean cheio = false;
        public void mudaNumeros()
        {
            Random rdn = new Random();
            int temp = sinal;
            do
                sinal = rdn.Next(1, Convert.ToInt32(lbl_certas.Text) >= multiplicacao ? 4 : 3);
            while (temp == sinal);

            temp = n1;
            do
                n1 = rdn.Next(2, 9);
            while (temp == n1);

            temp = n2;
            do
                do
                {
                    n2 = rdn.Next(1, sinal == 3 ? 4 : 9);
                } while (n2 >= n1);
            while (temp == n2);
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
            mudaNumeros();
            lblNomeScore.Text = Dados.geraResultado(true, true);

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
            mudaNumeros();
            lblNomeScore.Text = Dados.geraResultado(true, false);
        }

        private void ajuda()
        {
            flpAjuda1.Controls.Clear();
            flpAjuda2.Controls.Clear();
            flpAjuda3.Controls.Clear();
            flpAjuda4.Controls.Clear();
            cheio = false;
            timer1.Enabled = true;            
        }

        public class myButtonObject : UserControl
        {
            protected override void OnPaint(PaintEventArgs e)
            {
                Graphics graphics = e.Graphics;
                Pen myPen = new Pen(Color.Black);
                Random random = new Random();
                string color = String.Format("#{0:X6}", random.Next(0x1000000));
                System.Drawing.SolidBrush myBrush = new System.Drawing.SolidBrush(System.Drawing.ColorTranslator.FromHtml(color));
                graphics.FillEllipse(myBrush, new Rectangle(0, 0, 28, 28));
                myPen.Dispose();
            }
        }

        #region Evento Click dos números
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

        private void button10_Click(object sender, EventArgs e)
        {
            numeroEscolhido(0);
        }
        #endregion
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

            flpAjuda1.Controls.Clear();
            flpAjuda2.Controls.Clear();
            flpAjuda3.Controls.Clear();
            flpAjuda4.Controls.Clear();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Queres mesmo sair?", "Sair?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                this.Close();
        }

        private void contas_Load(object sender, EventArgs e)
        {
            try
            {
                StreamReader sr = new StreamReader("config.ini");
                string text = sr.ReadToEnd();
                string temp = text.Substring(text.IndexOf("[contas]") + 10);
                temp = temp.Substring(temp.IndexOf("multiplicacao") + 14, temp.IndexOf("\r\n", temp.IndexOf("multiplicacao")) - (temp.IndexOf("multiplicacao") + 14));
                multiplicacao = Convert.ToInt32(temp);
                sr.Close();
            }
            catch { }
            System.Drawing.Text.PrivateFontCollection privateFonts = new PrivateFontCollection();
            privateFonts.AddFontFile("Crayon.ttf");
            System.Drawing.Font font = new Font(privateFonts.Families[0], 20);
            lblNomeScore.Font = font;
            mudaNumeros();
            btnApaga.PerformClick();
            lblNomeScore.Text = Dados.geraResultado(false);
        }

        private void btnApaga_Click(object sender, EventArgs e)
        {
            lblResultado.Text = " ";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (sinal == 1)
            {
                if (flpAjuda1.Controls.Count < n1)
                {
                    myButtonObject myButton = new myButtonObject();
                    myButton.Size = new System.Drawing.Size(30, 30);
                    flpAjuda1.Controls.Add(myButton);
                }
                else if (flpAjuda2.Controls.Count < n2)
                {
                    myButtonObject myButton = new myButtonObject();
                    myButton.Size = new System.Drawing.Size(30, 30);
                    flpAjuda2.Controls.Add(myButton);
                }
                else
                 timer1.Enabled = false;
            }
            else if (sinal == 2)
            {
                if (flpAjuda1.Controls.Count < n1 && !cheio)
                {
                    myButtonObject myButton = new myButtonObject();
                    myButton.Size = new System.Drawing.Size(30, 30);
                    flpAjuda1.Controls.Add(myButton);
                }
                else if (flpAjuda1.Controls.Count != (n1 - n2) && flpAjuda1.Controls.Count!=0)
                {
                    cheio = true;
                    flpAjuda1.Controls.RemoveAt(flpAjuda1.Controls.Count - 1);
                }
                else if (flpAjuda1.Controls.Count == (n1 - n2))
                    timer1.Enabled = false;
            }
            else if (sinal == 3)
            {
                if (flpAjuda1.Controls.Count < n1)
                {
                    myButtonObject myButton = new myButtonObject();
                    myButton.Size = new System.Drawing.Size(30, 30);
                    flpAjuda1.Controls.Add(myButton);
                }
                else if (flpAjuda2.Controls.Count < n1 && n2 >= 2)
                {
                    myButtonObject myButton = new myButtonObject();
                    myButton.Size = new System.Drawing.Size(30, 30);
                    flpAjuda2.Controls.Add(myButton);
                }
                else if (flpAjuda3.Controls.Count < n1 && n2 >= 3)
                {
                    myButtonObject myButton = new myButtonObject();
                    myButton.Size = new System.Drawing.Size(30, 30);
                    flpAjuda3.Controls.Add(myButton);
                }
                else if (flpAjuda4.Controls.Count < n1 && n2 >= 4)
                {
                    myButtonObject myButton = new myButtonObject();
                    myButton.Size = new System.Drawing.Size(30, 30);
                    flpAjuda4.Controls.Add(myButton);
                }
                else
                    timer1.Enabled = false;
                    
            }

        }

        private void picEllie_Click(object sender, EventArgs e)
        {
            ajuda();
        }

        private void picHelp_Click(object sender, EventArgs e)
        {
            ajuda();
        }
        
    }
}
