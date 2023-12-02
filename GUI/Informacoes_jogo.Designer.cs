
namespace Trabalho_II_de_POO_II.GUI
{
    partial class Informacoes_jogo
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
            this.Desenvolvedora = new System.Windows.Forms.GroupBox();
            this.nomeDesenvolvedora = new System.Windows.Forms.TextBox();
            this.codigoDesenvolvedora = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.codigoJogo = new System.Windows.Forms.TextBox();
            this.nomeJogo = new System.Windows.Forms.TextBox();
            this.descricaoJogo = new System.Windows.Forms.TextBox();
            this.avaliacaoJogo = new System.Windows.Forms.TextBox();
            this.dataLancamentoJogo = new System.Windows.Forms.TextBox();
            this.tipoJogo = new System.Windows.Forms.TextBox();
            this.requisitosJogo = new System.Windows.Forms.TextBox();
            this.comentariosJogo = new System.Windows.Forms.TextBox();
            this.Avaliação = new System.Windows.Forms.GroupBox();
            this.btnAvaliarJogo = new System.Windows.Forms.Button();
            this.avaliarJogo = new System.Windows.Forms.TrackBar();
            this.Desenvolvedora.SuspendLayout();
            this.Avaliação.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avaliarJogo)).BeginInit();
            this.SuspendLayout();
            // 
            // Desenvolvedora
            // 
            this.Desenvolvedora.Controls.Add(this.nomeDesenvolvedora);
            this.Desenvolvedora.Controls.Add(this.codigoDesenvolvedora);
            this.Desenvolvedora.Controls.Add(this.label6);
            this.Desenvolvedora.Controls.Add(this.label7);
            this.Desenvolvedora.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Desenvolvedora.Location = new System.Drawing.Point(394, 91);
            this.Desenvolvedora.Name = "Desenvolvedora";
            this.Desenvolvedora.Size = new System.Drawing.Size(360, 78);
            this.Desenvolvedora.TabIndex = 0;
            this.Desenvolvedora.TabStop = false;
            this.Desenvolvedora.Text = "Desenvolvedora";
            // 
            // nomeDesenvolvedora
            // 
            this.nomeDesenvolvedora.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeDesenvolvedora.Location = new System.Drawing.Point(170, 31);
            this.nomeDesenvolvedora.Name = "nomeDesenvolvedora";
            this.nomeDesenvolvedora.ReadOnly = true;
            this.nomeDesenvolvedora.Size = new System.Drawing.Size(184, 22);
            this.nomeDesenvolvedora.TabIndex = 26;
            // 
            // codigoDesenvolvedora
            // 
            this.codigoDesenvolvedora.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codigoDesenvolvedora.Location = new System.Drawing.Point(69, 31);
            this.codigoDesenvolvedora.Name = "codigoDesenvolvedora";
            this.codigoDesenvolvedora.ReadOnly = true;
            this.codigoDesenvolvedora.Size = new System.Drawing.Size(25, 22);
            this.codigoDesenvolvedora.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "Código:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(113, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 16);
            this.label7.TabIndex = 7;
            this.label7.Text = "Nome: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(104, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome: ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Código:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(402, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Descrição: ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(12, 59);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(139, 16);
            this.label11.TabIndex = 7;
            this.label11.Text = "Data de Lançamento: ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(12, 91);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(128, 16);
            this.label13.TabIndex = 9;
            this.label13.Text = "Requisitos Mínimos:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(377, 59);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(72, 16);
            this.label15.TabIndex = 11;
            this.label15.Text = "Avaliação:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(207, 91);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(87, 16);
            this.label17.TabIndex = 13;
            this.label17.Text = "Comentários:";
            this.label17.Click += new System.EventHandler(this.label17_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(255, 59);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(39, 16);
            this.label19.TabIndex = 15;
            this.label19.Text = "Tipo:";
            // 
            // codigoJogo
            // 
            this.codigoJogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codigoJogo.Location = new System.Drawing.Point(73, 22);
            this.codigoJogo.Name = "codigoJogo";
            this.codigoJogo.ReadOnly = true;
            this.codigoJogo.Size = new System.Drawing.Size(25, 22);
            this.codigoJogo.TabIndex = 17;
            this.codigoJogo.TextChanged += new System.EventHandler(this.codigoJogo_TextChanged);
            // 
            // nomeJogo
            // 
            this.nomeJogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeJogo.Location = new System.Drawing.Point(161, 22);
            this.nomeJogo.Name = "nomeJogo";
            this.nomeJogo.ReadOnly = true;
            this.nomeJogo.Size = new System.Drawing.Size(229, 22);
            this.nomeJogo.TabIndex = 18;
            // 
            // descricaoJogo
            // 
            this.descricaoJogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descricaoJogo.Location = new System.Drawing.Point(484, 22);
            this.descricaoJogo.Multiline = true;
            this.descricaoJogo.Name = "descricaoJogo";
            this.descricaoJogo.ReadOnly = true;
            this.descricaoJogo.Size = new System.Drawing.Size(270, 56);
            this.descricaoJogo.TabIndex = 19;
            this.descricaoJogo.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // avaliacaoJogo
            // 
            this.avaliacaoJogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.avaliacaoJogo.Location = new System.Drawing.Point(453, 56);
            this.avaliacaoJogo.Name = "avaliacaoJogo";
            this.avaliacaoJogo.ReadOnly = true;
            this.avaliacaoJogo.Size = new System.Drawing.Size(25, 22);
            this.avaliacaoJogo.TabIndex = 20;
            // 
            // dataLancamentoJogo
            // 
            this.dataLancamentoJogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataLancamentoJogo.Location = new System.Drawing.Point(161, 56);
            this.dataLancamentoJogo.Name = "dataLancamentoJogo";
            this.dataLancamentoJogo.ReadOnly = true;
            this.dataLancamentoJogo.Size = new System.Drawing.Size(88, 22);
            this.dataLancamentoJogo.TabIndex = 21;
            // 
            // tipoJogo
            // 
            this.tipoJogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipoJogo.Location = new System.Drawing.Point(300, 56);
            this.tipoJogo.Name = "tipoJogo";
            this.tipoJogo.ReadOnly = true;
            this.tipoJogo.Size = new System.Drawing.Size(71, 22);
            this.tipoJogo.TabIndex = 22;
            // 
            // requisitosJogo
            // 
            this.requisitosJogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.requisitosJogo.Location = new System.Drawing.Point(15, 110);
            this.requisitosJogo.Multiline = true;
            this.requisitosJogo.Name = "requisitosJogo";
            this.requisitosJogo.ReadOnly = true;
            this.requisitosJogo.Size = new System.Drawing.Size(168, 59);
            this.requisitosJogo.TabIndex = 23;
            // 
            // comentariosJogo
            // 
            this.comentariosJogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comentariosJogo.Location = new System.Drawing.Point(210, 110);
            this.comentariosJogo.Multiline = true;
            this.comentariosJogo.Name = "comentariosJogo";
            this.comentariosJogo.ReadOnly = true;
            this.comentariosJogo.Size = new System.Drawing.Size(168, 59);
            this.comentariosJogo.TabIndex = 24;
            // 
            // Avaliação
            // 
            this.Avaliação.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Avaliação.Controls.Add(this.btnAvaliarJogo);
            this.Avaliação.Controls.Add(this.avaliarJogo);
            this.Avaliação.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Avaliação.Location = new System.Drawing.Point(210, 195);
            this.Avaliação.Name = "Avaliação";
            this.Avaliação.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Avaliação.Size = new System.Drawing.Size(327, 100);
            this.Avaliação.TabIndex = 25;
            this.Avaliação.TabStop = false;
            this.Avaliação.Text = "Avaliação";
            // 
            // btnAvaliarJogo
            // 
            this.btnAvaliarJogo.Location = new System.Drawing.Point(242, 48);
            this.btnAvaliarJogo.Name = "btnAvaliarJogo";
            this.btnAvaliarJogo.Size = new System.Drawing.Size(75, 23);
            this.btnAvaliarJogo.TabIndex = 1;
            this.btnAvaliarJogo.Text = "Avaliar";
            this.btnAvaliarJogo.UseVisualStyleBackColor = true;
            this.btnAvaliarJogo.Click += new System.EventHandler(this.btnAvaliarJogo_Click);
            // 
            // avaliarJogo
            // 
            this.avaliarJogo.Location = new System.Drawing.Point(10, 38);
            this.avaliarJogo.Name = "avaliarJogo";
            this.avaliarJogo.Size = new System.Drawing.Size(207, 45);
            this.avaliarJogo.TabIndex = 0;
            // 
            // Informacoes_jogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 307);
            this.Controls.Add(this.Avaliação);
            this.Controls.Add(this.comentariosJogo);
            this.Controls.Add(this.requisitosJogo);
            this.Controls.Add(this.tipoJogo);
            this.Controls.Add(this.dataLancamentoJogo);
            this.Controls.Add(this.avaliacaoJogo);
            this.Controls.Add(this.descricaoJogo);
            this.Controls.Add(this.nomeJogo);
            this.Controls.Add(this.codigoJogo);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Desenvolvedora);
            this.Name = "Informacoes_jogo";
            this.Text = "Informacoes jogo";
            this.TopMost = true;
            this.Desenvolvedora.ResumeLayout(false);
            this.Desenvolvedora.PerformLayout();
            this.Avaliação.ResumeLayout(false);
            this.Avaliação.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avaliarJogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox Desenvolvedora;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox codigoJogo;
        private System.Windows.Forms.TextBox nomeJogo;
        private System.Windows.Forms.TextBox descricaoJogo;
        private System.Windows.Forms.TextBox avaliacaoJogo;
        private System.Windows.Forms.TextBox dataLancamentoJogo;
        private System.Windows.Forms.TextBox tipoJogo;
        private System.Windows.Forms.TextBox nomeDesenvolvedora;
        private System.Windows.Forms.TextBox codigoDesenvolvedora;
        private System.Windows.Forms.TextBox requisitosJogo;
        private System.Windows.Forms.TextBox comentariosJogo;
        private System.Windows.Forms.GroupBox Avaliação;
        private System.Windows.Forms.Button btnAvaliarJogo;
        private System.Windows.Forms.TrackBar avaliarJogo;
    }
}