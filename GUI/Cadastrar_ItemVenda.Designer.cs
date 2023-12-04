namespace Trabalho_II_de_POO_II.GUI
{
    partial class Cadastrar_ItemVenda
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
            this.Label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.valorProduto = new System.Windows.Forms.Label();
            this.codigoProduto = new System.Windows.Forms.Label();
            this.quantidadeProduto = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.fisicoProduto = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Label
            // 
            this.Label.AutoSize = true;
            this.Label.Location = new System.Drawing.Point(4, 11);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(43, 13);
            this.Label.TabIndex = 0;
            this.Label.Text = "Código:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Valor:";
            // 
            // valorProduto
            // 
            this.valorProduto.AutoSize = true;
            this.valorProduto.Location = new System.Drawing.Point(81, 35);
            this.valorProduto.Name = "valorProduto";
            this.valorProduto.Size = new System.Drawing.Size(35, 13);
            this.valorProduto.TabIndex = 2;
            this.valorProduto.Text = "label3";
            // 
            // codigoProduto
            // 
            this.codigoProduto.AutoSize = true;
            this.codigoProduto.Location = new System.Drawing.Point(81, 11);
            this.codigoProduto.Name = "codigoProduto";
            this.codigoProduto.Size = new System.Drawing.Size(35, 13);
            this.codigoProduto.TabIndex = 3;
            this.codigoProduto.Text = "label4";
            // 
            // quantidadeProduto
            // 
            this.quantidadeProduto.AutoSize = true;
            this.quantidadeProduto.Location = new System.Drawing.Point(81, 60);
            this.quantidadeProduto.Name = "quantidadeProduto";
            this.quantidadeProduto.Size = new System.Drawing.Size(35, 13);
            this.quantidadeProduto.TabIndex = 5;
            this.quantidadeProduto.Text = "label5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Quantidade:";
            // 
            // fisicoProduto
            // 
            this.fisicoProduto.AutoSize = true;
            this.fisicoProduto.Location = new System.Drawing.Point(81, 87);
            this.fisicoProduto.Name = "fisicoProduto";
            this.fisicoProduto.Size = new System.Drawing.Size(29, 13);
            this.fisicoProduto.TabIndex = 7;
            this.fisicoProduto.Text = "label";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 87);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Fisico:";
            // 
            // Cadastrar_ItemVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.fisicoProduto);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.quantidadeProduto);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.codigoProduto);
            this.Controls.Add(this.valorProduto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Label);
            this.Name = "Cadastrar_ItemVenda";
            this.Size = new System.Drawing.Size(130, 108);
            this.Load += new System.EventHandler(this.Cadastrar_ItemVenda_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label valorProduto;
        private System.Windows.Forms.Label codigoProduto;
        private System.Windows.Forms.Label quantidadeProduto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label fisicoProduto;
        private System.Windows.Forms.Label label8;
    }
}
