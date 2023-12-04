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
    public partial class Cadastrar_Jogo : Form
    {
        public Cadastrar_Jogo()
        {
            InitializeComponent();
            PreencherComboBoxComDesenvolvedoras();
        }

        private void PreencherComboBoxComDesenvolvedoras()
        {

            List<Desenvolvedora> desenvolvedoras = ControladorUsuario.listarDesenvolvedoras();


            desenvolvedoraJogo.DataSource = desenvolvedoras;
            desenvolvedoraJogo.DisplayMember = "Nome";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnCadastrarDesenvolvedora_Click(object sender, EventArgs e)
        {
            
            List<object> campos = new List<object>()
            {
                                    nomeJogo.Text,descricaoJogo.Text,dataLancamentoJogo.Value,valorJogo.Text,requisitosJogo.Text,avaliacaoJogo.Text,comentariosJogo.Text};
            VerificarVazio.verificarVazio(campos);
            ControladorJogo.CadastrarJogo(
                (string)campos[0],
                (string)campos[1],
                (Desenvolvedora)desenvolvedoraJogo.SelectedItem,
                (DateTime)campos[2],
                (float)Convert.ToDouble(campos[3]),
                (string)campos[4],
                (float)Convert.ToDouble(campos[5]),
                (string)campos[6],
                true,
                tipoJogo.SelectedItem.ToString()
                );
            MessageBox.Show("Jogo cadastrado com sucesso!");
            this.Close();
        }
    }
}