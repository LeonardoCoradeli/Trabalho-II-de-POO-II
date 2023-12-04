using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trabalho_II_de_POO_II.Models;
using Trabalho_II_de_POO_II.Controllers;

namespace Trabalho_II_de_POO_II.GUI
{
    public partial class Tela_Principal : Form
    {

        public Tela_Principal()
        {

            SetFullScreen();
            InitializeComponent();
            JogosComprados.Items.Clear();
            AdicionarItensJogosComprados(ControladorJogo.GetJogosComprados(),jogo =>jogo.Nome,jogo=>jogo.Avaliacao.ToString());
            CatalogoJogo.Controls.Clear();
            AdicionarItensJogosDisponiveis(ControladorJogo.GetJogosDisponiveis(),jogo=>jogo.Nome);
            PreencherComboBoxComClientes();
            PreencherComboBoxComDesenvolvedoras();
            this.Resize += new EventHandler(Tela_Principal_Resize);
        }
        private void SetFullScreen()
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void Tela_Principal_Resize(object sender, EventArgs e)
        {
            TabPrincipal.Width = this.Width;
            TabPrincipal.Height = this.Height;

            SideBar.Width = this.Width;
            SideBar.Height = this.Height;

            JogosComprados.Width = this.Width;
            JogosComprados.Height = this.Height;

            Relatorios.Width = this.Width;
            Relatorios.Height = this.Height;
        }

        private void AdicionarItensJogosComprados<T>(List<T> lista, Func<T, string> obterNome, Func<T, string> obterAvaliacao)
        {
            lista = lista.OrderBy(obterNome).ToList();

            foreach (var item in lista)
            {
                string nome = obterNome(item);

                ListViewItem visualizar = new ListViewItem(nome);
                visualizar.Tag = item;

                JogosComprados.Items.Add(visualizar);
            }
        }
        private void AdicionarItensJogosDisponiveis(List<Jogo> lista, Func<Jogo, string> obterNome)
        {
            lista = lista.OrderBy(obterNome).ToList();

            foreach (var item in lista)
            {
                CatalogoJogo.Controls.Add(new Jogo_personalizado(item.Codigo,item.Nome,item.Valor,item.Avaliacao,item.Disponivel));
            }
        }




        private void trackBar1_Scroll(object sender, EventArgs e)
        {

        }

        private void testeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void comprarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CBTipoJogo_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            string selectedItem = (string)comboBox.SelectedItem;
            int selectedIndex = comboBox.SelectedIndex;

            switch (selectedItem)
            {
                case "Ação":
                {
                        CatalogoJogo.Controls.Clear();
                        AdicionarItensJogosDisponiveis(ControladorJogo.ListarJogosPorTipo("Ação"), jogo => jogo.Nome);
                        break;
                }
                case "Aventura":
                {
                        CatalogoJogo.Controls.Clear();
                        AdicionarItensJogosDisponiveis(ControladorJogo.ListarJogosPorTipo("Aventura"), jogo => jogo.Nome);
                        break;
                    }
                case "Corrida":
                {
                        CatalogoJogo.Controls.Clear();
                        AdicionarItensJogosDisponiveis(ControladorJogo.ListarJogosPorTipo("Corrida"), jogo => jogo.Nome);
                        break;
                }
                case "Esporte":
                {
                        CatalogoJogo.Controls.Clear();
                        AdicionarItensJogosDisponiveis(ControladorJogo.ListarJogosPorTipo("Esporte"), jogo => jogo.Nome);
                        break;
                }
                case "RPG":
                {
                        CatalogoJogo.Controls.Clear();
                        AdicionarItensJogosDisponiveis(ControladorJogo.ListarJogosPorTipo("RPG"), jogo => jogo.Nome);
                        break;
                }
                case "Mais Caros":
                {
                        CatalogoJogo.Controls.Clear();
                        AdicionarItensJogosDisponiveis(ControladorJogo.ListarTop10JogosMaisCaros(), jogo => jogo.Nome);
                        break;
                }
                case "Mais Baratos":
                {
                        CatalogoJogo.Controls.Clear();
                        AdicionarItensJogosDisponiveis(ControladorJogo.ListarTop10JogosMenorPreco(), jogo => jogo.Nome);
                        break;
                }
                default:
                {
                        CatalogoJogo.Controls.Clear();
                        AdicionarItensJogosDisponiveis(ControladorJogo.GetJogosDisponiveis(), jogo => jogo.Nome);
                        break;
                }
            }
        }

