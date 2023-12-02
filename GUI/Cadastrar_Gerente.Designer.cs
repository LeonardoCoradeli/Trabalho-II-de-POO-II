
namespace Trabalho_II_de_POO_II.GUI
{
    partial class Cadastrar_Gerente
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
            this.btnCadastrarCliente = new System.Windows.Forms.Button();
            this.epicoCliente = new System.Windows.Forms.CheckBox();
            this.emailCliente = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cepCliente = new System.Windows.Forms.MaskedTextBox();
            this.enderecoCliente = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dataNascCliente = new System.Windows.Forms.MaskedTextBox();
            this.rgCliente = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cpfCliente = new System.Windows.Forms.MaskedTextBox();
            this.nomeCliente = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCadastrarCliente
            // 
            this.btnCadastrarCliente.Location = new System.Drawing.Point(230, 141);
            this.btnCadastrarCliente.Name = "btnCadastrarCliente";
            this.btnCadastrarCliente.Size = new System.Drawing.Size(94, 37);
            this.btnCadastrarCliente.TabIndex = 36;
            this.btnCadastrarCliente.Text = "Cadastrar";
            this.btnCadastrarCliente.UseVisualStyleBackColor = true;
            // 
            // epicoCliente
            // 
            this.epicoCliente.AutoSize = true;
            this.epicoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.epicoCliente.Location = new System.Drawing.Point(377, 96);
            this.epicoCliente.Name = "epicoCliente";
            this.epicoCliente.Size = new System.Drawing.Size(69, 20);
            this.epicoCliente.TabIndex = 35;
            this.epicoCliente.Text = "Épico?";
            this.epicoCliente.UseVisualStyleBackColor = true;
            // 
            // emailCliente
            // 
            this.emailCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailCliente.Location = new System.Drawing.Point(402, 31);
            this.emailCliente.Name = "emailCliente";
            this.emailCliente.Size = new System.Drawing.Size(166, 22);
            this.emailCliente.TabIndex = 34;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(326, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 16);
            this.label8.TabIndex = 33;
            this.label8.Text = "Email:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(326, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 16);
            this.label9.TabIndex = 32;
            this.label9.Text = "CEP:";
            // 
            // cepCliente
            // 
            this.cepCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cepCliente.Location = new System.Drawing.Point(402, 3);
            this.cepCliente.Mask = "00000-000";
            this.cepCliente.Name = "cepCliente";
            this.cepCliente.Size = new System.Drawing.Size(166, 22);
            this.cepCliente.TabIndex = 31;
            // 
            // enderecoCliente
            // 
            this.enderecoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enderecoCliente.Location = new System.Drawing.Point(402, 65);
            this.enderecoCliente.Name = "enderecoCliente";
            this.enderecoCliente.Size = new System.Drawing.Size(166, 22);
            this.enderecoCliente.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(326, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 16);
            this.label4.TabIndex = 29;
            this.label4.Text = "Endereço:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 16);
            this.label5.TabIndex = 28;
            this.label5.Text = "Dada de Nasc:";
            // 
            // dataNascCliente
            // 
            this.dataNascCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataNascCliente.Location = new System.Drawing.Point(117, 93);
            this.dataNascCliente.Mask = "00/00/0000";
            this.dataNascCliente.Name = "dataNascCliente";
            this.dataNascCliente.Size = new System.Drawing.Size(166, 22);
            this.dataNascCliente.TabIndex = 27;
            this.dataNascCliente.ValidatingType = typeof(System.DateTime);
            // 
            // rgCliente
            // 
            this.rgCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rgCliente.Location = new System.Drawing.Point(117, 62);
            this.rgCliente.Mask = "00.000.000-0";
            this.rgCliente.Name = "rgCliente";
            this.rgCliente.Size = new System.Drawing.Size(166, 22);
            this.rgCliente.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 16);
            this.label3.TabIndex = 25;
            this.label3.Text = "RG:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 16);
            this.label2.TabIndex = 24;
            this.label2.Text = "CPF:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 23;
            this.label1.Text = "Nome:";
            // 
            // cpfCliente
            // 
            this.cpfCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpfCliente.Location = new System.Drawing.Point(117, 34);
            this.cpfCliente.Mask = "000.000.000-00";
            this.cpfCliente.Name = "cpfCliente";
            this.cpfCliente.Size = new System.Drawing.Size(166, 22);
            this.cpfCliente.TabIndex = 22;
            // 
            // nomeCliente
            // 
            this.nomeCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeCliente.Location = new System.Drawing.Point(117, 6);
            this.nomeCliente.Name = "nomeCliente";
            this.nomeCliente.Size = new System.Drawing.Size(166, 22);
            this.nomeCliente.TabIndex = 21;
            // 
            // Cadastrar_Gerente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 182);
            this.Controls.Add(this.btnCadastrarCliente);
            this.Controls.Add(this.epicoCliente);
            this.Controls.Add(this.emailCliente);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cepCliente);
            this.Controls.Add(this.enderecoCliente);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataNascCliente);
            this.Controls.Add(this.rgCliente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cpfCliente);
            this.Controls.Add(this.nomeCliente);
            this.Name = "Cadastrar_Gerente";
            this.Text = "Cadastrar_Gerente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCadastrarCliente;
        private System.Windows.Forms.CheckBox epicoCliente;
        private System.Windows.Forms.MaskedTextBox emailCliente;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox cepCliente;
        private System.Windows.Forms.MaskedTextBox enderecoCliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox dataNascCliente;
        private System.Windows.Forms.MaskedTextBox rgCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox cpfCliente;
        private System.Windows.Forms.TextBox nomeCliente;
    }
}