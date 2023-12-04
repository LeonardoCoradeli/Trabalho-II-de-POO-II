using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_II_de_POO_II.GUI
{
    [Serializable]
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


        public Venda(int codigo, Cliente cliente, Gerente gerente, DateTime dataVenda,List<ItemVenda> itens)
        {
            Codigo = (codigo == -1) ? NumAleatorio.Gerar<Venda>() : codigo;
            Cliente = cliente;
            Gerente = gerente;
            DataVenda = dataVenda;
            ItensVenda = itens;
        }

        public float CalcularValorTotal()
        {
            float total = 0;
            foreach (var item in ItensVenda)
            {
                total += item.CalcularTotal();
            }
            ValorTotal = total;
            return total;
        }

        public void CalcularDataEntrega()
        {
            DataDaEntrega = DataVenda.AddDays(Transportadora.TempoDeEntrega);
        }

        //se precisar mudar para boll
        public bool possuiItemFisico()
        {
            foreach (ItemVenda itens in ItensVenda)
            {
                if (itens.Fisico)
                {
                    PossuiItensFisicos = true;
                    return true;
                }
            }
            PossuiItensFisicos = false;
            return false;
        }

        public float CalcularValorComDesconto()
        {
            if (Cliente.ClienteEpico)
            {
                ValorComDesconto = (float)ValorTotal - (ValorTotal * (float)0.05);
                return ValorComDesconto;
            }
            ValorComDesconto = ValorTotal;
            return ValorComDesconto;
        }

        public override string ToString()
        {
            return $"Venda: Código - {Codigo}, Cliente - {Cliente}, Gerente - {Gerente}, Data da Venda - {DataVenda}, Data da Entrega - {DataDaEntrega}, Valor Total - {ValorTotal}, Valor com Desconto - {ValorComDesconto}, Forma de Pagamento - {FormaPagamento}, Transportadora - {Transportadora}";
        }

    }
}
