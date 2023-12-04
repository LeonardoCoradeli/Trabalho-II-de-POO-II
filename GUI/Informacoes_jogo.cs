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
    public partial class Informacoes_jogo : Form
    {
        public Informacoes_jogo(Jogo jogo)
        {
            InitializeComponent();
            codigoJogo.Text = jogo.Codigo.ToString();
            nomeJogo.Text = jogo.Nome;
            descricaoJogo.Text = jogo.Descricao;
            dataLancamentoJogo.Text = jogo.DataLancamento.ToString("dd/MM/yyyy");
            tipoJogo.Text = jogo.Tipo;
            avaliacaoJogo.Text = jogo.Avaliacao.ToString();
            descricaoJogo.Text = jogo.Descricao;
            requisitosJogo.Text = jogo.RequisitosMinimos ;
            comentariosJogo.Text = jogo.Comentarios;
            codigoDesenvolvedora.Text = jogo.Desenvolvedora.Codigo.ToString();
            nomeDesenvolvedora.Text = jogo.Desenvolvedora.Nome;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void nomeJogo_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void codigoJogo_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAvaliarJogo_Click(object sender, EventArgs e)
        {
            ControladorJogo.atualizarAvalicao(int.Parse(codigoJogo.Text), avaliarJogo.Value);
            ControladorJogo.atualizarComentarios(int.Parse(codigoJogo.Text), ComentarioJogo.Text);
        }

        private void avaliarJogo_Scroll(object sender, EventArgs e)
        {
            LAvaliacao.Text = avaliarJogo.Value.ToString();
            
        }
    }
}
