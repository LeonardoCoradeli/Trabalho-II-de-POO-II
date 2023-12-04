using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trabalho_II_de_POO_II.GUI;

namespace Trabalho_II_de_POO_II.Controllers
{
    public static class ControladorVendas
    {
        public static SistemaJogosEletronicos SJE { get; set; }

        public static void CadastrarVenda(int codCliente, int codGerente, DateTime dataVenda, List<ItemVenda> itensVenda, Pagamento formaPagamento, Transportadora transportadora = null)
        {
            SJE.CadastrarVenda(codCliente, codGerente, dataVenda, itensVenda, formaPagamento, transportadora);
        }
        public static string buscarVenda(int codigo)
        {
            return SJE.buscarVenda(codigo);
        }
        public static List<Venda> ListarHistoricoVendasCliente(Usuario cliente)
        {
            return SJE.ListarHistoricoVendasCliente(cliente);
        }
        public static List<Venda> ListarTodasVendas()
        {
            return SJE.ListarTodasVendas();
        }
        public static (float lucro, List<Venda>) CalcularLucroEListarVendasMesEspecifico(int mes, List<Venda> vendas)
        {
            return SJE.CalcularLucroEListarVendasMesEspecifico(mes, vendas);
        }
        public static (float lucro, List<Venda> vendas) ListarVendasECalcularLucroDesenvolvedoraMesEspecifico(string nomeDesenvolvedora, int mes)
        {
            return SJE.ListarVendasECalcularLucroDesenvolvedoraMesEspecifico(nomeDesenvolvedora, mes);
        }
        public static List<Venda> ListarVendasComFormaPagamentoBoleto(List<Venda> vendas)
        {
            return SJE.ListarVendasComFormaPagamentoBoleto(vendas);
        }
        public static List<Venda> ListarVendasComFormaPagamentoCartaoCredito(List<Venda> vendas)
        {
            return SJE.ListarVendasComFormaPagamentoCartaoCredito(vendas);
        }
        public static List<Venda> ListarVendasComFormaPagamentoPix(List<Venda> vendas)
        {
            return SJE.ListarVendasComFormaPagamentoPix(vendas);
        }
    }
}
