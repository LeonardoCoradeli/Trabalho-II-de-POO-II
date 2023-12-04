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
        
        private void PreencherComboBoxComClientes()
        {
            List<Usuario> clientes = ControladorUsuario.listarClientes();

            CCliente.DataSource = clientes;
            CCliente.DisplayMember = "Nome";
        }
    }
}
