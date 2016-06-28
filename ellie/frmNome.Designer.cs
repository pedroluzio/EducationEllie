namespace Ellie
{
    partial class frmNome
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
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.picEllie = new System.Windows.Forms.PictureBox();
            this.picHelp = new System.Windows.Forms.PictureBox();
            this.btnEnvia = new System.Windows.Forms.Button();
            this.btnApaga = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picEllie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHelp)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(32, 171);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(973, 244);
            this.flowLayoutPanel2.TabIndex = 3;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.BackColor = System.Drawing.Color.Transparent;
            this.lblNome.Font = new System.Drawing.Font("DK Crayon Crumble", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.Color.Gold;
            this.lblNome.Location = new System.Drawing.Point(305, 436);
            this.lblNome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(0, 85);
            this.lblNome.TabIndex = 4;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(11, 33);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(1018, 85);
            this.lblTitulo.TabIndex = 5;
            this.lblTitulo.Text = "Escreve o teu nome";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picEllie
            // 
            this.picEllie.BackColor = System.Drawing.Color.Transparent;
            this.picEllie.Image = global::Ellie.Properties.Resources.mascoteGif1;
            this.picEllie.Location = new System.Drawing.Point(32, 33);
            this.picEllie.Name = "picEllie";
            this.picEllie.Size = new System.Drawing.Size(124, 126);
            this.picEllie.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picEllie.TabIndex = 6;
            this.picEllie.TabStop = false;
            this.picEllie.Click += new System.EventHandler(this.picEllie_Click);
            // 
            // picHelp
            // 
            this.picHelp.BackColor = System.Drawing.Color.Transparent;
            this.picHelp.Image = global::Ellie.Properties.Resources.helpGif1;
            this.picHelp.Location = new System.Drawing.Point(134, 31);
            this.picHelp.Name = "picHelp";
            this.picHelp.Size = new System.Drawing.Size(40, 50);
            this.picHelp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picHelp.TabIndex = 8;
            this.picHelp.TabStop = false;
            this.picHelp.Click += new System.EventHandler(this.picHelp_Click);
            // 
            // btnEnvia
            // 
            this.btnEnvia.BackColor = System.Drawing.Color.Transparent;
            this.btnEnvia.BackgroundImage = global::Ellie.Properties.Resources.img_certo;
            this.btnEnvia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEnvia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnvia.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnEnvia.FlatAppearance.BorderSize = 0;
            this.btnEnvia.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnEnvia.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnEnvia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnvia.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnvia.ForeColor = System.Drawing.Color.White;
            this.btnEnvia.Location = new System.Drawing.Point(884, 471);
            this.btnEnvia.Margin = new System.Windows.Forms.Padding(5);
            this.btnEnvia.Name = "btnEnvia";
            this.btnEnvia.Size = new System.Drawing.Size(50, 50);
            this.btnEnvia.TabIndex = 11;
            this.btnEnvia.UseVisualStyleBackColor = false;
            this.btnEnvia.Click += new System.EventHandler(this.btnEnvia_Click);
            // 
            // btnApaga
            // 
            this.btnApaga.BackColor = System.Drawing.Color.Transparent;
            this.btnApaga.BackgroundImage = global::Ellie.Properties.Resources.img_errado;
            this.btnApaga.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnApaga.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnApaga.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnApaga.FlatAppearance.BorderSize = 0;
            this.btnApaga.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnApaga.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnApaga.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApaga.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApaga.ForeColor = System.Drawing.Color.White;
            this.btnApaga.Location = new System.Drawing.Point(944, 471);
            this.btnApaga.Margin = new System.Windows.Forms.Padding(5);
            this.btnApaga.Name = "btnApaga";
            this.btnApaga.Size = new System.Drawing.Size(50, 50);
            this.btnApaga.TabIndex = 12;
            this.btnApaga.UseVisualStyleBackColor = false;
            this.btnApaga.Click += new System.EventHandler(this.btnApaga_Click);
            // 
            // nome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(5F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Ellie.Properties.Resources.FundoJogos;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1040, 566);
            this.Controls.Add(this.btnEnvia);
            this.Controls.Add(this.btnApaga);
            this.Controls.Add(this.picHelp);
            this.Controls.Add(this.picEllie);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.flowLayoutPanel2);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("DK Crayon Crumble", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "nome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "teste";
            this.Load += new System.EventHandler(this.teste_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picEllie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHelp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.PictureBox picEllie;
        private System.Windows.Forms.PictureBox picHelp;
        private System.Windows.Forms.Button btnEnvia;
        private System.Windows.Forms.Button btnApaga;
    }
}