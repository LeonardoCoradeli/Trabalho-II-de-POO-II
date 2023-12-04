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

        public static void CadastrarVenda(Venda vendas)
        {
            SJE.CadastrarVenda(vendas);
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
        public static string ListarCalcularLucroEListarVendasMesEspecificoParaTextBox(int mes, List<Venda> vendas)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Lucro: {CalcularLucroEListarVendasMesEspecifico(mes, vendas).lucro}");
            foreach (Venda venda in CalcularLucroEListarVendasMesEspecifico(mes, vendas).Item2)
            {
                sb.AppendLine(venda.ToString());
            }
            return sb.ToString();

        }

        public static string ListarTodasVendasParaTextBox()
        {
            StringBuilder sb = new StringBuilder();
            foreach (Venda venda in ListarTodasVendas())
            {
                sb.AppendLine(venda.ToString());
            }
            return sb.ToString();
        }

        public static string ListarVendasComFormaPagamentoBoletoParaTextBox()
        {
            StringBuilder sb = new StringBuilder();
            foreach (Venda venda in ListarVendasComFormaPagamentoBoleto(ListarTodasVendas()))
            {
                sb.AppendLine(venda.ToString());
            }
            return sb.ToString();
        }
        public static string ListarVendasComFormaPagamentoCartaoCreditoParaTextBox()
        {
            StringBuilder sb = new StringBuilder();
            foreach (Venda venda in ListarVendasComFormaPagamentoCartaoCredito(ListarTodasVendas()))
            {
                sb.AppendLine(venda.ToString());
            }
            return sb.ToString();
        }
        public static string ListarVendasComFormaPagamentoPixParaTextBox()
        {
            StringBuilder sb = new StringBuilder();
            foreach (Venda venda in ListarVendasComFormaPagamentoPix(ListarTodasVendas()))
            {
                sb.AppendLine(venda.ToString());
            }
            return sb.ToString();
        }

        public static string ListarVendasClienteParaTextBox(Usuario cliente)
        {
            StringBuilder sb = new StringBuilder();
            foreach (Venda venda in ListarHistoricoVendasCliente(cliente))
            {
                sb.AppendLine(venda.ToString());
            }
            return sb.ToString();
        }

        public static string ListarVendasECalcularLucroDesenvolvedoraMesEspecificoParaTextBox(string nomeDesenvolvedora, int mes)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Lucro: {ListarVendasECalcularLucroDesenvolvedoraMesEspecifico(nomeDesenvolvedora, mes).lucro}");
            foreach (Venda venda in ListarVendasECalcularLucroDesenvolvedoraMesEspecifico(nomeDesenvolvedora, mes).vendas)
            {
                sb.AppendLine(venda.ToString());
            }
            return sb.ToString();
        }
        public static List<Venda> ListarVendasDesenvolvedoras(Desenvolvedora desenvolvedora)
        {
            return SJE.ListarTodasVendasDesenvolvedora(desenvolvedora);
        }
        
    }
}
