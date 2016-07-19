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
using System.Net.Mail;
using System.Globalization;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;

namespace Ellie
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }
        bool fullscreen = true;
        bool sound = true;
        private void menu_Load(object sender, EventArgs e)
        {
            btnContar.Cursor = Cursors.Hand;
            btnContas.Cursor = Cursors.Hand;

            StreamReader sr = new StreamReader("config.ini");
            string text = sr.ReadToEnd();
            String temp;

            try
            {
                temp = text.Substring(text.IndexOf("[geral]") + 9);
                temp = temp.Substring(temp.IndexOf("som") + 4, temp.IndexOf("\r\n", temp.IndexOf("som")) - (temp.IndexOf("som") + 4));
                sound = Convert.ToBoolean(temp);
                btnSom.PerformClick();
                btnSom.PerformClick();

            }
            catch { }
            sr.Close();


            
            WebRequest wr = WebRequest.Create(new Uri("http://pedroluzio.github.io/EducationEllie/version.txt"));
            WebResponse ws = wr.GetResponse();
            StreamReader srr = new StreamReader(ws.GetResponseStream());

            string currentVersion = Assembly.GetExecutingAssembly().GetName().Version.ToString();
            string newVersion = srr.ReadLine();
            if (currentVersion != newVersion)
            {
                
                if (MessageBox.Show("Há uma nova versão! Deseja fazer o download?","Nova versão",MessageBoxButtons.YesNo)==DialogResult.Yes)
                {
                    WebClient Client = new WebClient();
                    FileInfo file = new FileInfo("version.txt");
                    Client.DownloadFile("https://github.com/pedroluzio/EducationEllie/raw/master/ellie/bin/Debug/Ellie.exe", "new.exe");                    
                    Process.Start("update.bat"); 
                }
                
               
            }


            frmMascote mascote = new frmMascote("início");
            mascote.ShowDialog();


            try
            {
                MailMessage msg = new MailMessage();

                msg.From = new MailAddress("education.ellie.project@gmail.com");
                msg.To.Add("education.ellie.project@gmail.com");
                string culture = CultureInfo.CurrentCulture.EnglishName;
                string country = culture.Substring(culture.IndexOf('(') + 1, culture.LastIndexOf(')') - culture.IndexOf('(') - 1);
                msg.Subject = "New Access - " + country;
                string userName = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
                string myIP = Dns.GetHostByName(Dns.GetHostName()).AddressList[0].ToString();
                msg.Body = userName + Environment.NewLine + myIP + Environment.NewLine + DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
                SmtpClient client = new SmtpClient();

                client.UseDefaultCredentials = true;
                client.Host = "smtp.gmail.com";
                client.Port = 587;
                client.EnableSsl = true;
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.Credentials = new NetworkCredential("education.ellie.project@gmail.com", "educationellie123");
                client.Timeout = 20000;
                try
                {
                    client.Send(msg);
                }
                catch
                {

                }
                finally
                {
                    msg.Dispose();
                }
            }
            catch { }
                        
            





        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmContar frmContar = new frmContar(sound);
            frmContar.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmContas frmContas = new frmContas(sound);
            frmContas.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {

            MessageBoard msg = new MessageBoard("Queres mesmo sair?");

            if (msg.ShowDialog() == System.Windows.Forms.DialogResult.Yes)
                this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            /**/

        }

        private void pic_opcoes_Click(object sender, EventArgs e)
        {
            frmOpcoes opcoes = new frmOpcoes();
            opcoes.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            frmMascote mascote = new frmMascote("início");
            mascote.Show();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            if (sound)
                btnSom.BackgroundImage = Properties.Resources.muteOn;
            else
                btnSom.BackgroundImage = Properties.Resources.muteOff;
            sound = !sound;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            frmInfo info = new frmInfo();
            info.Show();
        }

        private void btnJuntarCores_Click(object sender, EventArgs e)
        {
            frmJuntarCores cores = new frmJuntarCores(sound);
            cores.Show();
        }
    }
}