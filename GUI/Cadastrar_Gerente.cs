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
using Trabalho_II_de_POO_II.GUI;
using Trabalho_II_de_POO_II.Utilitaries;
using Trabalho_II_de_POO_II.Controllers;

namespace Trabalho_II_de_POO_II.GUI
{
    public partial class Cadastrar_Gerente : Form
    {
        public Cadastrar_Gerente()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btnCadastrarCliente_Click(object sender, EventArgs e)
        {
            List<object> campos = new List<object>()
            { 
               nomeGerente.Text,
               cpfGerente.Text,
               rgGerente.Text,
               dataNascGerente.ValidateText(),
               enderecoGerente.Text,
               cepGerente.Text,
               emailGerente.Text,
               salarioGerente.Text,
               pisGerente.Text
            };

            VerificarVazio.verificarVazio(campos);
            ControladorUsuario.CadastrarGerente((string)campos[0], (string)campos[1], (string)campos[2], (DateTime)campos[3], (string)campos[4], (string)campos[5], (string)campos[6], double.Parse((string)campos[7]), (string)campos[8],DateTime.Now);
            MessageBox.Show("Gerente cadastrado com sucesso!");
            this.Close();
        }

        private void rgCliente_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void Cadastrar_Gerente_Load(object sender, EventArgs e)
        {

        }
    }
}
