using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_II_de_POO_II.GUI
{
    public class ItemVenda
    {
        public int CodigoProduto { get; set; }
        public float Valor { get; set; }
        public int Quantidade { get; set; }

        public ItemVenda() { }

        public ItemVenda(int codigoProduto, float valor, int quantidade)
        {
            CodigoProduto = codigoProduto;
            Valor = valor;
            Quantidade = quantidade;
        }

        public float CalcularTotal()
        {
            return Valor * Quantidade;
        }
    }
}
