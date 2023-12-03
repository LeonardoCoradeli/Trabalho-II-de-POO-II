namespace Trabalho_II_de_POO_II.GUI
{
    partial class Cadastrar_Transportadora
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
            this.cnpjTransportadora = new System.Windows.Forms.MaskedTextBox();
            this.btnCadastrarDesenvolvedora = new System.Windows.Forms.Button();
            this.tempoEntrega = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.enderecoTransportadora = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.telefoneTransportadora = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.emailTransportadora = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nomeTransportadora = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cnpjTransportadora
            // 
            this.cnpjTransportadora.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cnpjTransportadora.Location = new System.Drawing.Point(59, 40);
            this.cnpjTransportadora.Mask = "00.000.000/0001-00";
            this.cnpjTransportadora.Name = "cnpjTransportadora";
            this.cnpjTransportadora.Size = new System.Drawing.Size(166, 22);
            this.cnpjTransportadora.TabIndex = 26;
            // 
            // btnCadastrarDesenvolvedora
            // 
            this.btnCadastrarDesenvolvedora.Location = new System.Drawing.Point(201, 122);
            this.btnCadastrarDesenvolvedora.Name = "btnCadastrarDesenvolvedora";
            this.btnCadastrarDesenvolvedora.Size = new System.Drawing.Size(84, 28);
            this.btnCadastrarDesenvolvedora.TabIndex = 25;
            this.btnCadastrarDesenvolvedora.Text = "Cadastrar";
            this.btnCadastrarDesenvolvedora.UseVisualStyleBackColor = true;
            this.btnCadastrarDesenvolvedora.Click += new System.EventHandler(this.btnCadastrarDesenvolvedora_Click);
            // 
            // tempoEntrega
            // 
            this.tempoEntrega.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tempoEntrega.Location = new System.Drawing.Point(325, 68);
            this.tempoEntrega.Name = "tempoEntrega";
            this.tempoEntrega.Size = new System.Drawing.Size(166, 22);
            this.tempoEntrega.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(235, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 16);
            this.label6.TabIndex = 23;
            this.label6.Text = "Entrega:";
            // 
            // enderecoTransportadora
            // 
            this.enderecoTransportadora.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enderecoTransportadora.Location = new System.Drawing.Point(325, 40);
            this.enderecoTransportadora.Name = "enderecoTransportadora";
            this.enderecoTransportadora.Size = new System.Drawing.Size(166, 22);
            this.enderecoTransportadora.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(235, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 16);
            this.label5.TabIndex = 21;
            this.label5.Text = "Endereço:";
            // 
            // telefoneTransportadora
            // 
            this.telefoneTransportadora.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telefoneTransportadora.Location = new System.Drawing.Point(325, 12);
            this.telefoneTransportadora.Name = "telefoneTransportadora";
            this.telefoneTransportadora.Size = new System.Drawing.Size(166, 22);
            this.telefoneTransportadora.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(235, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 16);
            this.label4.TabIndex = 19;
            this.label4.Text = "Telefone:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // emailTransportadora
            // 
            this.emailTransportadora.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTransportadora.Location = new System.Drawing.Point(59, 68);
            this.emailTransportadora.Name = "emailTransportadora";
            this.emailTransportadora.Size = new System.Drawing.Size(166, 22);
            this.emailTransportadora.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "Email:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "CNPJ:";
            // 
            // nomeTransportadora
            // 
            this.nomeTransportadora.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeTransportadora.Location = new System.Drawing.Point(59, 12);
            this.nomeTransportadora.Name = "nomeTransportadora";
            this.nomeTransportadora.Size = new System.Drawing.Size(166, 22);
            this.nomeTransportadora.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "Nome";
            // 
            // Cadastrar_Transportadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 167);
            this.Controls.Add(this.cnpjTransportadora);
            this.Controls.Add(this.btnCadastrarDesenvolvedora);
            this.Controls.Add(this.tempoEntrega);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.enderecoTransportadora);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.telefoneTransportadora);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.emailTransportadora);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nomeTransportadora);
            this.Controls.Add(this.label1);
            this.Name = "Cadastrar_Transportadora";
            this.Text = "Cadastrar_Transportadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox cnpjTransportadora;
        private System.Windows.Forms.Button btnCadastrarDesenvolvedora;
        private System.Windows.Forms.TextBox tempoEntrega;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox enderecoTransportadora;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox telefoneTransportadora;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox emailTransportadora;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nomeTransportadora;
        private System.Windows.Forms.Label label1;
    }
}