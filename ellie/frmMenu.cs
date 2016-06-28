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

            frmMascote mascote = new frmMascote("início");
            mascote.ShowDialog();

            /*MailMessage msg = new MailMessage();

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

            
            

            string sql = "INSERT INTO access(country, user, date, ip)VALUES('"+country+"', '"+userName+"', '"+ DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") + "','"+myIP+"'); ";

            MySqlConnectionStringBuilder conn_string = new MySqlConnectionStringBuilder();
            conn_string.Server = "mysql3.gear.host";
            conn_string.UserID = "access";
            conn_string.Password = "Ar4ebL2_?1nC";
            conn_string.Database = "access";

            MySqlConnection conn = new MySqlConnection(conn_string.ToString());
            //MySqlCommand cmd = conn.CreateCommand();

            try
            {
                conn.Open();


                MySqlCommand MyCommand2 = new MySqlCommand(sql, conn);
                MySqlDataReader MyReader2;
                MyReader2 = MyCommand2.ExecuteReader();
                while (MyReader2.Read())
                {
                }
                conn.Close();
            }
            catch { }*/




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
                button4.BackgroundImage = Properties.Resources.muteOn;
            else
                button4.BackgroundImage = Properties.Resources.muteOff;
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