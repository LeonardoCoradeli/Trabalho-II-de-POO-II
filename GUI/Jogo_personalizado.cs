using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabalho_II_de_POO_II.GUI
{
    public partial class Jogo_personalizado : UserControl
    {
        public Jogo_personalizado(int codigo,string Nome, float preco,float avaliacao)
        {
            InitializeComponent();
            codigoJogo.Text = codigo.ToString();
            nomeJogo.Text = Nome;
            precoJogo.Text = preco.ToString("F2");
            avaliacaoJogo.Text = avaliacao.ToString();
        }

        private void codigoJogo_Click(object sender, EventArgs e)
        {

        }
    }
}