        private void fileSystemWatcher1_Changed(object sender, System.IO.FileSystemEventArgs e)
        {

        }

        private void TabComprar_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void tabRelatorios_Click(object sender, EventArgs e)
        {

        }

        private void transportadorasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Relatorios.Items.Clear();
            Relatorios.Items.AddRange(ControladorUsuario.listarTransportadoras().ToArray());
            Relatorios.Text = ControladorUsuario.ListarTransportadorasParaTextbox(ControladorUsuario.listarTransportadoras());
        }

        private void vendasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void desenvolvedoraToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void clienteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Relatorios.Items.Clear();
            Relatorios.Items.AddRange(ControladorVendas.ListarHistoricoVendasCliente((Usuario)CCliente.SelectedItem).ToArray());
            Relatorios.Text = ControladorVendas.ListarVendasClienteParaTextBox((Usuario)CCliente.SelectedItem);

        }

        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (chbVisualizacaoJogos.Checked)
            {
                chbVisualizacaoJogos.Text = "Avaliação";
                MetodoOrganizacao1 organizacao = new MetodoOrganizacao1();
                ContextoOrganizacao contexto = new ContextoOrganizacao(organizacao);
                List<Jogo> jogosOrdenados = contexto.Organizar(ControladorJogo.GetJogosComprados());
                JogosComprados.Items.Clear();
                AdicionarItensJogosComprados(jogosOrdenados, jogo => jogo.Nome, jogo => jogo.Avaliacao.ToString());
            }
            else
            {
                chbVisualizacaoJogos.Text = "Nomes";
                JogosComprados.Items.Clear();
                AdicionarItensJogosComprados(ControladorJogo.GetJogosComprados(), jogo => jogo.Nome, jogo => jogo.Avaliacao.ToString());
            }
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void JogosComprados_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (JogosComprados.SelectedItems!= null)
            {
                foreach (ListViewItem item in JogosComprados.SelectedItems)
                {
                    Informacoes_jogo info = new Informacoes_jogo((Jogo)item.Tag);
                    info.ShowDialog();
                }
                
            }
        }

        private void JogosVenda_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Tela_Principal_Load(object sender, EventArgs e)
        {

        }

        private void jogosDisponiveis_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadastrar_Cliente cadastro = new Cadastrar_Cliente();
            cadastro.Show();
        }

        private void gerenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadastrar_Gerente cadastro = new Cadastrar_Gerente();
            cadastro.Show();
        }

        private void desenvolvedoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadastrar_Desenvolvedora cadastro = new Cadastrar_Desenvolvedora();
            cadastro.Show();
        }

        private void transportadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadastrar_Transportadora cadastro = new Cadastrar_Transportadora();
            cadastro.Show();
        }

        private void jogoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadastrar_Jogo cadastro = new Cadastrar_Jogo();
            cadastro.Show();
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            Cadastrar_Venda cadastro = new Cadastrar_Venda();
            cadastro.Show();
        }

        private void todosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Relatorios.Items.Clear();
            Relatorios.Items.AddRange(ControladorUsuario.listarClientes().ToArray());
            Relatorios.Text = ControladorUsuario.ListarClientesParaTextbox(ControladorUsuario.listarClientes());
        }

        private void todasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Relatorios.Items.Clear();
            Relatorios.Items.AddRange(ControladorUsuario.listarDesenvolvedoras().ToArray());
            Relatorios.Text = ControladorUsuario.ListarDesenvolvedorasParaTextbox(ControladorUsuario.listarDesenvolvedoras());
        }

        private void maisJogosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Relatorios.Items.Clear();
            Relatorios.Items.AddRange(ControladorUsuario.listarDesenvolvedorasMaisVendidos().ToArray());
            Relatorios.Text = ControladorUsuario.ListarDesenvolvedorasParaTextbox(ControladorUsuario.listarDesenvolvedorasMaisVendidos());
        }

        private void maiorLucroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Relatorios.Items.Clear();
            Relatorios.Items.AddRange(ControladorUsuario.ListarDesenvolvedorasComMaiorLucro().ToArray());
            Relatorios.Text = ControladorUsuario.ListarDesenvolvedorasParaTextbox(ControladorUsuario.ListarDesenvolvedorasComMaiorLucro());
        }

        private void gerentesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Relatorios.Items.Clear();
            Relatorios.Items.AddRange(ControladorUsuario.listarGerentes().ToArray());
            Relatorios.Text = ControladorUsuario.ListarClientesParaTextbox(ControladorUsuario.listarGerentes());
        }

        private void clientesÉpicosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Relatorios.Items.Clear();
            Relatorios.Items.AddRange(ControladorUsuario.listarClientesEpicos(ControladorUsuario.TransformarUsuariosEmClientes(ControladorUsuario.listarClientes())).ToArray());
            Relatorios.Text = ControladorUsuario.ListarClientesEpicosParaTextbox(ControladorUsuario.listarClientesEpicos(ControladorUsuario.TransformarUsuariosEmClientes(ControladorUsuario.listarClientes())));
        }

        private void maiorNivelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Relatorios.Items.Clear();
            Relatorios.Items.AddRange(ControladorUsuario.listarTop10ClientesMaiorNivel(ControladorUsuario.TransformarUsuariosEmClientes(ControladorUsuario.listarClientes())).ToArray());
            Relatorios.Text = ControladorUsuario.ListarClientesEpicosParaTextbox(ControladorUsuario.listarTop10ClientesMaiorNivel(ControladorUsuario.TransformarUsuariosEmClientes(ControladorUsuario.listarClientes())));
        }
        

        private void mesEspecificoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Relatorios.Items.Clear();
            Relatorios.Items.AddRange(ControladorVendas.ListarTodasVendas().ToArray());
            Relatorios.Text = ControladorVendas.ListarCalcularLucroEListarVendasMesEspecificoParaTextBox(DTMes.Value.Month, ControladorVendas.ListarTodasVendas());

        }

        private void todasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Relatorios.Items.Clear();
            Relatorios.Items.AddRange(ControladorVendas.ListarTodasVendas().ToArray());
            Relatorios.Text = ControladorVendas.ListarTodasVendasParaTextBox();
        }

        private void boletoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Relatorios.Items.Clear();
            Relatorios.Items.AddRange(ControladorVendas.ListarVendasComFormaPagamentoBoleto(ControladorVendas.ListarTodasVendas()).ToArray());
            Relatorios.Text = ControladorVendas.ListarVendasComFormaPagamentoBoletoParaTextBox();
        }

        private void cartãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Relatorios.Items.Clear();
            Relatorios.Items.AddRange(ControladorVendas.ListarVendasComFormaPagamentoCartaoCredito(ControladorVendas.ListarTodasVendas()).ToArray());
            Relatorios.Text = ControladorVendas.ListarVendasComFormaPagamentoCartaoCreditoParaTextBox();
        }

        private void pixToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Relatorios.Items.Clear();
            Relatorios.Items.AddRange(ControladorVendas.ListarVendasComFormaPagamentoPix(ControladorVendas.ListarTodasVendas()).ToArray());
            Relatorios.Text = ControladorVendas.ListarVendasComFormaPagamentoPixParaTextBox();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        void PreencherComboBoxComClientes()
        {
            List<Usuario> clientes = ControladorUsuario.listarClientes();

            CCliente.DataSource = clientes;
            CCliente.DisplayMember = "Codigo";
            CCliente.ValueMember = "Nome";

            CCliente.SelectedIndexChanged += (sender, e) =>
            {
                var selectedCliente = CCliente.SelectedItem as Usuario;
            };
        }

        void PreencherComboBoxComDesenvolvedoras()
        {
            List<Desenvolvedora> desenvolvedoras = ControladorUsuario.listarDesenvolvedoras();

            CDesenvolvedora.DataSource = desenvolvedoras;
            CDesenvolvedora.DisplayMember = "Codigo";
            CDesenvolvedora.ValueMember = "Nome";

            CDesenvolvedora.SelectedIndexChanged += (sender, e) =>
            {
                var selectedDesenvolvedora = CDesenvolvedora.SelectedItem as Desenvolvedora;
            };
        }

        private void desenvolvedoraToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            Relatorios.Items.Clear();
            Relatorios.Items.AddRange(ControladorVendas.ListarVendasDesenvolvedoras((Desenvolvedora)CDesenvolvedora.SelectedItem).ToArray());
            Relatorios.Text = ControladorVendas.ListarVendasECalcularLucroDesenvolvedoraMesEspecificoParaTextBox(((Desenvolvedora)CDesenvolvedora.SelectedItem).Nome, DTMes.Value.Month);
        }
    }
}
