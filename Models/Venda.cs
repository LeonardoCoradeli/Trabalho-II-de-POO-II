using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_II_de_POO_II.GUI
{
    public class Venda
    {
        public int Codigo { get; set; }
        public Cliente Cliente { get; set; }
        public Gerente Gerente { get; set; }
        public DateTime DataVenda { get; set; }
        public DateTime DataDaEntrega { get; set; }
        public List<ItemVenda> ItensVenda { get; set; }
        public bool PossuiItensFisicos { get; set; }
        public float ValorTotal { get; set; }
        public float ValorComDesconto { get; set; }
        public Pagamento FormaPagamento { get; set; }
        public Transportadora Transportadora { get; set; }

        public Venda()
        {
            ItensVenda = new List<ItemVenda>();
        }

        public Venda(int codigo, Cliente cliente, Gerente gerente, DateTime dataVenda, bool possuiItensFisicos, float valorComDesconto, Pagamento formaPagamento, Transportadora transportadora)
        {
            Codigo = codigo;
            Cliente = cliente;
            Gerente = gerente;
            DataVenda = dataVenda;
            PossuiItensFisicos = possuiItensFisicos;
            ValorComDesconto = valorComDesconto;
            FormaPagamento = formaPagamento;
            Transportadora = transportadora;
            ItensVenda = new List<ItemVenda>();
        }

        public float CalcularValorTotal()
        {
            float total = 0;
            foreach (var item in ItensVenda)
            {
                total += item.CalcularTotal();
            }
            return total;
        }

        public void CalcularDataEntrega()
        {
            DataDaEntrega = DataVenda.AddDays(Transportadora.TempoDeEntrega);
        }

        public void AddItemVenda(ItemVenda item)
        {
            ItensVenda.Add(item);
        }
    }
}
