
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
            this.emailGerente = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cepGerente = new System.Windows.Forms.MaskedTextBox();
            this.enderecoGerente = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rgGerente = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cpfGerente = new System.Windows.Forms.MaskedTextBox();
            this.nomeGerente = new System.Windows.Forms.TextBox();
            this.pisGerente = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dataNascGerente = new System.Windows.Forms.DateTimePicker();
            this.salarioGerente = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCadastrarCliente
            // 
            this.btnCadastrarCliente.Location = new System.Drawing.Point(234, 180);
            this.btnCadastrarCliente.Name = "btnCadastrarCliente";
            this.btnCadastrarCliente.Size = new System.Drawing.Size(94, 37);
            this.btnCadastrarCliente.TabIndex = 36;
            this.btnCadastrarCliente.Text = "Cadastrar";
            this.btnCadastrarCliente.UseVisualStyleBackColor = true;
            this.btnCadastrarCliente.Click += new System.EventHandler(this.btnCadastrarCliente_Click);
            // 
            // emailGerente
            // 
            this.emailGerente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailGerente.Location = new System.Drawing.Point(402, 31);
            this.emailGerente.Name = "emailGerente";
            this.emailGerente.Size = new System.Drawing.Size(166, 22);
            this.emailGerente.TabIndex = 34;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(326, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 16);
            this.label8.TabIndex = 33;
            this.label8.Text = "Email:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(326, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 16);
            this.label9.TabIndex = 32;
            this.label9.Text = "CEP:";
            // 
            // cepGerente
            // 
            this.cepGerente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cepGerente.Location = new System.Drawing.Point(402, 3);
            this.cepGerente.Mask = "00000-000";
            this.cepGerente.Name = "cepGerente";
            this.cepGerente.Size = new System.Drawing.Size(166, 22);
            this.cepGerente.TabIndex = 31;
            // 
            // enderecoGerente
            // 
            this.enderecoGerente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enderecoGerente.Location = new System.Drawing.Point(402, 65);
            this.enderecoGerente.Name = "enderecoGerente";
            this.enderecoGerente.Size = new System.Drawing.Size(166, 22);
            this.enderecoGerente.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(326, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 16);
            this.label4.TabIndex = 29;
            this.label4.Text = "Endereço:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 16);
            this.label5.TabIndex = 28;
            this.label5.Text = "Dada de Nasc:";
            // 
            // rgGerente
            // 
            this.rgGerente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rgGerente.Location = new System.Drawing.Point(117, 62);
            this.rgGerente.Mask = "00.000.000-0";
            this.rgGerente.Name = "rgGerente";
            this.rgGerente.Size = new System.Drawing.Size(166, 22);
            this.rgGerente.TabIndex = 26;
            this.rgGerente.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.rgCliente_MaskInputRejected);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 16);
            this.label3.TabIndex = 25;
            this.label3.Text = "RG:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 16);
            this.label2.TabIndex = 24;
            this.label2.Text = "CPF:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 23;
            this.label1.Text = "Nome:";
            // 
            // cpfGerente
            // 
            this.cpfGerente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpfGerente.Location = new System.Drawing.Point(117, 34);
            this.cpfGerente.Mask = "000.000.000-00";
            this.cpfGerente.Name = "cpfGerente";
            this.cpfGerente.Size = new System.Drawing.Size(166, 22);
            this.cpfGerente.TabIndex = 22;
            // 
            // nomeGerente
            // 
            this.nomeGerente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeGerente.Location = new System.Drawing.Point(117, 6);
            this.nomeGerente.Name = "nomeGerente";
            this.nomeGerente.Size = new System.Drawing.Size(166, 22);
            this.nomeGerente.TabIndex = 21;
            // 
            // pisGerente
            // 
            this.pisGerente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pisGerente.Location = new System.Drawing.Point(402, 93);
            this.pisGerente.Mask = "00.00000.000-00";
            this.pisGerente.Name = "pisGerente";
            this.pisGerente.Size = new System.Drawing.Size(166, 22);
            this.pisGerente.TabIndex = 38;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(326, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 16);
            this.label6.TabIndex = 37;
            this.label6.Text = "PIS:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 127);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 16);
            this.label7.TabIndex = 40;
            this.label7.Text = "Salário:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // dataNascGerente
            // 
            this.dataNascGerente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dataNascGerente.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dataNascGerente.Location = new System.Drawing.Point(117, 93);
            this.dataNascGerente.Name = "dataNascGerente";
            this.dataNascGerente.Size = new System.Drawing.Size(166, 23);
            this.dataNascGerente.TabIndex = 42;
            // 
            // salarioGerente
            // 
            this.salarioGerente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salarioGerente.Location = new System.Drawing.Point(117, 124);
            this.salarioGerente.Name = "salarioGerente";
            this.salarioGerente.Size = new System.Drawing.Size(166, 22);
            this.salarioGerente.TabIndex = 41;
            // 
            // Cadastrar_Gerente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 224);
            this.Controls.Add(this.dataNascGerente);
            this.Controls.Add(this.salarioGerente);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pisGerente);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnCadastrarCliente);
            this.Controls.Add(this.emailGerente);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cepGerente);
            this.Controls.Add(this.enderecoGerente);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.rgGerente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cpfGerente);
            this.Controls.Add(this.nomeGerente);
            this.Name = "Cadastrar_Gerente";
            this.Text = "Cadastrar_Gerente";
            this.Load += new System.EventHandler(this.Cadastrar_Gerente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCadastrarCliente;
        private System.Windows.Forms.MaskedTextBox emailGerente;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox cepGerente;
        private System.Windows.Forms.MaskedTextBox enderecoGerente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox rgGerente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox cpfGerente;
        private System.Windows.Forms.TextBox nomeGerente;
        private System.Windows.Forms.MaskedTextBox pisGerente;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dataNascGerente;
        private System.Windows.Forms.TextBox salarioGerente;
    }
}