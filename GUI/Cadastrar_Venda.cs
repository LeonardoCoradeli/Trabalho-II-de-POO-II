using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trabalho_II_de_POO_II.Controllers;
using Trabalho_II_de_POO_II.Models;

namespace Trabalho_II_de_POO_II.GUI
{
    public partial class Cadastrar_Venda : Form
    {
        private List<ItemVenda> jogoTemp = new List<ItemVenda>();
        private int cont = 0;
        public Cadastrar_Venda()
        {
            InitializeComponent();
            PreencherComboBoxComClientes();
            PreencherComboBoxComGerentes();
            PreencherComboBoxComTransportadoras();
            PreencherComboBoxComJogos();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Cadastrar_Venda_Load(object sender, EventArgs e)
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
                if (selectedCliente != null)
                {
                    ClienteLabel.Text = selectedCliente.Nome;
                }
            };
        }
        void PreencherComboBoxComGerentes()
        {
            List<Usuario> gerentes = ControladorUsuario.listarGerentes();

            CGerente.DataSource = gerentes;
            CGerente.DisplayMember = "Codigo";
            CGerente.ValueMember = "Nome";

            CGerente.SelectedIndexChanged += (sender, e) =>
            {
                var selectedGerente = CGerente.SelectedItem as Usuario;
                if (selectedGerente != null)
                {
                    GerenteLabel.Text = selectedGerente.Nome;
                }
            };
        }
        private void FisicoCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void FisicoCheckBox_CheckedChanged_1(object sender, EventArgs e)
        {
            bool isChecked = FisicoCheckBox.Checked;

            LabelTransportadora.Visible = isChecked;
            CTransportadora.Visible = isChecked;
            DTLabel.Visible = isChecked;
            EntregaDT.Visible = isChecked;
        }
        void PreencherComboBoxComTransportadoras()
        {
            List<Transportadora> transportadoras = ControladorUsuario.listarTransportadoras();

            CTransportadora.DataSource = transportadoras;
            CTransportadora.DisplayMember = "Nome";
        }

        private void CTransportadora_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedTransportadora = CTransportadora.SelectedItem as Transportadora;
            if (selectedTransportadora != null)
            {
                EntregaDT.Value = DateTime.Now.AddDays(selectedTransportadora.TempoDeEntrega);
            }
        }
        void PreencherComboBoxComJogos()
        {
            List<Jogo> jogos = ControladorJogo.GetTodosJogos();

            CJogos.DataSource = jogos;
            CJogos.DisplayMember = "Nome";
        }

        private void BAdicionar_Click(object sender, EventArgs e)
        {
            jogoTemp.Add(new ItemVenda(-1,((Jogo)CJogos.SelectedItem).Valor,int.Parse(Tquantidade.Text), (Jogo)CJogos.SelectedItem, FisicoCheckBox.Checked));

            Cadastrar_ItemVenda Item = new Cadastrar_ItemVenda(jogoTemp[cont].CodigoProduto, (jogoTemp[cont].Valor * jogoTemp[cont].Quantidade), jogoTemp[cont].Quantidade, jogoTemp[cont].Fisico);

            
            PainelJogo.Controls.Add(Item);

            CJogos.SelectedIndex = -1;
            Tquantidade.Text = "";
            FisicoCheckBox.Checked = false;
            cont++;

            float total = 0;
            foreach (ItemVenda item in jogoTemp)
            {
                total += item.Valor * item.Quantidade;
            }
            TotalLabel.Text = total.ToString();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void BFinalizar_Click(object sender, EventArgs e)
        {
            Venda vendas = new Venda(-1, ((Cliente)CCliente.SelectedItem), ((Gerente)CGerente.SelectedItem), DateTime.Now, jogoTemp);
            vendas.ValorTotal = vendas.CalcularValorTotal();
            vendas.ValorComDesconto = vendas.CalcularValorComDesconto();
            vendas.PossuiItensFisicos = vendas.possuiItemFisico();
            vendas.Transportadora = (Transportadora)CTransportadora.SelectedItem;
            if (comboBox4 != null && comboBox4.SelectedIndex == 0) 
            {
                Boleto_Tela boletoTela = new Boleto_Tela();
                boletoTela.Show();
                vendas.FormaPagamento = new Boleto(-1, "123456789");
            }
            if (comboBox4 != null && comboBox4.SelectedIndex == 1) 
            {
                PIX_Tela pixtela = new PIX_Tela();
                pixtela.Show();
                vendas.FormaPagamento = new Pix(-1,ClienteLabel.Text,"123456789");
            }
            if (comboBox4 != null && comboBox4.SelectedIndex == 2)
            {
                vendas.FormaPagamento = new CartaoCredito(-1, ClienteLabel.Text, TBandeira.Text, TNumeroC.Text);
            }
            TornarJogosIndisponiveis();
            ControladorVendas.CadastrarVenda(vendas);
            MessageBox.Show("Venda cadastrada com sucesso!");
            this.Close();
        }

        private void BPagar_Click(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool isChecked = false;
            if(comboBox4.SelectedIndex == 2)
            {
                isChecked = true;
            }
            if (comboBox4 != null && isChecked)
            {
                label9.Visible = isChecked;
                label3.Visible = isChecked;
                TBandeira.Visible = isChecked;
                TNumeroC.Visible = isChecked;
            }
        }
        private void TornarJogosIndisponiveis()
        {
            foreach (ItemVenda item in jogoTemp)
            {
                ControladorJogo.TornarJogoIndisponivel(item.Jogo.Codigo);
            }
        }
        
    }
}
