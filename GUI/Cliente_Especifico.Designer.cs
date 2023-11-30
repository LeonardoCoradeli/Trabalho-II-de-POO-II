
namespace Trabalho_II_de_POO_II.GUI
{
    partial class Cliente_Especifico
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
            this.btnClienteEspecifico = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.CBClienteEspecifico = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnClienteEspecifico
            // 
            this.btnClienteEspecifico.Location = new System.Drawing.Point(15, 52);
            this.btnClienteEspecifico.Name = "btnClienteEspecifico";
            this.btnClienteEspecifico.Size = new System.Drawing.Size(75, 23);
            this.btnClienteEspecifico.TabIndex = 5;
            this.btnClienteEspecifico.Text = "Confirmar";
            this.btnClienteEspecifico.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Clientes";
            // 
            // CBClienteEspecifico
            // 
            this.CBClienteEspecifico.FormattingEnabled = true;
            this.CBClienteEspecifico.Location = new System.Drawing.Point(15, 25);
            this.CBClienteEspecifico.Name = "CBClienteEspecifico";
            this.CBClienteEspecifico.Size = new System.Drawing.Size(121, 21);
            this.CBClienteEspecifico.TabIndex = 3;
            // 
            // CE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(157, 83);
            this.Controls.Add(this.btnClienteEspecifico);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CBClienteEspecifico);
            this.Name = "CE";
            this.Text = "CE";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClienteEspecifico;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CBClienteEspecifico;
    }
}