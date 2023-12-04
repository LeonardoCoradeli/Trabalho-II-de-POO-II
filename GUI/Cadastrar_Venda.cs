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
    }
}
