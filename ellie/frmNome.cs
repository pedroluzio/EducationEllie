using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ellie
{
    public partial class frmNome : Form
    {
        public frmNome()
        {
            InitializeComponent();
        }
        bool aberto = true;
        

        private void btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button; 
            lblNome.Text += btn.Tag;
        }

        private void teste_Load(object sender, EventArgs e)
        {
            System.Drawing.Text.PrivateFontCollection privateFonts = new PrivateFontCollection();
            privateFonts.AddFontFile("Crayon.ttf");
            List<Button> buttons = new List<Button>();
            for (int i = 65; i <= 90; i++)
            {
                Button newButton = new Button();
                newButton.Size = new Size(65,65);
                newButton.Font = new Font(privateFonts.Families[0], 40);
                newButton.Text = ((char)i).ToString();
                newButton.Tag = ((char)i).ToString();
                newButton.FlatStyle = FlatStyle.Flat;
                newButton.BackColor = Color.Transparent;
                newButton.FlatAppearance.BorderSize = 0;
                newButton.FlatAppearance.MouseDownBackColor = Color.Transparent;
                newButton.FlatAppearance.MouseOverBackColor = Color.Transparent;
                newButton.ForeColor = Color.White;
                newButton.Click += new EventHandler(btn_Click);
                buttons.Add(newButton);         
                flowLayoutPanel2.Controls.Add(newButton);
            }

            Button spaceButton = new Button();
            spaceButton.Size = new Size(65, 65);
            spaceButton.Font = new Font(spaceButton.Font.FontFamily, 30);
            spaceButton.Text = "__";
            spaceButton.Tag = ((char)32).ToString();
            spaceButton.FlatStyle = FlatStyle.Flat;
            spaceButton.BackColor = Color.Transparent;
            spaceButton.FlatAppearance.BorderSize = 0;
            spaceButton.FlatAppearance.MouseDownBackColor = Color.Transparent;
            spaceButton.FlatAppearance.MouseOverBackColor = Color.Transparent;
            spaceButton.ForeColor = Color.White;
            spaceButton.Click += new EventHandler(btn_Click);
            buttons.Add(spaceButton);
            flowLayoutPanel2.Controls.Add(spaceButton);

            
            lblTitulo.Font = new Font(privateFonts.Families[0], 50);

            lblNome.Font = new Font(privateFonts.Families[0], 40);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (aberto)
                picEllie.Image = Properties.Resources.mascote;
            else
                picEllie.Image = Properties.Resources.mascote1;

            aberto = !aberto;
                
        }


        private void picEllie_Click(object sender, EventArgs e)
        {
            frmMascote mascote = new frmMascote("ajuda nome");
            mascote.Show();
        }

        private void picHelp_Click(object sender, EventArgs e)
        {
            frmMascote mascote = new frmMascote("ajuda nome");
            mascote.Show();
        }

        private void btnApaga_Click(object sender, EventArgs e)
        {
            lblNome.Text = lblNome.Text.Length>0?lblNome.Text.Remove(lblNome.Text.Length - 1):lblNome.Text;
        }

        private void btnEnvia_Click(object sender, EventArgs e)
        {
            Persistencia dados = new Persistencia();

            Int32 idPayer = dados.SaveNewPlayer(lblNome.Text);

            this.Close();
        }























        /*
    private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
    {
        if (e.Button == System.Windows.Forms.MouseButtons.Left)
        {
            MouseDownLocation = e.Location;
        }
    }

    private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
    {
        if (e.Button == System.Windows.Forms.MouseButtons.Left)
        {
            pictureBox1.Left = e.X + pictureBox1.Left - MouseDownLocation.X;
            pictureBox1.Top = e.Y + pictureBox1.Top - MouseDownLocation.Y;                
        }
    }

    private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
    {
        if (flowLayoutPanel1.Bounds.Contains(pictureBox1.Location))
        {
            flowLayoutPanel1.Controls.Add(pictureBox1);
            pictureBox1.Enabled = false;
        }
    }*/












    }
}
