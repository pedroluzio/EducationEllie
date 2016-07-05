namespace Ellie
{
    partial class frmJuntarCores
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
            this.btnSair = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.picCor1 = new System.Windows.Forms.PictureBox();
            this.picCor8 = new System.Windows.Forms.PictureBox();
            this.picCor6 = new System.Windows.Forms.PictureBox();
            this.picCor3 = new System.Windows.Forms.PictureBox();
            this.picCor5 = new System.Windows.Forms.PictureBox();
            this.picCor2 = new System.Windows.Forms.PictureBox();
            this.picCor4 = new System.Windows.Forms.PictureBox();
            this.placar1 = new EllieLogicShared.Placar();
            this.picCor7 = new System.Windows.Forms.PictureBox();

           
            
            ((System.ComponentModel.ISupportInitialize)(this.picCor1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCor8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCor6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCor3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCor5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCor2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCor4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCor7)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSair
            // 
            this.btnSair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSair.BackColor = System.Drawing.Color.Transparent;
            this.btnSair.BackgroundImage = global::Ellie.Properties.Resources.door;
            this.btnSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Location = new System.Drawing.Point(896, 472);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(100, 51);
            this.btnSair.TabIndex = 26;
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(44, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(952, 85);
            this.label1.TabIndex = 27;
            this.label1.Text = "Junta os pares das cores";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picCor1
            // 
            this.picCor1.BackColor = System.Drawing.Color.Transparent;
            this.picCor1.Location = new System.Drawing.Point(249, 162);
            this.picCor1.Name = "picCor1";
            this.picCor1.Size = new System.Drawing.Size(80, 80);
            this.picCor1.TabIndex = 28;
            this.picCor1.TabStop = false;
            // 
            // picCor8
            // 
            this.picCor8.BackColor = System.Drawing.Color.Transparent;
            this.picCor8.Location = new System.Drawing.Point(479, 338);
            this.picCor8.Name = "picCor8";
            this.picCor8.Size = new System.Drawing.Size(80, 80);
            this.picCor8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCor8.TabIndex = 30;
            this.picCor8.TabStop = false;
            // 
            // picCor6
            // 
            this.picCor6.BackColor = System.Drawing.Color.Transparent;
            this.picCor6.Location = new System.Drawing.Point(698, 338);
            this.picCor6.Name = "picCor6";
            this.picCor6.Size = new System.Drawing.Size(80, 80);
            this.picCor6.TabIndex = 31;
            this.picCor6.TabStop = false;
            // 
            // picCor3
            // 
            this.picCor3.BackColor = System.Drawing.Color.Transparent;
            this.picCor3.Location = new System.Drawing.Point(698, 162);
            this.picCor3.Name = "picCor3";
            this.picCor3.Size = new System.Drawing.Size(80, 80);
            this.picCor3.TabIndex = 32;
            this.picCor3.TabStop = false;
            // 
            // picCor5
            // 
            this.picCor5.BackColor = System.Drawing.Color.Transparent;
            this.picCor5.Location = new System.Drawing.Point(590, 249);
            this.picCor5.Name = "picCor5";
            this.picCor5.Size = new System.Drawing.Size(80, 80);
            this.picCor5.TabIndex = 33;
            this.picCor5.TabStop = false;
            // 
            // picCor2
            // 
            this.picCor2.BackColor = System.Drawing.Color.Transparent;
            this.picCor2.Location = new System.Drawing.Point(479, 162);
            this.picCor2.Name = "picCor2";
            this.picCor2.Size = new System.Drawing.Size(80, 80);
            this.picCor2.TabIndex = 34;
            this.picCor2.TabStop = false;
            // 
            // picCor4
            // 
            this.picCor4.BackColor = System.Drawing.Color.Transparent;
            this.picCor4.Location = new System.Drawing.Point(366, 249);
            this.picCor4.Name = "picCor4";
            this.picCor4.Size = new System.Drawing.Size(80, 80);
            this.picCor4.TabIndex = 35;
            this.picCor4.TabStop = false;
            // 
            // placar1
            // 
            this.placar1.BackColor = System.Drawing.Color.Transparent;
            this.placar1.Location = new System.Drawing.Point(35, 325);
            this.placar1.Name = "placar1";
            this.placar1.Size = new System.Drawing.Size(276, 198);
            this.placar1.TabIndex = 36;
            // 
            // picCor7
            // 
            this.picCor7.BackColor = System.Drawing.Color.Transparent;
            this.picCor7.Location = new System.Drawing.Point(249, 338);
            this.picCor7.Name = "picCor7";
            this.picCor7.Size = new System.Drawing.Size(80, 80);
            this.picCor7.TabIndex = 37;
            this.picCor7.TabStop = false;

            
            // 
            // frmJuntarCores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Ellie.Properties.Resources.FundoJogos;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1040, 566);
            this.Controls.Add(this.picCor7);
            this.Controls.Add(this.placar1);
            this.Controls.Add(this.picCor4);
            this.Controls.Add(this.picCor2);
            this.Controls.Add(this.picCor5);
            this.Controls.Add(this.picCor3);
            this.Controls.Add(this.picCor6);
            this.Controls.Add(this.picCor8);
            this.Controls.Add(this.picCor1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSair);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmJuntarCores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmParesCores";
            this.Load += new System.EventHandler(this.frmParesCores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picCor1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCor8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCor6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCor3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCor5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCor2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCor4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCor7)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picCor1;
        private System.Windows.Forms.PictureBox picCor8;
        private System.Windows.Forms.PictureBox picCor6;
        private System.Windows.Forms.PictureBox picCor3;
        private System.Windows.Forms.PictureBox picCor5;
        private System.Windows.Forms.PictureBox picCor2;
        private System.Windows.Forms.PictureBox picCor4;
        private EllieLogicShared.Placar placar1;
        private System.Windows.Forms.PictureBox picCor7;
        
    }
}