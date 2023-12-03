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
using Trabalho_II_de_POO_II.Utilitaries;

namespace Trabalho_II_de_POO_II.GUI
{
    public partial class Cadastrar_Transportadora : Form
    {
        public Cadastrar_Transportadora()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnCadastrarDesenvolvedora_Click(object sender, EventArgs e)
        {
            List<object> campos = new List<object>()
            {
                nomeTransportadora.Text,
                cnpjTransportadora.Text,
                emailTransportadora.Text,
                telefoneTransportadora.Text,
                enderecoTransportadora.Text,
                tempoEntrega.Text
            };
            VerificarVazio.verificarVazio(campos);
            ControladorUsuario.CadastrarTransportadora(
                (string)campos[0],
                (string)campos[1],
                (string)campos[4],
                (string)campos[2],
                (string)campos[3],
                int.Parse((string)campos[5])
            );
            MessageBox.Show("Transportadora cadastrada com sucesso!");
            this.Close();
        } 
    }
}
