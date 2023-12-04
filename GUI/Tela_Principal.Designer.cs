
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
            this.SideBar = new System.Windows.Forms.Panel();
            this.JogosComprados = new System.Windows.Forms.ListView();
            this.chbVisualizacaoJogos = new System.Windows.Forms.CheckBox();
            this.TabPrincipal = new System.Windows.Forms.TabControl();
            this.tabComprar = new System.Windows.Forms.TabPage();
            this.btnComprar = new System.Windows.Forms.Button();
            this.CatalogoJogo = new System.Windows.Forms.FlowLayoutPanel();
            this.CBTipoJogo = new System.Windows.Forms.ComboBox();
            this.tabCadastrar = new System.Windows.Forms.TabPage();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.usuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gerenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transportadoraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.desenvolvedoraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jogoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabRelatorios = new System.Windows.Forms.TabPage();
            this.DTMes = new System.Windows.Forms.DateTimePicker();
            this.Relatorios = new System.Windows.Forms.ListBox();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.desenvolvedorasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.todasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maisJogosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maiorLucroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transportadorasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gerentesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.todosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesÉpicosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maiorNivelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.boletoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cartãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pixToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.todasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mesEspecificoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.desenvolvedoraToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.desenvolvedoraToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.CDesenvolvedora = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CCliente = new System.Windows.Forms.ComboBox();
            this.SideBar.SuspendLayout();
            this.TabPrincipal.SuspendLayout();
            this.tabComprar.SuspendLayout();
            this.tabCadastrar.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.tabRelatorios.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // SideBar
            // 
            this.SideBar.Controls.Add(this.JogosComprados);
            this.SideBar.Controls.Add(this.chbVisualizacaoJogos);
            this.SideBar.Location = new System.Drawing.Point(0, 1);
            this.SideBar.Name = "SideBar";
            this.SideBar.Size = new System.Drawing.Size(156, 604);
            this.SideBar.TabIndex = 0;
            this.SideBar.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // JogosComprados
            // 
            this.JogosComprados.Activation = System.Windows.Forms.ItemActivation.TwoClick;
            this.JogosComprados.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JogosComprados.FullRowSelect = true;
            this.JogosComprados.HideSelection = false;
            this.JogosComprados.Location = new System.Drawing.Point(3, 35);
            this.JogosComprados.MultiSelect = false;
            this.JogosComprados.Name = "JogosComprados";
            this.JogosComprados.Size = new System.Drawing.Size(149, 561);
            this.JogosComprados.TabIndex = 2;
            this.JogosComprados.UseCompatibleStateImageBehavior = false;
            this.JogosComprados.View = System.Windows.Forms.View.List;
            this.JogosComprados.SelectedIndexChanged += new System.EventHandler(this.JogosComprados_SelectedIndexChanged_1);
            // 
            // chbVisualizacaoJogos
            // 
            this.chbVisualizacaoJogos.AutoSize = true;
            this.chbVisualizacaoJogos.Location = new System.Drawing.Point(13, 12);
            this.chbVisualizacaoJogos.Name = "chbVisualizacaoJogos";
            this.chbVisualizacaoJogos.Size = new System.Drawing.Size(59, 17);
            this.chbVisualizacaoJogos.TabIndex = 1;
            this.chbVisualizacaoJogos.Text = "Nomes";
            this.chbVisualizacaoJogos.UseVisualStyleBackColor = true;
            this.chbVisualizacaoJogos.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // TabPrincipal
            // 
            this.TabPrincipal.Controls.Add(this.tabComprar);
            this.TabPrincipal.Controls.Add(this.tabCadastrar);
            this.TabPrincipal.Controls.Add(this.tabRelatorios);
            this.TabPrincipal.Location = new System.Drawing.Point(158, 1);
            this.TabPrincipal.Name = "TabPrincipal";
            this.TabPrincipal.SelectedIndex = 0;
            this.TabPrincipal.Size = new System.Drawing.Size(1070, 608);
            this.TabPrincipal.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.TabPrincipal.TabIndex = 1;
            // 
            // tabComprar
            // 
            this.tabComprar.Controls.Add(this.btnComprar);
            this.tabComprar.Controls.Add(this.CatalogoJogo);
            this.tabComprar.Controls.Add(this.CBTipoJogo);
            this.tabComprar.Location = new System.Drawing.Point(4, 22);
            this.tabComprar.Name = "tabComprar";
            this.tabComprar.Padding = new System.Windows.Forms.Padding(3);
            this.tabComprar.Size = new System.Drawing.Size(1062, 582);
            this.tabComprar.TabIndex = 0;
            this.tabComprar.Text = "Comprar";
            this.tabComprar.UseVisualStyleBackColor = true;
            this.tabComprar.Click += new System.EventHandler(this.TabComprar_Click);
            // 
            // btnComprar
            // 
            this.btnComprar.Location = new System.Drawing.Point(149, 6);
            this.btnComprar.Name = "btnComprar";
            this.btnComprar.Size = new System.Drawing.Size(75, 23);
            this.btnComprar.TabIndex = 4;
            this.btnComprar.Text = "Comprar";
            this.btnComprar.UseVisualStyleBackColor = true;
            this.btnComprar.Click += new System.EventHandler(this.btnComprar_Click);
            // 
            // CatalogoJogo
            // 
            this.CatalogoJogo.Location = new System.Drawing.Point(1, 34);
            this.CatalogoJogo.Name = "CatalogoJogo";
            this.CatalogoJogo.Size = new System.Drawing.Size(1058, 545);
            this.CatalogoJogo.TabIndex = 3;
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
            "Corrida",
            "Mais Caros",
            "Mais baratos"});
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
            this.tabCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabCadastrar.Location = new System.Drawing.Point(4, 22);
            this.tabCadastrar.Name = "tabCadastrar";
            this.tabCadastrar.Padding = new System.Windows.Forms.Padding(3);
            this.tabCadastrar.Size = new System.Drawing.Size(1062, 582);
            this.tabCadastrar.TabIndex = 1;
            this.tabCadastrar.Text = "Cadastrar";
            this.tabCadastrar.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuarioToolStripMenuItem,
            this.transportadoraToolStripMenuItem,
            this.desenvolvedoraToolStripMenuItem,
            this.jogoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(3, 3);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1056, 24);
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
            // gerenteToolStripMenuItem
            // 
            this.gerenteToolStripMenuItem.Name = "gerenteToolStripMenuItem";
            this.gerenteToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.gerenteToolStripMenuItem.Text = "Gerente";
            this.gerenteToolStripMenuItem.Click += new System.EventHandler(this.gerenteToolStripMenuItem_Click);
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.clienteToolStripMenuItem.Text = "Cliente";
            this.clienteToolStripMenuItem.Click += new System.EventHandler(this.clienteToolStripMenuItem_Click);
            // 
            // transportadoraToolStripMenuItem
            // 
            this.transportadoraToolStripMenuItem.Name = "transportadoraToolStripMenuItem";
            this.transportadoraToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.transportadoraToolStripMenuItem.Text = "Transportadora";
            this.transportadoraToolStripMenuItem.Click += new System.EventHandler(this.transportadoraToolStripMenuItem_Click);
            // 
            // desenvolvedoraToolStripMenuItem
            // 
            this.desenvolvedoraToolStripMenuItem.Name = "desenvolvedoraToolStripMenuItem";
            this.desenvolvedoraToolStripMenuItem.Size = new System.Drawing.Size(103, 20);
            this.desenvolvedoraToolStripMenuItem.Text = "Desenvolvedora";
            this.desenvolvedoraToolStripMenuItem.Click += new System.EventHandler(this.desenvolvedoraToolStripMenuItem_Click);
            // 
            // jogoToolStripMenuItem
            // 
            this.jogoToolStripMenuItem.Name = "jogoToolStripMenuItem";
            this.jogoToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.jogoToolStripMenuItem.Text = "Jogo";
            this.jogoToolStripMenuItem.Click += new System.EventHandler(this.jogoToolStripMenuItem_Click);
            // 
            // tabRelatorios
            // 
            this.tabRelatorios.Controls.Add(this.CCliente);
            this.tabRelatorios.Controls.Add(this.label2);
            this.tabRelatorios.Controls.Add(this.CDesenvolvedora);
            this.tabRelatorios.Controls.Add(this.label1);
            this.tabRelatorios.Controls.Add(this.DTMes);
            this.tabRelatorios.Controls.Add(this.Relatorios);
            this.tabRelatorios.Controls.Add(this.menuStrip2);
            this.tabRelatorios.Location = new System.Drawing.Point(4, 22);
            this.tabRelatorios.Name = "tabRelatorios";
            this.tabRelatorios.Padding = new System.Windows.Forms.Padding(3);
            this.tabRelatorios.Size = new System.Drawing.Size(1062, 582);
            this.tabRelatorios.TabIndex = 2;
            this.tabRelatorios.Text = "Relatorios";
            this.tabRelatorios.UseVisualStyleBackColor = true;
            this.tabRelatorios.Click += new System.EventHandler(this.tabRelatorios_Click);
            // 
            // DTMes
            // 
            this.DTMes.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTMes.Location = new System.Drawing.Point(3, 30);
            this.DTMes.Name = "DTMes";
            this.DTMes.Size = new System.Drawing.Size(249, 20);
            this.DTMes.TabIndex = 2;
            // 
            // Relatorios
            // 
            this.Relatorios.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Relatorios.FormattingEnabled = true;
            this.Relatorios.Location = new System.Drawing.Point(0, 111);
            this.Relatorios.Name = "Relatorios";
            this.Relatorios.Size = new System.Drawing.Size(1062, 472);
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
            this.menuStrip2.Size = new System.Drawing.Size(1056, 24);
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
            // todasToolStripMenuItem
            // 
            this.todasToolStripMenuItem.Name = "todasToolStripMenuItem";
            this.todasToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.todasToolStripMenuItem.Text = "Todas";
            this.todasToolStripMenuItem.Click += new System.EventHandler(this.todasToolStripMenuItem_Click);
            // 
            // maisJogosToolStripMenuItem
            // 
            this.maisJogosToolStripMenuItem.Name = "maisJogosToolStripMenuItem";
            this.maisJogosToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.maisJogosToolStripMenuItem.Text = "Mais Jogos";
            this.maisJogosToolStripMenuItem.Click += new System.EventHandler(this.maisJogosToolStripMenuItem_Click);
            // 
            // maiorLucroToolStripMenuItem
            // 
            this.maiorLucroToolStripMenuItem.Name = "maiorLucroToolStripMenuItem";
            this.maiorLucroToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.maiorLucroToolStripMenuItem.Text = "Maior Lucro";
            this.maiorLucroToolStripMenuItem.Click += new System.EventHandler(this.maiorLucroToolStripMenuItem_Click);
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
            this.gerentesToolStripMenuItem.Click += new System.EventHandler(this.gerentesToolStripMenuItem_Click);
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
            // todosToolStripMenuItem
            // 
            this.todosToolStripMenuItem.Name = "todosToolStripMenuItem";
            this.todosToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.todosToolStripMenuItem.Text = "Todos";
            this.todosToolStripMenuItem.Click += new System.EventHandler(this.todosToolStripMenuItem_Click);
            // 
            // clientesÉpicosToolStripMenuItem
            // 
            this.clientesÉpicosToolStripMenuItem.Name = "clientesÉpicosToolStripMenuItem";
            this.clientesÉpicosToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.clientesÉpicosToolStripMenuItem.Text = "Clientes Épicos";
            this.clientesÉpicosToolStripMenuItem.Click += new System.EventHandler(this.clientesÉpicosToolStripMenuItem_Click);
            // 
            // maiorNivelToolStripMenuItem
            // 
            this.maiorNivelToolStripMenuItem.Name = "maiorNivelToolStripMenuItem";
            this.maiorNivelToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.maiorNivelToolStripMenuItem.Text = "Maior Nivel";
            this.maiorNivelToolStripMenuItem.Click += new System.EventHandler(this.maiorNivelToolStripMenuItem_Click);
            // 
            // vendasToolStripMenuItem
            // 
            this.vendasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clienteToolStripMenuItem1,
            this.boletoToolStripMenuItem,
            this.cartãoToolStripMenuItem,
            this.pixToolStripMenuItem,
            this.todasToolStripMenuItem1,
            this.mesEspecificoToolStripMenuItem,
            this.desenvolvedoraToolStripMenuItem1});
            this.vendasToolStripMenuItem.Name = "vendasToolStripMenuItem";
            this.vendasToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.vendasToolStripMenuItem.Text = "Vendas";
            this.vendasToolStripMenuItem.Click += new System.EventHandler(this.vendasToolStripMenuItem_Click);
            // 
            // clienteToolStripMenuItem1
            // 
            this.clienteToolStripMenuItem1.Name = "clienteToolStripMenuItem1";
            this.clienteToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.clienteToolStripMenuItem1.Text = "Cliente";
            this.clienteToolStripMenuItem1.Click += new System.EventHandler(this.clienteToolStripMenuItem1_Click);
            // 
            // boletoToolStripMenuItem
            // 
            this.boletoToolStripMenuItem.Name = "boletoToolStripMenuItem";
            this.boletoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.boletoToolStripMenuItem.Text = "Boleto";
            this.boletoToolStripMenuItem.Click += new System.EventHandler(this.boletoToolStripMenuItem_Click);
            // 
            // cartãoToolStripMenuItem
            // 
            this.cartãoToolStripMenuItem.Name = "cartãoToolStripMenuItem";
            this.cartãoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cartãoToolStripMenuItem.Text = "Cartão";
            this.cartãoToolStripMenuItem.Click += new System.EventHandler(this.cartãoToolStripMenuItem_Click);
            // 
            // pixToolStripMenuItem
            // 
            this.pixToolStripMenuItem.Name = "pixToolStripMenuItem";
            this.pixToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pixToolStripMenuItem.Text = "Pix";
            this.pixToolStripMenuItem.Click += new System.EventHandler(this.pixToolStripMenuItem_Click);
            // 
            // todasToolStripMenuItem1
            // 
            this.todasToolStripMenuItem1.Name = "todasToolStripMenuItem1";
            this.todasToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.todasToolStripMenuItem1.Text = "Todas";
            this.todasToolStripMenuItem1.Click += new System.EventHandler(this.todasToolStripMenuItem1_Click);
            // 
            // mesEspecificoToolStripMenuItem
            // 
            this.mesEspecificoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.desenvolvedoraToolStripMenuItem2});
            this.mesEspecificoToolStripMenuItem.Name = "mesEspecificoToolStripMenuItem";
            this.mesEspecificoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.mesEspecificoToolStripMenuItem.Text = "Mes Especifico";
            this.mesEspecificoToolStripMenuItem.Click += new System.EventHandler(this.mesEspecificoToolStripMenuItem_Click);
            // 
            // desenvolvedoraToolStripMenuItem2
            // 
            this.desenvolvedoraToolStripMenuItem2.Name = "desenvolvedoraToolStripMenuItem2";
            this.desenvolvedoraToolStripMenuItem2.Size = new System.Drawing.Size(158, 22);
            this.desenvolvedoraToolStripMenuItem2.Text = "Desenvolvedora";
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            this.fileSystemWatcher1.Changed += new System.IO.FileSystemEventHandler(this.fileSystemWatcher1_Changed);
            // 
            // desenvolvedoraToolStripMenuItem1
            // 
            this.desenvolvedoraToolStripMenuItem1.Name = "desenvolvedoraToolStripMenuItem1";
            this.desenvolvedoraToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.desenvolvedoraToolStripMenuItem1.Text = "Desenvolvedora";
            this.desenvolvedoraToolStripMenuItem1.Click += new System.EventHandler(this.desenvolvedoraToolStripMenuItem1_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Desenvolvedora";
            // 
            // CDesenvolvedora
            // 
            this.CDesenvolvedora.FormattingEnabled = true;
            this.CDesenvolvedora.Location = new System.Drawing.Point(96, 57);
            this.CDesenvolvedora.Name = "CDesenvolvedora";
            this.CDesenvolvedora.Size = new System.Drawing.Size(156, 21);
            this.CDesenvolvedora.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Cliente";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // CCliente
            // 
            this.CCliente.FormattingEnabled = true;
            this.CCliente.Location = new System.Drawing.Point(96, 84);
            this.CCliente.Name = "CCliente";
            this.CCliente.Size = new System.Drawing.Size(156, 21);
            this.CCliente.TabIndex = 6;
            // 
            // Tela_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1230, 609);
            this.Controls.Add(this.TabPrincipal);
            this.Controls.Add(this.SideBar);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Tela_Principal";
            this.Text = "Teste";
            this.Load += new System.EventHandler(this.Tela_Principal_Load);
            this.SideBar.ResumeLayout(false);
            this.SideBar.PerformLayout();
            this.TabPrincipal.ResumeLayout(false);
            this.tabComprar.ResumeLayout(false);
            this.tabCadastrar.ResumeLayout(false);
            this.tabCadastrar.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabRelatorios.ResumeLayout(false);
            this.tabRelatorios.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel SideBar;
        private System.Windows.Forms.TabControl TabPrincipal;
        private System.Windows.Forms.TabPage tabComprar;
        private System.Windows.Forms.TabPage tabCadastrar;
        private System.Windows.Forms.TabPage tabRelatorios;
        private System.Windows.Forms.ComboBox CBTipoJogo;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem usuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gerenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transportadoraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem desenvolvedoraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jogoToolStripMenuItem;
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
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem todasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem todosToolStripMenuItem;
        private System.Windows.Forms.CheckBox chbVisualizacaoJogos;
        private System.Windows.Forms.ListView JogosComprados;
        private System.Windows.Forms.FlowLayoutPanel CatalogoJogo;
        private System.Windows.Forms.Button btnComprar;
        private System.Windows.Forms.ListBox Relatorios;
        private System.Windows.Forms.ToolStripMenuItem todasToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mesEspecificoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem desenvolvedoraToolStripMenuItem2;
        private System.Windows.Forms.DateTimePicker DTMes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CDesenvolvedora;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem desenvolvedoraToolStripMenuItem1;
        private System.Windows.Forms.ComboBox CCliente;
    }
}