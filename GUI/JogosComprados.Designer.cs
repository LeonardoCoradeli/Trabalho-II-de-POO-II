
namespace Trabalho_II_de_POO_II.GUI
{
    partial class JogosComprados
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
            this.nomeJogoComprar = new System.Windows.Forms.TextBox();
            this.precoJogoComprar = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // nomeJogoComprar
            // 
            this.nomeJogoComprar.Location = new System.Drawing.Point(3, 12);
            this.nomeJogoComprar.Name = "nomeJogoComprar";
            this.nomeJogoComprar.Size = new System.Drawing.Size(216, 20);
            this.nomeJogoComprar.TabIndex = 0;
            // 
            // precoJogoComprar
            // 
            this.precoJogoComprar.Location = new System.Drawing.Point(3, 47);
            this.precoJogoComprar.Name = "precoJogoComprar";
            this.precoJogoComprar.Size = new System.Drawing.Size(216, 20);
            this.precoJogoComprar.TabIndex = 1;
            // 
            // JogosComprados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.precoJogoComprar);
            this.Controls.Add(this.nomeJogoComprar);
            this.Name = "JogosComprados";
            this.Size = new System.Drawing.Size(222, 90);
            this.Load += new System.EventHandler(this.JogosComprados_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nomeJogoComprar;
        private System.Windows.Forms.TextBox precoJogoComprar;
    }
}
