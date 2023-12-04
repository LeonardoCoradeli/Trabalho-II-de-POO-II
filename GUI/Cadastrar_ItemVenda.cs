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
    public partial class Cadastrar_ItemVenda : UserControl
    {
        public Cadastrar_ItemVenda(int codigo,float valor,int quantidade,bool fisico)
        {
            InitializeComponent();
            codigoProduto.Text = codigo.ToString();
            valorProduto.Text = valor.ToString();
            quantidadeProduto.Text = quantidade.ToString();
            fisicoProduto.Text = fisico?"Sim":"Não";
        }
    }
}
