using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trabalho_II_de_POO_II.GUI;

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
        public (decimal, sistemaJogosEletronicos.Vendas) CalcularLucroEListarVendasMesEspecifico(List<Venda> vendas, int mes)
        {
            sistemaJogosEletronicos.CalcularLucroEListarVendasMesEspecifico(sistemaJogosEeltronicos.Vendas, mes);
        }
        public (decimal, sistemaJogosEletronicos.Vendas) ListarVendasECalcularLucroDesenvolvedoraMesEspecifico(string nomeDesenvolvedora, int mes)
        {
            sistemaJogosEletronicos.ListarVendasECalcularLucroDesenvolvedoraMesEspecifico(nomeDesenvolvedora, mes);
        }
        public List<Venda> ListarVendasComFormaPagamentoBoleto(List<Venda> vendas)
        {
            return sistemaJogosEletronicos.ListarVendasComFormaPagamentoBoleto(sistemasJogosEletronicos.Vendas);
        }
        public List<Venda> ListarVendasComFormaPagamentoCartaoCredito(List<Venda> vendas)
        {
            return sistemaJogosEletronicos.ListarVendasComFormaPagamentoCartaoCredito(sistemasJogosEletronicos.Vendas);
        }
        public List<Venda> ListarVendasComFormaPagamentoPix(List<Venda> vendas)
        {
            return sistemaJogosEletronicos.ListarVendasComFormaPagamentoPix(sistemasJogosEletronicos.Vendas);
        }
    }
}
