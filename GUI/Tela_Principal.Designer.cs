
namespace Trabalho_II_de_POO_II.GUI
{
    partial class Tela_Principal
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.JogosComprados = new System.Windows.Forms.ListBox();
            this.TabPrincipal = new System.Windows.Forms.TabControl();
            this.tabComprar = new System.Windows.Forms.TabPage();
            this.btnBuscarJogo = new System.Windows.Forms.Button();
            this.CBPrecoJogo = new System.Windows.Forms.ComboBox();
            this.CBTipoJogo = new System.Windows.Forms.ComboBox();
            this.tabCadastrar = new System.Windows.Forms.TabPage();
            this.tabRelatorios = new System.Windows.Forms.TabPage();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.JogosVenda = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.usuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trnasportadoraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.desenvolvedoraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jogoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gerenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Relatorios = new System.Windows.Forms.ListBox();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.desenvolvedorasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maisJogosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maiorLucroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transportadorasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gerentesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesÉpicosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maiorNivelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.boletoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cartãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pixToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.desenvolvedoraToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.todasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.todosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.TabPrincipal.SuspendLayout();
            this.tabComprar.SuspendLayout();
            this.tabCadastrar.SuspendLayout();
            this.tabRelatorios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.JogosComprados);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(156, 449);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // JogosComprados
            // 
            this.JogosComprados.FormattingEnabled = true;
            this.JogosComprados.Location = new System.Drawing.Point(3, 0);
            this.JogosComprados.Name = "JogosComprados";
            this.JogosComprados.Size = new System.Drawing.Size(149, 446);
            this.JogosComprados.TabIndex = 0;
            this.JogosComprados.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // TabPrincipal
            // 
            this.TabPrincipal.Controls.Add(this.tabComprar);
            this.TabPrincipal.Controls.Add(this.tabCadastrar);
            this.TabPrincipal.Controls.Add(this.tabRelatorios);
            this.TabPrincipal.Location = new System.Drawing.Point(158, 1);
            this.TabPrincipal.Name = "TabPrincipal";
            this.TabPrincipal.SelectedIndex = 0;
            this.TabPrincipal.Size = new System.Drawing.Size(643, 449);
            this.TabPrincipal.TabIndex = 1;
            // 
            // tabComprar
            // 
            this.tabComprar.Controls.Add(this.JogosVenda);
            this.tabComprar.Controls.Add(this.btnBuscarJogo);
            this.tabComprar.Controls.Add(this.CBPrecoJogo);
            this.tabComprar.Controls.Add(this.CBTipoJogo);
            this.tabComprar.Location = new System.Drawing.Point(4, 22);
            this.tabComprar.Name = "tabComprar";
            this.tabComprar.Padding = new System.Windows.Forms.Padding(3);
            this.tabComprar.Size = new System.Drawing.Size(635, 423);
            this.tabComprar.TabIndex = 0;
            this.tabComprar.Text = "Comprar";
            this.tabComprar.UseVisualStyleBackColor = true;
            this.tabComprar.Click += new System.EventHandler(this.TabComprar_Click);
            // 
            // btnBuscarJogo
            // 
            this.btnBuscarJogo.Location = new System.Drawing.Point(260, 6);
            this.btnBuscarJogo.Name = "btnBuscarJogo";
            this.btnBuscarJogo.Size = new System.Drawing.Size(66, 23);
            this.btnBuscarJogo.TabIndex = 2;
            this.btnBuscarJogo.Text = "Buscar";
            this.btnBuscarJogo.UseVisualStyleBackColor = true;
            // 
            // CBPrecoJogo
            // 
            this.CBPrecoJogo.FormattingEnabled = true;
            this.CBPrecoJogo.Items.AddRange(new object[] {
            "Todos",
            "Mais Caros",
            "Mais Baratos"});
            this.CBPrecoJogo.Location = new System.Drawing.Point(133, 6);
            this.CBPrecoJogo.Name = "CBPrecoJogo";
            this.CBPrecoJogo.Size = new System.Drawing.Size(112, 21);
            this.CBPrecoJogo.TabIndex = 1;
            this.CBPrecoJogo.Text = "Todos";
            this.CBPrecoJogo.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // CBTipoJogo
            // 
            this.CBTipoJogo.FormattingEnabled = true;
            this.CBTipoJogo.Items.AddRange(new object[] {
            "Todos",
            "Ação",
            "Aventura",
            "RPG",
            "Esporte",
            "Corrida"});
            this.CBTipoJogo.Location = new System.Drawing.Point(6, 6);
            this.CBTipoJogo.Name = "CBTipoJogo";
            this.CBTipoJogo.Size = new System.Drawing.Size(107, 21);
            this.CBTipoJogo.TabIndex = 0;
            this.CBTipoJogo.Text = "Todos";
            this.CBTipoJogo.SelectedIndexChanged += new System.EventHandler(this.CBTipoJogo_SelectedIndexChanged);
            // 
            // tabCadastrar
            // 
            this.tabCadastrar.Controls.Add(this.menuStrip1);
            this.tabCadastrar.Location = new System.Drawing.Point(4, 22);
            this.tabCadastrar.Name = "tabCadastrar";
            this.tabCadastrar.Padding = new System.Windows.Forms.Padding(3);
            this.tabCadastrar.Size = new System.Drawing.Size(635, 423);
            this.tabCadastrar.TabIndex = 1;
            this.tabCadastrar.Text = "Cadastrar";
            this.tabCadastrar.UseVisualStyleBackColor = true;
            // 
            // tabRelatorios
            // 
            this.tabRelatorios.Controls.Add(this.Relatorios);
            this.tabRelatorios.Controls.Add(this.menuStrip2);
            this.tabRelatorios.Location = new System.Drawing.Point(4, 22);
            this.tabRelatorios.Name = "tabRelatorios";
            this.tabRelatorios.Padding = new System.Windows.Forms.Padding(3);
            this.tabRelatorios.Size = new System.Drawing.Size(635, 423);
            this.tabRelatorios.TabIndex = 2;
            this.tabRelatorios.Text = "Relatorios";
            this.tabRelatorios.UseVisualStyleBackColor = true;
            this.tabRelatorios.Click += new System.EventHandler(this.tabRelatorios_Click);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            this.fileSystemWatcher1.Changed += new System.IO.FileSystemEventHandler(this.fileSystemWatcher1_Changed);
            // 
            // JogosVenda
            // 
            this.JogosVenda.FormattingEnabled = true;
            this.JogosVenda.Location = new System.Drawing.Point(0, 34);
            this.JogosVenda.Name = "JogosVenda";
            this.JogosVenda.Size = new System.Drawing.Size(635, 381);
            this.JogosVenda.TabIndex = 3;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuarioToolStripMenuItem,
            this.trnasportadoraToolStripMenuItem,
            this.desenvolvedoraToolStripMenuItem,
            this.jogoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(3, 3);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(629, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // usuarioToolStripMenuItem
            // 
            this.usuarioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gerenteToolStripMenuItem,
            this.clienteToolStripMenuItem});
            this.usuarioToolStripMenuItem.Name = "usuarioToolStripMenuItem";
            this.usuarioToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.usuarioToolStripMenuItem.Text = "Usuario";
            // 
            // trnasportadoraToolStripMenuItem
            // 
            this.trnasportadoraToolStripMenuItem.Name = "trnasportadoraToolStripMenuItem";
            this.trnasportadoraToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.trnasportadoraToolStripMenuItem.Text = "Trnasportadora";
            // 
            // desenvolvedoraToolStripMenuItem
            // 
            this.desenvolvedoraToolStripMenuItem.Name = "desenvolvedoraToolStripMenuItem";
            this.desenvolvedoraToolStripMenuItem.Size = new System.Drawing.Size(103, 20);
            this.desenvolvedoraToolStripMenuItem.Text = "Desenvolvedora";
            // 
            // jogoToolStripMenuItem
            // 
            this.jogoToolStripMenuItem.Name = "jogoToolStripMenuItem";
            this.jogoToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.jogoToolStripMenuItem.Text = "Jogo";
            // 
            // gerenteToolStripMenuItem
            // 
            this.gerenteToolStripMenuItem.Name = "gerenteToolStripMenuItem";
            this.gerenteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.gerenteToolStripMenuItem.Text = "Gerente";
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.clienteToolStripMenuItem.Text = "Cliente";
            // 
            // Relatorios
            // 
            this.Relatorios.FormattingEnabled = true;
            this.Relatorios.Location = new System.Drawing.Point(1, 108);
            this.Relatorios.Name = "Relatorios";
            this.Relatorios.Size = new System.Drawing.Size(595, 316);
            this.Relatorios.TabIndex = 0;
            this.Relatorios.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged_1);
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.desenvolvedorasToolStripMenuItem,
            this.transportadorasToolStripMenuItem,
            this.gerentesToolStripMenuItem,
            this.clientesToolStripMenuItem,
            this.vendasToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(3, 3);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(629, 24);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // desenvolvedorasToolStripMenuItem
            // 
            this.desenvolvedorasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.todasToolStripMenuItem,
            this.maisJogosToolStripMenuItem,
            this.maiorLucroToolStripMenuItem});
            this.desenvolvedorasToolStripMenuItem.Name = "desenvolvedorasToolStripMenuItem";
            this.desenvolvedorasToolStripMenuItem.Size = new System.Drawing.Size(108, 20);
            this.desenvolvedorasToolStripMenuItem.Text = "Desenvolvedoras";
            // 
            // maisJogosToolStripMenuItem
            // 
            this.maisJogosToolStripMenuItem.Name = "maisJogosToolStripMenuItem";
            this.maisJogosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.maisJogosToolStripMenuItem.Text = "Mais Jogos";
            // 
            // maiorLucroToolStripMenuItem
            // 
            this.maiorLucroToolStripMenuItem.Name = "maiorLucroToolStripMenuItem";
            this.maiorLucroToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.maiorLucroToolStripMenuItem.Text = "Maior Lucro";
            // 
            // transportadorasToolStripMenuItem
            // 
            this.transportadorasToolStripMenuItem.Name = "transportadorasToolStripMenuItem";
            this.transportadorasToolStripMenuItem.Size = new System.Drawing.Size(103, 20);
            this.transportadorasToolStripMenuItem.Text = "Transportadoras";
            this.transportadorasToolStripMenuItem.Click += new System.EventHandler(this.transportadorasToolStripMenuItem_Click);
            // 
            // gerentesToolStripMenuItem
            // 
            this.gerentesToolStripMenuItem.Name = "gerentesToolStripMenuItem";
            this.gerentesToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.gerentesToolStripMenuItem.Text = "Gerentes";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.todosToolStripMenuItem,
            this.clientesÉpicosToolStripMenuItem,
            this.maiorNivelToolStripMenuItem});
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.clientesToolStripMenuItem.Text = "Clientes";
            // 
            // clientesÉpicosToolStripMenuItem
            // 
            this.clientesÉpicosToolStripMenuItem.Name = "clientesÉpicosToolStripMenuItem";
            this.clientesÉpicosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.clientesÉpicosToolStripMenuItem.Text = "Clientes Épicos";
            // 
            // vendasToolStripMenuItem
            // 
            this.vendasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.desenvolvedoraToolStripMenuItem1,
            this.clienteToolStripMenuItem1,
            this.boletoToolStripMenuItem,
            this.cartãoToolStripMenuItem,
            this.pixToolStripMenuItem});
            this.vendasToolStripMenuItem.Name = "vendasToolStripMenuItem";
            this.vendasToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.vendasToolStripMenuItem.Text = "Vendas";
            this.vendasToolStripMenuItem.Click += new System.EventHandler(this.vendasToolStripMenuItem_Click);
            // 
            // maiorNivelToolStripMenuItem
            // 
            this.maiorNivelToolStripMenuItem.Name = "maiorNivelToolStripMenuItem";
            this.maiorNivelToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.maiorNivelToolStripMenuItem.Text = "Maior Nivel";
            // 
            // boletoToolStripMenuItem
            // 
            this.boletoToolStripMenuItem.Name = "boletoToolStripMenuItem";
            this.boletoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.boletoToolStripMenuItem.Text = "Boleto";
            // 
            // cartãoToolStripMenuItem
            // 
            this.cartãoToolStripMenuItem.Name = "cartãoToolStripMenuItem";
            this.cartãoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cartãoToolStripMenuItem.Text = "Cartão";
            // 
            // pixToolStripMenuItem
            // 
            this.pixToolStripMenuItem.Name = "pixToolStripMenuItem";
            this.pixToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pixToolStripMenuItem.Text = "Pix";
            // 
            // desenvolvedoraToolStripMenuItem1
            // 
            this.desenvolvedoraToolStripMenuItem1.Name = "desenvolvedoraToolStripMenuItem1";
            this.desenvolvedoraToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.desenvolvedoraToolStripMenuItem1.Text = "Desenvolvedora";
            this.desenvolvedoraToolStripMenuItem1.Click += new System.EventHandler(this.desenvolvedoraToolStripMenuItem1_Click);
            // 
            // clienteToolStripMenuItem1
            // 
            this.clienteToolStripMenuItem1.Name = "clienteToolStripMenuItem1";
            this.clienteToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.clienteToolStripMenuItem1.Text = "Cliente";
            this.clienteToolStripMenuItem1.Click += new System.EventHandler(this.clienteToolStripMenuItem1_Click);
            // 
            // todasToolStripMenuItem
            // 
            this.todasToolStripMenuItem.Name = "todasToolStripMenuItem";
            this.todasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.todasToolStripMenuItem.Text = "Todas";
            // 
            // todosToolStripMenuItem
            // 
            this.todosToolStripMenuItem.Name = "todosToolStripMenuItem";
            this.todosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.todosToolStripMenuItem.Text = "Todos";
            // 
            // Tela_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TabPrincipal);
            this.Controls.Add(this.panel1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Tela_Principal";
            this.Text = "Teste";
            this.panel1.ResumeLayout(false);
            this.TabPrincipal.ResumeLayout(false);
            this.tabComprar.ResumeLayout(false);
            this.tabCadastrar.ResumeLayout(false);
            this.tabCadastrar.PerformLayout();
            this.tabRelatorios.ResumeLayout(false);
            this.tabRelatorios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl TabPrincipal;
        private System.Windows.Forms.TabPage tabComprar;
        private System.Windows.Forms.TabPage tabCadastrar;
        private System.Windows.Forms.TabPage tabRelatorios;
        private System.Windows.Forms.ListBox JogosComprados;
        private System.Windows.Forms.Button btnBuscarJogo;
        private System.Windows.Forms.ComboBox CBPrecoJogo;
        private System.Windows.Forms.ComboBox CBTipoJogo;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.ListBox JogosVenda;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem usuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gerenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trnasportadoraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem desenvolvedoraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jogoToolStripMenuItem;
        private System.Windows.Forms.ListBox Relatorios;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem desenvolvedorasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maisJogosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maiorLucroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transportadorasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gerentesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesÉpicosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maiorNivelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem boletoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cartãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pixToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem desenvolvedoraToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem todasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem todosToolStripMenuItem;
    }
}