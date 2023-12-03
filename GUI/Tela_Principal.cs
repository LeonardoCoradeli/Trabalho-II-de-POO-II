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


            InitializeComponent();
            JogosComprados.Items.Clear();
            AdicionarItensJogosComprados(ControladorJogo.GetJogosComprados(),jogo =>jogo.Nome,jogo=>jogo.Avaliacao.ToString());
            CatalogoJogo.Controls.Clear();
            AdicionarItensJogosDisponiveis(ControladorJogo.GetJogosDisponiveis(),jogo=>jogo.Nome);
            
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

        }

        private void vendasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void desenvolvedoraToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Desenvolvedora_Especifico desenvolvedora = new Desenvolvedora_Especifico();
            desenvolvedora.ShowDialog();
        }

        private void clienteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Cliente_Especifico cliente = new Cliente_Especifico();
            cliente.ShowDialog();
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
    }
}
