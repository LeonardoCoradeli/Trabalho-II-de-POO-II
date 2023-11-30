using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trabalho_II_de_POO_II.Models;

namespace Trabalho_II_de_POO_II.GUI
{
    public class SistemaJogosEletronicos
    {
        public string NomePlataforma { get; set; }
        public List<Venda> Vendas { get; set; }
        public List<IJogo> Jogos { get; set; }
        public List<Desenvolvedora> Desenvolvedoras { get; set; }
        public List<Transportadora> Transportadoras { get; set; }
        public List<Cliente> Clientes { get; set; }
        public List<Gerente> Gerentes { get; set; }
        public BancoDeDados BD { get; set; }
        public List<IJogo> ListarTodosJogos()
        {
            return Jogos;
        }

        public List<Jogo> ListarJogosPorTipo(List<Jogo> jogos, Type tipo)
        {
            List<Jogo> jogosFiltrados = new List<Jogo>();

            foreach (Jogo jogo in jogos)
            {
                if (jogo.Tipo == tipo)
                {
                    jogosFiltrados.Add(jogo);
                }
            }

            return jogosFiltrados;
        }


        public List<Jogo> ListarTop10JogosMaisCaros(List<Jogo> jogos)
        {
            List<Jogo> top10JogosMaisCaros = jogos.OrderByDescending(jogo => jogo.CalcularValor()).Take(10).ToList();
            return top10JogosMaisCaros;
        }
        public List<Jogo> ListarTop10JogosMenorPreco(List<Jogo> jogos)
        {
            List<Jogo> top10JogosMenorPreco = jogos.OrderBy(jogo => jogo.CalcularValor()).Take(10).ToList();
            return top10JogosMenorPreco;
        }
        public List<string> ListarNomesOrdenadosPorAvaliacao1(List<Jogo> jogos)
        {
            ContextoOrganizacao contexto = new ContextoOrganizacao(new MetodoOrganizacao1());
            List <Jogo> jogosOrdenados = contexto.Organizar(jogos);
            List<string> nomesOrdenados = jogosOrdenados.Select(jogo => jogo.Nome).ToList();
            //Ver se vai realmente precisar so do nome
            return nomesOrdenados;
        }
        public List<string> ListarNomesOrdenadosPorAvaliacao2(List<Jogo> jogos)
        {
            ContextoOrganizacao contexto = new ContextoOrganizacao(new MetodoOrganizacao2());
            List<Jogo> jogosOrdenados = contexto.Organizar(jogos);
            List<string> nomesOrdenados = jogosOrdenados.Select(jogo => jogo.Nome).ToList();
            //Ver se vai realmente precisar so do nome
            return nomesOrdenados;
        }
        public List<Desenvolvedora> ListarDesenvolvedorasCadastradas()
        {
            return Desenvolvedoras;
        }

        public List<Desenvolvedora> ListarDesenvolvedorasMaisVendidos()
        {
            var desenvolvedorasMaisVendidos = Jogos
                .GroupBy(jogo => jogo.Desenvolvedora)
                .OrderByDescending(grupo => grupo.Count())
                .Select(grupo => grupo.Key)
                .ToList();

            return desenvolvedorasMaisVendidos;
        }

