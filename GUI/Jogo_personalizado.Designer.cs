namespace Trabalho_II_de_POO_II.GUI
{
    partial class Jogo_personalizado
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Jogo_personalizado));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.nomeJogo = new System.Windows.Forms.Label();
            this.precoJogo = new System.Windows.Forms.Label();
            this.codigoJogo = new System.Windows.Forms.Label();
            this.avaliacaoJogo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "imagem.png");
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(59, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 36);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // nomeJogo
            // 
            this.nomeJogo.AutoSize = true;
            this.nomeJogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeJogo.Location = new System.Drawing.Point(114, 15);
            this.nomeJogo.Name = "nomeJogo";
            this.nomeJogo.Size = new System.Drawing.Size(51, 20);
            this.nomeJogo.TabIndex = 1;
            this.nomeJogo.Text = "label1";
            // 
            // precoJogo
            // 
            this.precoJogo.AutoSize = true;
            this.precoJogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.precoJogo.Location = new System.Drawing.Point(114, 47);
            this.precoJogo.Name = "precoJogo";
            this.precoJogo.Size = new System.Drawing.Size(57, 20);
            this.precoJogo.TabIndex = 2;
            this.precoJogo.Text = "Label2";
            // 
            // codigoJogo
            // 
            this.codigoJogo.AutoSize = true;
            this.codigoJogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codigoJogo.Location = new System.Drawing.Point(13, 47);
            this.codigoJogo.Name = "codigoJogo";
            this.codigoJogo.Size = new System.Drawing.Size(21, 20);
            this.codigoJogo.TabIndex = 3;
            this.codigoJogo.Text = "la";
            this.codigoJogo.Click += new System.EventHandler(this.codigoJogo_Click);
            // 
            // avaliacaoJogo
            // 
            this.avaliacaoJogo.AutoSize = true;
            this.avaliacaoJogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.avaliacaoJogo.Location = new System.Drawing.Point(114, 79);
            this.avaliacaoJogo.Name = "avaliacaoJogo";
            this.avaliacaoJogo.Size = new System.Drawing.Size(57, 20);
            this.avaliacaoJogo.TabIndex = 4;
            this.avaliacaoJogo.Text = "Label2";
            // 
            // Jogo_personalizado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.avaliacaoJogo);
            this.Controls.Add(this.codigoJogo);
            this.Controls.Add(this.precoJogo);
            this.Controls.Add(this.nomeJogo);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Jogo_personalizado";
            this.Size = new System.Drawing.Size(201, 108);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label nomeJogo;
        private System.Windows.Forms.Label precoJogo;
        private System.Windows.Forms.Label codigoJogo;
        private System.Windows.Forms.Label avaliacaoJogo;
    }
}
