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

namespace Trabalho_II_de_POO_II.GUI
{
    public partial class Cadastrar_Venda : Form
    {
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

        }
    }
}