        public List<Desenvolvedora> ListarDesenvolvedorasComMaiorLucro()
        {
            var desenvolvedorasComMaiorLucro = Jogos
                .GroupBy(jogo => jogo.Desenvolvedora)
                .Select(grupo => new
                {
                    Desenvolvedora = grupo.Key,
                    Lucro = grupo.Sum(jogo => jogo.CalcularValor())
                })
                .OrderByDescending(item => item.Lucro)
                .Select(item => item.Desenvolvedora)
                .ToList();

            return desenvolvedorasComMaiorLucro;
        }
        public List<Transportadora> ListarTodasTransportadoras()
        {
            return Transportadoras;
        }
        public List<Gerente> ListarGerentesCadastrados()
        {
            return Gerentes;
        }
        public List<Cliente> ListarClientesCadastrados()
        {
            return Clientes;
        }
        public List<ICliente> ListarClientesEpicos(List<ICliente> clientes)
        {
            List<ICliente> clientesEpicos = clientes.Where(cliente => cliente.ClienteEpico).ToList();
            return clientesEpicos;
        }
        public List<ICliente> ListarTop10ClientesMaiorNivel(List<ICliente> clientes)
        {
            List<ICliente> top10ClientesMaiorNivel = clientes.OrderByDescending(cliente => cliente.Nivel).Take(10).ToList();
            return top10ClientesMaiorNivel;
        }
        public List<Venda> ListarHistoricoVendasCliente(Usuario cliente)
        {
            List<Venda> historicoVendas = Vendas.Where(venda => venda.Cliente == cliente).ToList();
            return historicoVendas;
        }
        public List<Venda> ListarTodasVendas()
        {
            return Vendas;
        }
        public (decimal, List<Venda>) CalcularLucroEListarVendasMesEspecifico(List<Venda> vendas, int mes)
        {
            List<Venda> vendasMesEspecifico = vendas.Where(venda => venda.Data.Month == mes).ToList();
            decimal lucroMesEspecifico = vendasMesEspecifico.Sum(venda => venda.Lucro);
            return (lucroMesEspecifico, vendasMesEspecifico);
        }
        public (decimal, List<Venda>) ListarVendasECalcularLucroDesenvolvedoraMesEspecifico(string nomeDesenvolvedora, int mes)
        {
            List<Venda> vendasDesenvolvedoraMesEspecifico = Vendas.Where(venda => venda.Desenvolvedora == nomeDesenvolvedora && venda.Data.Month == mes).ToList();
            decimal lucroDesenvolvedoraMesEspecifico = vendasDesenvolvedoraMesEspecifico.Sum(venda => venda.Lucro);
            return (lucroDesenvolvedoraMesEspecifico, vendasDesenvolvedoraMesEspecifico);
        }
        public List<Venda> ListarVendasComFormaPagamentoBoleto(List<Venda> vendas)
        {
            List<Venda> vendasComFormaPagamentoBoleto = vendas.Where(venda => venda.FormaPagamento is Boleto).ToList();
            return vendasComFormaPagamentoBoleto;
        }
        public List<Venda> ListarVendasComFormaPagamentoCartaoCredito(List<Venda> vendas)
        {
            List<Venda> vendasComFormaPagamentoCartaoCredito = vendas.Where(venda => venda.FormaPagamento is CartaoCredito).ToList();
            return vendasComFormaPagamentoCartaoCredito;
        }

