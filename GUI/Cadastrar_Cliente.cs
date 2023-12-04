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
    public partial class Cadastrar_Cliente : Form
    {
        public Cadastrar_Cliente()
        {
            InitializeComponent();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Cadastrar_Gereante_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnCadastrarCliente_Click(object sender, EventArgs e)
        {
            
        }

        private void epicoCliente_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void emailCliente_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void cepCliente_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void enderecoCliente_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dataNascCliente_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void rgCliente_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cpfCliente_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void nomeCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCadastrarCliente_Click_1(object sender, EventArgs e)
        {
            List<object> campos = new List<object> { nomeCliente.Text, cpfCliente.ValidateText(), rgCliente.ValidateText(), dataNascCliente.ValidateText(), cepCliente.ValidateText(), emailCliente.ValidateText(), enderecoCliente.ValidateText() };
            VerificarVazio.verificarVazio(campos);
            ControladorUsuario.CadastrarCliente(
                (string)campos[0],  // Nome
                (string)campos[1],  // CPF
                (string)campos[2],  // RG
                (DateTime)campos[3],  // Data de Nascimento
                (string)campos[6],
                (string)campos[4],  // CEP
                (string)campos[5],  // E-mail
                DateTime.Now,
                0,
                epicoCliente.Checked// Endereço
            );
            MessageBox.Show("Cliente cadastrado com sucesso!");
            this.Close();
        }
    }
}
