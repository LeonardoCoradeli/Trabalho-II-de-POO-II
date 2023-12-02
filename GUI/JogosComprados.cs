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
    public partial class JogosComprados : UserControl
    {
        public JogosComprados(Jogo jogo)
        {
            InitializeComponent();
            nomeJogoComprar.Text = jogo.Nome;
            precoJogoComprar.Text = jogo.Valor.ToString();
        }

        private void JogosComprados_Load(object sender, EventArgs e)
        {

        }
    }
}