        public List<Venda> ListarVendasComFormaPagamentoPix(List<Venda> vendas)
        {
            List<Venda> vendasComFormaPagamentoPix = vendas.Where(venda => venda.FormaPagamento is Pix).ToList();
            return vendasComFormaPagamentoPix;
        }
    }
    public void cadastrarCliente(string nome, string cpf, string rg, DateTime dataNascimento, string endereco, string cep, string email, DateTime dataCadastro, int nivel, bool clienteEpico)
    {
        Cliente cliente = new Cliente(nome, cpf, rg, dataNascimento, endereco, cep, email, dataCadastro, nivel, clienteEpico);
        sistemaJogosEletronicos.Clientes.Add(cliente);
    }
    public void CadastrarGerente(string nome, string cpf, string rg, DateTime dataNascimento, string endereco, string cep, string email, DateTime dataContratacao, double salario, string cargo)
    {
        Gerente gerente = new Gerente(nome, cpf, rg, dataNascimento, endereco, cep, email, dataContratacao, salario, cargo);
        sistemaJogosEletronicos.Gerentes.Add(gerente);
    }
    public void CadastrarDesenvolvedora(string nome, string cnpj, string endereco, string cep, string email, string telefone)
    {
        Desenvolvedora desenvolvedora = new Desenvolvedora(nome, cnpj, endereco, cep, email, telefone);
        sistemaJogosEletronicos.Desenvolvedoras.Add(desenvolvedora);
    }
    public void CadastrarTransportadora(string nome, string cnpj, string endereco, string cep, string email, string telefone)
    {
        Transportadora transportadora = new Transportadora(nome, cnpj, endereco, cep, email, telefone);
        sistemaJogosEletronicos.Transportadoras.Add(transportadora);
    }
    public void CadastrarJogo(string nome, string categoria, string descricao, string desenvolvedora, double preco, int quantidade, int codigo)
    {
        Jogo jogo = new Jogo(nome, categoria, descricao, desenvolvedora, preco, quantidade, codigo);
        sistemaJogosEletronicos.Jogos.Add(jogo);
    }
    public void BuscarCliente(int codigo)
    {
        foreach (Cliente cliente in sistemaJogosEletronicos.Clientes)
        {
            if (cliente.Codigo == codigo)
            {
                string clienteString = cliente.ToString();
                return clienteString;
            }
        }
    }
    public void BuscarGerente(int codigo)
    {
        foreach (Gerente gerente in sistemaJogosEletronicos.Gerentes)
        {
            if (gerente.Codigo == codigo)
            {
                string gerenteString = gerente.ToString();
                return gerenteString;
            }
        }
    }
    public void BuscarDesenvolvedora(int codigo)
    {
        foreach (Desenvolvedora desenvolvedora in sistemaJogosEletronicos.Desenvolvedoras)
        {
            if (desenvolvedora.Codigo == codigo)
            {
                string desenvolvedoraString = desenvolvedora.ToString();
                return desenvolvedoraString;
            }
        }
    }
    public void BuscarTransportadora(int codigo)
    {
        foreach (Transportadora transportadora in sistemaJogosEletronicos.Transportadoras)
        {
            if (transportadora.Codigo == codigo)
            {
                string transportadoraString = transportadora.ToString();
                return transportadoraString;
            }
        }
    }
    public void BuscarJogo(int codigo)
    {
        foreach (Jogo jogo in sistemaJogosEletronicos.Jogos)
        {
            if (jogo.Codigo == codigo)
            {
                string jogoString = jogo.ToString();
                return jogoString;
            }
        }
    }
    public void RemoverCliente(int codigo)
    {
        foreach (Cliente cliente in sistemaJogosEletronicos.Clientes)
        {
            if (cliente.Codigo == codigo)
            {
                sistemaJogosEletronicos.Clientes.Remove(cliente);
            }
        }
    }
    public void RemoverGerente(int codigo)
    {
        foreach (Gerente gerente in sistemaJogosEletronicos.Gerentes)
        {
            if (gerente.Codigo == codigo)
            {
                sistemaJogosEletronicos.Gerentes.Remove(gerente);
            }
        }
    }
    public void RemoverDesenvolvedora(int codigo)
    {
        foreach (Desenvolvedora desenvolvedora in sistemaJogosEletronicos.Desenvolvedoras)
        {
            if (desenvolvedora.Codigo == codigo)
            {
                sistemaJogosEletronicos.Desenvolvedoras.Remove(desenvolvedora);
            }
        }
    }
    public void RemoverTransportadora(int codigo)
    {
        foreach (Transportadora transportadora in sistemaJogosEletronicos.Transportadoras)
        {
            if (transportadora.Codigo == codigo)
            {
                sistemaJogosEletronicos.Transportadoras.Remove(transportadora);
            }
        }
    }
    public void RemoverJogo(int codigo)
    {
        foreach (Jogo jogo in sistemaJogosEletronicos.Jogos)
        {
            if (jogo.Codigo == codigo)
            {
                sistemaJogosEletronicos.Jogos.Remove(jogo);
            }
        }
    }
    public void CadastrarVenda(string nomeCliente, string nomeDesenvolvedora, string nomeTransportadora, string nomeJogo, string formaPagamento, int quantidade, DateTime data)
    {
        Usuario cliente = sistemaJogosEletronicos.Clientes.Find(cliente => cliente.Nome == nomeCliente);
        Desenvolvedora desenvolvedora = sistemaJogosEletronicos.Desenvolvedoras.Find(desenvolvedora => desenvolvedora.Nome == nomeDesenvolvedora);
        Transportadora transportadora = sistemaJogosEletronicos.Transportadoras.Find(transportadora => transportadora.Nome == nomeTransportadora);
        Jogo jogo = sistemaJogosEletronicos.Jogos.Find(jogo => jogo.Nome == nomeJogo);
        FormaPagamento formaPagamento = null;

        if (formaPagamento == "Boleto")
        {
            formaPagamento = new Boleto();
        }
        else if (formaPagamento == "CartaoCredito")
        {
            formaPagamento = new CartaoCredito();
        }
        else if (formaPagamento == "Pix")
        {
            formaPagamento = new Pix();
        }

        Venda venda = new Venda(cliente, desenvolvedora, transportadora, jogo, formaPagamento, quantidade, data);
        sistemaJogosEletronicos.Vendas.Add(venda);
    }
    public void buscarVenda(int codigo)
    {
        foreach (Venda venda in sistemaJogosEletronicos.Vendas)
        {
            if (venda.Codigo == codigo)
            {
                string vendaString = venda.ToString();
                return vendaString;
            }
        }
    }
    public void removerVenda(int codigo)
    {
        foreach (Venda venda in sistemaJogosEletronicos.Vendas)
        {
            if (venda.Codigo == codigo)
            {
                sistemaJogosEletronicos.Vendas.Remove(venda);
            }
        }
    }
}
