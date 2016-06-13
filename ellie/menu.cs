using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Deployment.Application;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Reflection;
using System.Diagnostics;

namespace Ellie
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }
        bool fullscreen = true;
        bool sound = true;
        private void menu_Load(object sender, EventArgs e)
        {
            btn_contar.Cursor = Cursors.Hand;
            btn_contas.Cursor = Cursors.Hand;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            contar frmContar = new contar(sound);
            frmContar.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            money frmMoney = new money();
            frmMoney.Show();
        }

        private void button4_Click(object sender, EventArgs e)
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

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            WebRequest wr = WebRequest.Create(new Uri("http://pappl.bugs3.com/version.txt"));
            WebResponse ws = wr.GetResponse();
            StreamReader sr = new StreamReader(ws.GetResponseStream());
            
            string currentVersion = Assembly.GetExecutingAssembly().GetName().Version.ToString();
            string newVersion = sr.ReadLine();
            if (currentVersion == newVersion)
                MessageBox.Show("Tem a versão mais recente");
            else
            {
                MessageBox.Show("Há uma nova versão!");
                WebClient Client = new WebClient();
                FileInfo file = new FileInfo("version.txt");
                Client.DownloadFile("http://pappl.bugs3.com/version.txt", file.FullName);
                MessageBox.Show("Downloaded!");

                Process.Start(file.FullName);
                this.Close();
            }
                  
        }

        private void pic_opcoes_Click(object sender, EventArgs e)
        {
            opcoes opcoes = new opcoes();
            opcoes.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            mascote mascote = new mascote("início");
            mascote.Show();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            if (sound)
                button4.BackgroundImage = Properties.Resources.muteOn;
            else
                button4.BackgroundImage = Properties.Resources.muteOff;
            sound = !sound;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            info info = new info();
            info.Show();
        }
    }
}