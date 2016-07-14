namespace Ellie
{
    partial class MessageBoard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnSim = new System.Windows.Forms.Button();
            this.btnNao = new System.Windows.Forms.Button();
            this.lblSim = new System.Windows.Forms.Label();
            this.lblNao = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(18, 19);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(464, 52);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "label1";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSim
            // 
            this.btnSim.BackColor = System.Drawing.Color.Transparent;
            this.btnSim.BackgroundImage = global::Ellie.Properties.Resources.img_certo;
            this.btnSim.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSim.FlatAppearance.BorderSize = 0;
            this.btnSim.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnSim.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSim.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSim.Location = new System.Drawing.Point(75, 148);
            this.btnSim.Name = "btnSim";
            this.btnSim.Size = new System.Drawing.Size(49, 46);
            this.btnSim.TabIndex = 1;
            this.btnSim.UseVisualStyleBackColor = false;
            this.btnSim.Click += new System.EventHandler(this.btnSim_Click);
            // 
            // btnNao
            // 
            this.btnNao.BackColor = System.Drawing.Color.Transparent;
            this.btnNao.BackgroundImage = global::Ellie.Properties.Resources.img_errado;
            this.btnNao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNao.FlatAppearance.BorderSize = 0;
            this.btnNao.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnNao.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnNao.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnNao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNao.Location = new System.Drawing.Point(275, 148);
            this.btnNao.Name = "btnNao";
            this.btnNao.Size = new System.Drawing.Size(49, 46);
            this.btnNao.TabIndex = 2;
            this.btnNao.UseVisualStyleBackColor = false;
            this.btnNao.Click += new System.EventHandler(this.btnNao_Click);
            // 
            // lblSim
            // 
            this.lblSim.AutoSize = true;
            this.lblSim.BackColor = System.Drawing.Color.Transparent;
            this.lblSim.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.lblSim.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblSim.Location = new System.Drawing.Point(130, 148);
            this.lblSim.Name = "lblSim";
            this.lblSim.Size = new System.Drawing.Size(89, 46);
            this.lblSim.TabIndex = 3;
            this.lblSim.Text = "Sim";
            this.lblSim.Click += new System.EventHandler(this.lblSim_Click);
            // 
            // lblNao
            // 
            this.lblNao.AutoSize = true;
            this.lblNao.BackColor = System.Drawing.Color.Transparent;
            this.lblNao.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.lblNao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblNao.Location = new System.Drawing.Point(330, 148);
            this.lblNao.Name = "lblNao";
            this.lblNao.Size = new System.Drawing.Size(94, 46);
            this.lblNao.TabIndex = 4;
            this.lblNao.Text = "Não";
            this.lblNao.Click += new System.EventHandler(this.lblNao_Click);
            // 
            // MessageBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Ellie.Properties.Resources.MessageBoard;
            this.ClientSize = new System.Drawing.Size(500, 250);
            this.Controls.Add(this.lblNao);
            this.Controls.Add(this.lblSim);
            this.Controls.Add(this.btnNao);
            this.Controls.Add(this.btnSim);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MessageBoard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.MessageBoard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnSim;
        private System.Windows.Forms.Button btnNao;
        private System.Windows.Forms.Label lblSim;
        private System.Windows.Forms.Label lblNao;
    }
}
