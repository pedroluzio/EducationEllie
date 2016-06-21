namespace Ellie
{
    partial class menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(menu));
            this.btn_contar = new System.Windows.Forms.Button();
            this.btn_contas = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.pic_opcoes = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_opcoes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_contar
            // 
            this.btn_contar.BackColor = System.Drawing.Color.Transparent;
            this.btn_contar.BackgroundImage = global::Ellie.Properties.Resources.MenuContar;
            this.btn_contar.FlatAppearance.BorderSize = 0;
            this.btn_contar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_contar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_contar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_contar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_contar.Location = new System.Drawing.Point(92, 101);
            this.btn_contar.Margin = new System.Windows.Forms.Padding(50);
            this.btn_contar.Name = "btn_contar";
            this.btn_contar.Size = new System.Drawing.Size(100, 100);
            this.btn_contar.TabIndex = 0;
            this.btn_contar.UseVisualStyleBackColor = false;
            this.btn_contar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_contas
            // 
            this.btn_contas.BackColor = System.Drawing.Color.Transparent;
            this.btn_contas.BackgroundImage = global::Ellie.Properties.Resources.MenuContas;
            this.btn_contas.FlatAppearance.BorderSize = 0;
            this.btn_contas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_contas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_contas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_contas.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_contas.Location = new System.Drawing.Point(228, 234);
            this.btn_contas.Margin = new System.Windows.Forms.Padding(50);
            this.btn_contas.Name = "btn_contas";
            this.btn_contas.Size = new System.Drawing.Size(100, 100);
            this.btn_contas.TabIndex = 2;
            this.btn_contas.UseVisualStyleBackColor = false;
            this.btn_contas.Click += new System.EventHandler(this.button4_Click);
            // 
            // button11
            // 
            this.button11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button11.BackColor = System.Drawing.Color.Transparent;
            this.button11.BackgroundImage = global::Ellie.Properties.Resources.door;
            this.button11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button11.FlatAppearance.BorderSize = 0;
            this.button11.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button11.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Location = new System.Drawing.Point(904, 474);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(100, 53);
            this.button11.TabIndex = 18;
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Red;
            this.button5.Location = new System.Drawing.Point(671, 154);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(331, 47);
            this.button5.TabIndex = 19;
            this.button5.Text = "(Not Click Me!!)\r\nVai ser para ver se há novas versões";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Visible = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // pic_opcoes
            // 
            this.pic_opcoes.BackColor = System.Drawing.Color.Transparent;
            this.pic_opcoes.Image = global::Ellie.Properties.Resources.rodaDentada;
            this.pic_opcoes.Location = new System.Drawing.Point(960, 38);
            this.pic_opcoes.Name = "pic_opcoes";
            this.pic_opcoes.Size = new System.Drawing.Size(40, 40);
            this.pic_opcoes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_opcoes.TabIndex = 20;
            this.pic_opcoes.TabStop = false;
            this.pic_opcoes.Click += new System.EventHandler(this.pic_opcoes_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Lime;
            this.button1.Location = new System.Drawing.Point(671, 207);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(331, 241);
            this.button1.TabIndex = 21;
            this.button1.Text = "(Click Me!!)\r\nEste form irá aparecer aquando do arranque da aplicação";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.BackgroundImage = global::Ellie.Properties.Resources.muteOff;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(868, 38);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(40, 40);
            this.button4.TabIndex = 22;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Ellie.Properties.Resources.info;
            this.pictureBox1.Location = new System.Drawing.Point(914, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Ellie.Properties.Resources.FundoJogos;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1040, 566);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pic_opcoes);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.btn_contas);
            this.Controls.Add(this.btn_contar);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "menu";
            this.Load += new System.EventHandler(this.menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_opcoes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_contar;
        private System.Windows.Forms.Button btn_contas;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.PictureBox pic_opcoes;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}