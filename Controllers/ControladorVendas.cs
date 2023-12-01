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
        public void CadastrarVenda(int codCliente, int codGerente, DateTime dataVenda, List<ItemVenda> itensVenda, Pagamento formaPagamento, Transportadora transportadora = null)
        {
            sistemaJogosEletronicos.CadastrarVenda(codCliente, codGerente, dataVenda, itensVenda, formaPagamento, transportadora);
        }
        public string buscarVenda(int codigo)
        {
            return sistemaJogosEletronicos.buscarVenda(codigo);
        }
        public List<Venda> ListarHistoricoVendasCliente(Usuario cliente)
        {
            return sistemaJogosEletronicos.ListarHistoricoVendasCliente(cliente);
        }
        public List<Venda> ListarTodasVendas()
        {
            return sistemaJogosEletronicos.ListarTodasVendas();
        }
        public (float lucro, List<Venda>) CalcularLucroEListarVendasMesEspecifico(int mes, List<Venda> vendas)
        {
            return sistemaJogosEletronicos.CalcularLucroEListarVendasMesEspecifico(mes, vendas);
        }
        public (float lucro, List<Venda> vendas) ListarVendasECalcularLucroDesenvolvedoraMesEspecifico(string nomeDesenvolvedora, int mes)
        {
            return sistemaJogosEletronicos.ListarVendasECalcularLucroDesenvolvedoraMesEspecifico(nomeDesenvolvedora, mes);
        }
        public List<Venda> ListarVendasComFormaPagamentoBoleto(List<Venda> vendas)
        {
            return sistemaJogosEletronicos.ListarVendasComFormaPagamentoBoleto(vendas);
        }
        public List<Venda> ListarVendasComFormaPagamentoCartaoCredito(List<Venda> vendas)
        {
            return sistemaJogosEletronicos.ListarVendasComFormaPagamentoCartaoCredito(vendas);
        }
        public List<Venda> ListarVendasComFormaPagamentoPix(List<Venda> vendas)
        {
            return sistemaJogosEletronicos.ListarVendasComFormaPagamentoPix(vendas);
        }
    }
}
