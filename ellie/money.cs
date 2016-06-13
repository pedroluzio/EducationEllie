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
    public partial class money : Form
    {
        double carteira = 0, preco = 0;
        public money()
        {
            InitializeComponent();
        }

        public void acrescenta(double n)
        {
            carteira += n;
            lblCarteira.Text = carteira.ToString() + '€';
        }

        public void gerapreco()
        {
            Random rdn = new Random();
            preco = rdn.Next(0, 10000)/(double)100;
            lblPreco.Text = preco.ToString() + '€';
            carteira = 0;
            lblCarteira.Text = "";
        }
        private void picM50_Click(object sender, EventArgs e)
        {
            acrescenta(0.5);
        }

        private void picM20_Click(object sender, EventArgs e)
        {
            acrescenta(0.2);
        }

        private void picM01_Click(object sender, EventArgs e)
        {
            acrescenta(0.01);
        }

        private void picM02_Click(object sender, EventArgs e)
        {
            acrescenta(0.02);
        }

        private void picM5_Click(object sender, EventArgs e)
        {
            acrescenta(0.05);
        }

        private void picM1_Click(object sender, EventArgs e)
        {
            acrescenta(1);
        }

        private void picM2_Click(object sender, EventArgs e)
        {
            acrescenta(2);
        }

        private void picM10_Click(object sender, EventArgs e)
        {
            acrescenta(0.1);
        }

        private void picN10_Click(object sender, EventArgs e)
        {
            acrescenta(10);
        }

        private void picN50_Click(object sender, EventArgs e)
        {
            acrescenta(50);
        }

        private void picN20_Click(object sender, EventArgs e)
        {
            acrescenta(20);
        }              

        private void picN5_Click(object sender, EventArgs e)
        {
            acrescenta(5);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(carteira.ToString() + ' ' + preco.ToString());
            MessageBox.Show(lblCarteira.Text + ' ' + lblPreco.Text);

            if (lblCarteira.Text.Equals(lblPreco.Text))
                gerapreco();
            else
                MessageBox.Show("Errado!");
        }

        private void money_Load(object sender, EventArgs e)
        {
            gerapreco();
        }
    }
}
