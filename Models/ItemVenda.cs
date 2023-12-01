using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_II_de_POO_II.GUI
{
    [Serializable]
    public class ItemVenda
    {
        public int CodigoProduto { get; set; }
        public float Valor { get; set; }
        public int Quantidade { get; set; }
        public Jogo Jogo { get; set; }
        public bool Fisico { get; set; }

        public ItemVenda() { }

        public ItemVenda(int codigoProduto, float valor, int quantidade, Jogo jogo,bool fisico)
        {
            CodigoProduto = (codigoProduto == -1)? NumAleatorio.Gerar<ItemVenda>(): codigoProduto;
            Valor = valor;
            Quantidade = quantidade;
            Jogo = jogo;
            Fisico = fisico;
        }

        public float CalcularTotal()
        {
            return Valor * Quantidade;
        }
    }
}
