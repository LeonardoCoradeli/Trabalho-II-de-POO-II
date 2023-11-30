
namespace Trabalho_II_de_POO_II.GUI
{
    partial class Desenvolvedora_Especifico
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
            this.btnDesenvolvedoraEspecifica = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.CBDesenvolvedoraEspecifica = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnDesenvolvedoraEspecifica
            // 
            this.btnDesenvolvedoraEspecifica.Location = new System.Drawing.Point(6, 52);
            this.btnDesenvolvedoraEspecifica.Name = "btnDesenvolvedoraEspecifica";
            this.btnDesenvolvedoraEspecifica.Size = new System.Drawing.Size(75, 23);
            this.btnDesenvolvedoraEspecifica.TabIndex = 8;
            this.btnDesenvolvedoraEspecifica.Text = "Confirmar";
            this.btnDesenvolvedoraEspecifica.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Desenvolvedora";
            // 
            // CBDesenvolvedoraEspecifica
            // 
            this.CBDesenvolvedoraEspecifica.FormattingEnabled = true;
            this.CBDesenvolvedoraEspecifica.Location = new System.Drawing.Point(6, 25);
            this.CBDesenvolvedoraEspecifica.Name = "CBDesenvolvedoraEspecifica";
            this.CBDesenvolvedoraEspecifica.Size = new System.Drawing.Size(121, 21);
            this.CBDesenvolvedoraEspecifica.TabIndex = 6;
            // 
            // DE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(144, 82);
            this.Controls.Add(this.btnDesenvolvedoraEspecifica);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CBDesenvolvedoraEspecifica);
            this.Name = "DE";
            this.Text = "DE";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDesenvolvedoraEspecifica;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CBDesenvolvedoraEspecifica;
    }
}