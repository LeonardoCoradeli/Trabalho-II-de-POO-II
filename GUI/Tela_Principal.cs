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
    public partial class Tela_Principal : Form
    {
        public Tela_Principal()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

        }

        private void testeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void comprarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CBTipoJogo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void fileSystemWatcher1_Changed(object sender, System.IO.FileSystemEventArgs e)
        {

        }

        private void TabComprar_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void tabRelatorios_Click(object sender, EventArgs e)
        {

        }

        private void transportadorasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void vendasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void desenvolvedoraToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Desenvolvedora_Especifico desenvolvedora = new Desenvolvedora_Especifico();
            desenvolvedora.ShowDialog();
        }

        private void clienteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Cliente_Especifico cliente = new Cliente_Especifico();
            cliente.ShowDialog();
        }
    }
}
