using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_II_de_POO_II.Controllers
{
    public class ControladorVendas
    {
        private SistemaJogosEletronicos sistemaJogosEletronicos;
        public ControladorVendas(SistemaJogosEletronicos sistemaJogosEletronicos)
        {
            this.sistemaJogosEletronicos = sistemaJogosEletronicos;
        }
        public void CadastrarVenda(int codigo, DateTime dataVenda, double valorTotal, int codigoCliente, int codigoGerente, int codigoTransportadora, int codigoDesenvolvedora)
        {
            sistemaJogosEletronicos.CadastrarVenda(codigo, dataVenda, valorTotal, codigoCliente, codigoGerente, codigoTransportadora, codigoDesenvolvedora);
        }
        public void buscarVenda(int codigo)
        {
            sistemaJogosEletronicos.buscarVenda(codigo);
        }
        public void removerVenda(int codigo)
        {
            sistemaJogosEletronicos.removerVenda(codigo);
        }
        public void ListarHistoricoVendasCliente(Usuario cliente)
        {
            sistemaJogosEletronicos.ListarHistoricoVendasCliente(cliente);
        }
        public void ListarTodasVendas()
        {
            sistemaJogosEletronicos.ListarTodasVendas();
        }
        public (decimal, sistemaJogosEletronicos.Vendas) CalcularLucroEListarVendasMesEspecifico(sistemaJogosEeltronicos.Vendas, int mes)
        {
            sistemaJogosEletronicos.CalcularLucroEListarVendasMesEspecifico(sistemaJogosEeltronicos.Vendas, mes);
        }
        public (decimal, sistemaJogosEletronicos.Vendas) ListarVendasECalcularLucroDesenvolvedoraMesEspecifico(string nomeDesenvolvedora, int mes)
        {
            sistemaJogosEletronicos.ListarVendasECalcularLucroDesenvolvedoraMesEspecifico(nomeDesenvolvedora, mes);
        }
        public sistemaJogosEletronicos.Vendas ListarVendasComFormaPagamentoBoleto(sistemasJogosEletronicos.Vendas)
        {
            sistemaJogosEletronicos.ListarVendasComFormaPagamentoBoleto(sistemasJogosEletronicos.Vendas);
        }
        public sistemaJogosEletronicos.Vendas ListarVendasComFormaPagamentoCartaoCredito(sistemasJogosEletronicos.Vendas)
        {
            sistemaJogosEletronicos.ListarVendasComFormaPagamentoCartaoCredito(sistemasJogosEletronicos.Vendas);
        }
        public sistemaJogosEeltronicos.Vendas ListarVendasComFormaPagamentoPix(sistemasJogosEletronicos.Vendas)
        {
            sistemaJogosEletronicos.ListarVendasComFormaPagamentoPix(sistemasJogosEletronicos.Vendas);
        }
    }
}
