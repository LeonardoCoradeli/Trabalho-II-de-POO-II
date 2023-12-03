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
using Trabalho_II_de_POO_II.Utilitaries;

namespace Trabalho_II_de_POO_II.GUI
{
    public partial class Cadastrar_Desenvolvedora : Form
    {
        public Cadastrar_Desenvolvedora()
        {
            InitializeComponent();
        }

        private void btnCadastrarDesenvolvedora_Click(object sender, EventArgs e)
        {
            List<object> campos = new List<object>()
            {
                nomeDesenvolvedora.Text,
                cnpjDesenvolvedora.Text,
                emailDesenvolvedora.Text,
                siteDesenvolvedora.Text,
                redeSocialDesenvolvedora.Text,
                enderecoDesenvolvedora.Text
            };
            VerificarVazio.verificarVazio(campos);
            ControladorUsuario.CadastrarDesenvolvedora(
                (string)campos[0],
                (string)campos[1],
                (string)campos[2],
                (string)campos[3],
                (string)campos[4],
                (string)campos[5]
                );
            MessageBox.Show("Desenvolvedora cadastrada com sucesso!");
            this.Close();
        }
    }
}
