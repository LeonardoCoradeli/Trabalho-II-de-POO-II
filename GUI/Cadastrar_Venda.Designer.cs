﻿namespace Trabalho_II_de_POO_II.GUI
{
    partial class Cadastrar_Venda
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
            this.label1 = new System.Windows.Forms.Label();
            this.ClienteLabel = new System.Windows.Forms.Label();
            this.CCliente = new System.Windows.Forms.ComboBox();
            this.CGerente = new System.Windows.Forms.ComboBox();
            this.GerenteLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.FisicoCheckBox = new System.Windows.Forms.CheckBox();
            this.CJogos = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BAdicionar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.Tquantidade = new System.Windows.Forms.TextBox();
            this.LabelTransportadora = new System.Windows.Forms.Label();
            this.CTransportadora = new System.Windows.Forms.ComboBox();
            this.DTLabel = new System.Windows.Forms.Label();
            this.EntregaDT = new System.Windows.Forms.DateTimePicker();
            this.PainelJogo = new System.Windows.Forms.FlowLayoutPanel();
            this.BFinalizar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.TotalLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.TNumeroC = new System.Windows.Forms.TextBox();
            this.TBandeira = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cliente:";
            // 
            // ClienteLabel
            // 
            this.ClienteLabel.AutoSize = true;
            this.ClienteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClienteLabel.Location = new System.Drawing.Point(259, 13);
            this.ClienteLabel.Name = "ClienteLabel";
            this.ClienteLabel.Size = new System.Drawing.Size(0, 16);
            this.ClienteLabel.TabIndex = 2;
            // 
            // CCliente
            // 
            this.CCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CCliente.FormattingEnabled = true;
            this.CCliente.Location = new System.Drawing.Point(103, 10);
            this.CCliente.Name = "CCliente";
            this.CCliente.Size = new System.Drawing.Size(121, 24);
            this.CCliente.TabIndex = 3;
            this.CCliente.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // CGerente
            // 
            this.CGerente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CGerente.FormattingEnabled = true;
            this.CGerente.Location = new System.Drawing.Point(103, 40);
            this.CGerente.Name = "CGerente";
            this.CGerente.Size = new System.Drawing.Size(121, 24);
            this.CGerente.TabIndex = 6;
            this.CGerente.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // GerenteLabel
            // 
            this.GerenteLabel.AutoSize = true;
            this.GerenteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GerenteLabel.Location = new System.Drawing.Point(259, 43);
            this.GerenteLabel.Name = "GerenteLabel";
            this.GerenteLabel.Size = new System.Drawing.Size(0, 16);
            this.GerenteLabel.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Gerente:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "Data:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(103, 75);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(121, 22);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // FisicoCheckBox
            // 
            this.FisicoCheckBox.AutoSize = true;
            this.FisicoCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FisicoCheckBox.Location = new System.Drawing.Point(293, 64);
            this.FisicoCheckBox.Name = "FisicoCheckBox";
            this.FisicoCheckBox.Size = new System.Drawing.Size(69, 20);
            this.FisicoCheckBox.TabIndex = 9;
            this.FisicoCheckBox.Text = "Fisico?";
            this.FisicoCheckBox.UseVisualStyleBackColor = true;
            this.FisicoCheckBox.CheckedChanged += new System.EventHandler(this.FisicoCheckBox_CheckedChanged_1);
            // 
            // CJogos
            // 
            this.CJogos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CJogos.FormattingEnabled = true;
            this.CJogos.Location = new System.Drawing.Point(60, 19);
            this.CJogos.Name = "CJogos";
            this.CJogos.Size = new System.Drawing.Size(121, 24);
            this.CJogos.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(13, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 16);
            this.label7.TabIndex = 10;
            this.label7.Text = "Jogo:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // comboBox4
            // 
            this.comboBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "Boleto",
            "Pix",
            "Cartão de Credito"});
            this.comboBox4.Location = new System.Drawing.Point(103, 113);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(121, 24);
            this.comboBox4.TabIndex = 14;
            this.comboBox4.SelectedIndexChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Pagamento: ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BAdicionar);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.Tquantidade);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.CJogos);
            this.groupBox1.Controls.Add(this.FisicoCheckBox);
            this.groupBox1.Location = new System.Drawing.Point(16, 189);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(410, 118);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Itens Vendidos";
            // 
            // BAdicionar
            // 
            this.BAdicionar.Location = new System.Drawing.Point(158, 89);
            this.BAdicionar.Name = "BAdicionar";
            this.BAdicionar.Size = new System.Drawing.Size(75, 23);
            this.BAdicionar.TabIndex = 15;
            this.BAdicionar.Text = "Adicionar";
            this.BAdicionar.UseVisualStyleBackColor = true;
            this.BAdicionar.Click += new System.EventHandler(this.BAdicionar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(207, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 16);
            this.label8.TabIndex = 14;
            this.label8.Text = "Quantidade:";
            // 
            // Tquantidade
            // 
            this.Tquantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tquantidade.Location = new System.Drawing.Point(293, 19);
            this.Tquantidade.Name = "Tquantidade";
            this.Tquantidade.Size = new System.Drawing.Size(100, 22);
            this.Tquantidade.TabIndex = 13;
            // 
            // LabelTransportadora
            // 
            this.LabelTransportadora.AutoSize = true;
            this.LabelTransportadora.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTransportadora.Location = new System.Drawing.Point(358, 13);
            this.LabelTransportadora.Name = "LabelTransportadora";
            this.LabelTransportadora.Size = new System.Drawing.Size(104, 16);
            this.LabelTransportadora.TabIndex = 16;
            this.LabelTransportadora.Text = "Transportadora:";
            this.LabelTransportadora.Visible = false;
            // 
            // CTransportadora
            // 
            this.CTransportadora.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CTransportadora.FormattingEnabled = true;
            this.CTransportadora.Location = new System.Drawing.Point(468, 10);
            this.CTransportadora.Name = "CTransportadora";
            this.CTransportadora.Size = new System.Drawing.Size(121, 24);
            this.CTransportadora.TabIndex = 17;
            this.CTransportadora.Visible = false;
            this.CTransportadora.SelectedIndexChanged += new System.EventHandler(this.CTransportadora_SelectedIndexChanged);
            // 
            // DTLabel
            // 
            this.DTLabel.AutoSize = true;
            this.DTLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTLabel.Location = new System.Drawing.Point(358, 59);
            this.DTLabel.Name = "DTLabel";
            this.DTLabel.Size = new System.Drawing.Size(107, 16);
            this.DTLabel.TabIndex = 18;
            this.DTLabel.Text = "Data de entrega:";
            this.DTLabel.Visible = false;
            // 
            // EntregaDT
            // 
            this.EntregaDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.EntregaDT.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.EntregaDT.Location = new System.Drawing.Point(468, 59);
            this.EntregaDT.Name = "EntregaDT";
            this.EntregaDT.Size = new System.Drawing.Size(121, 23);
            this.EntregaDT.TabIndex = 19;
            this.EntregaDT.Visible = false;
            // 
            // PainelJogo
            // 
            this.PainelJogo.AutoSize = true;
            this.PainelJogo.Location = new System.Drawing.Point(16, 313);
            this.PainelJogo.Name = "PainelJogo";
            this.PainelJogo.Size = new System.Drawing.Size(597, 125);
            this.PainelJogo.TabIndex = 20;
            // 
            // BFinalizar
            // 
            this.BFinalizar.AutoSize = true;
            this.BFinalizar.Location = new System.Drawing.Point(522, 459);
            this.BFinalizar.Name = "BFinalizar";
            this.BFinalizar.Size = new System.Drawing.Size(91, 23);
            this.BFinalizar.TabIndex = 21;
            this.BFinalizar.Text = "FinalizarCompra";
            this.BFinalizar.UseVisualStyleBackColor = true;
            this.BFinalizar.Click += new System.EventHandler(this.BFinalizar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 464);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Total da Compra:";
            // 
            // TotalLabel
            // 
            this.TotalLabel.AutoSize = true;
            this.TotalLabel.Location = new System.Drawing.Point(100, 464);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(16, 13);
            this.TotalLabel.TabIndex = 23;
            this.TotalLabel.Text = "...";
            this.TotalLabel.Click += new System.EventHandler(this.label3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(645, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 17);
            this.label3.TabIndex = 25;
            this.label3.Text = "Numero Cartão:";
            this.label3.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label9.Location = new System.Drawing.Point(645, 17);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 17);
            this.label9.TabIndex = 26;
            this.label9.Text = "Bandeira:";
            this.label9.Visible = false;
            // 
            // TNumeroC
            // 
            this.TNumeroC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.TNumeroC.Location = new System.Drawing.Point(785, 59);
            this.TNumeroC.Name = "TNumeroC";
            this.TNumeroC.Size = new System.Drawing.Size(198, 23);
            this.TNumeroC.TabIndex = 27;
            this.TNumeroC.Visible = false;
            // 
            // TBandeira
            // 
            this.TBandeira.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.TBandeira.Location = new System.Drawing.Point(785, 17);
            this.TBandeira.Name = "TBandeira";
            this.TBandeira.Size = new System.Drawing.Size(198, 23);
            this.TBandeira.TabIndex = 28;
            this.TBandeira.Visible = false;
            // 
            // Cadastrar_Venda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(995, 492);
            this.Controls.Add(this.TBandeira);
            this.Controls.Add(this.TNumeroC);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TotalLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BFinalizar);
            this.Controls.Add(this.PainelJogo);
            this.Controls.Add(this.EntregaDT);
            this.Controls.Add(this.DTLabel);
            this.Controls.Add(this.CTransportadora);
            this.Controls.Add(this.LabelTransportadora);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CGerente);
            this.Controls.Add(this.GerenteLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CCliente);
            this.Controls.Add(this.ClienteLabel);
            this.Controls.Add(this.label1);
            this.Name = "Cadastrar_Venda";
            this.Text = "Venda";
            this.Load += new System.EventHandler(this.Cadastrar_Venda_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ClienteLabel;
        private System.Windows.Forms.ComboBox CCliente;
        private System.Windows.Forms.ComboBox CGerente;
        private System.Windows.Forms.Label GerenteLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.CheckBox FisicoCheckBox;
        private System.Windows.Forms.ComboBox CJogos;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BAdicionar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Tquantidade;
        private System.Windows.Forms.Label LabelTransportadora;
        private System.Windows.Forms.ComboBox CTransportadora;
        private System.Windows.Forms.Label DTLabel;
        private System.Windows.Forms.DateTimePicker EntregaDT;
        private System.Windows.Forms.FlowLayoutPanel PainelJogo;
        private System.Windows.Forms.Button BFinalizar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label TotalLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TNumeroC;
        private System.Windows.Forms.TextBox TBandeira;
    }
}