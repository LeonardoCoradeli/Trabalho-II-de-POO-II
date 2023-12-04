﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trabalho_II_de_POO_II.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Trabalho_II_de_POO_II.GUI
{
    public class SistemaJogosEletronicos
    {
        public string NomePlataforma { get; set; }
        public List<Venda> Vendas { get; set; }
        public List<Jogo> Jogos { get; set; }
        public List<Desenvolvedora> Desenvolvedoras { get; set; }
        public List<Transportadora> Transportadoras { get; set; }
        public List<Usuario> Clientes { get; set; }
        public List<Usuario> Gerentes { get; set; }
        public Arquivos Arquivo { get; set; }

        public SistemaJogosEletronicos(Arquivos Arq)
        {
            Arquivo = Arq;
            Vendas = Arquivo.RecuperarVendas();
            Jogos = Arquivo.RecuperarJogos();
            Desenvolvedoras = Arquivo.RecuperarDesenvolvedora();
            Transportadoras = Arquivo.RecuperarTransportadoras();
            Clientes = Arquivo.RecuperarClientes();
            Gerentes = Arquivo.RecuperarGerentes();
        }
        public List<Jogo> ListarTodosJogos()
        {
            return Jogos;
        }

        public List<Jogo> ListarJogosPorTipo(string tipo)
        {
            List<Jogo> jogosFiltrados = new List<Jogo>();

            foreach (Jogo jogo in Jogos)
            {
                if (jogo.Tipo == tipo)
                {
                    jogosFiltrados.Add(jogo);
                }
            }

            return jogosFiltrados;
        }


        public List<Jogo> ListarTop10JogosMaisCaros()
        {
            List<Jogo> top10JogosMaisCaros = Jogos.OrderByDescending(jogo => jogo.CalcularValor()).Take(10).ToList();
            return top10JogosMaisCaros;
        }
        public List<Jogo> ListarTop10JogosMenorPreco()
        {
            List<Jogo> top10JogosMenorPreco = Jogos.OrderBy(jogo => jogo.CalcularValor()).Take(10).ToList();
            return top10JogosMenorPreco;
        }
        public List<Jogo> ListarNomesOrdenadosPorAvaliacao1()
        {
            ContextoOrganizacao contexto = new ContextoOrganizacao(new MetodoOrganizacao1());
            List<Jogo> jogosOrdenados = contexto.Organizar(Jogos);
            //Ver se vai realmente precisar so do nome
            return jogosOrdenados;
        }
        public List<Jogo> ListarNomesOrdenadosPorAvaliacao2()
        {
            ContextoOrganizacao contexto = new ContextoOrganizacao(new MetodoOrganizacao2());
            List<Jogo> jogosOrdenados = contexto.Organizar(Jogos);
            return jogosOrdenados;
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
        public List<Usuario> ListarGerentesCadastrados()
        {
            return Gerentes;
        }
        public List<Usuario> ListarClientesCadastrados()
        {
            return Clientes;
        }
        public List<Cliente> ListarClientesEpicos(List<Cliente> clientes)
        {
            List<Cliente> clientesEpicos = clientes.Where(cliente => cliente.ClienteEpico == true).ToList();
            return clientesEpicos;
        }
        public List<Cliente> ListarTop10ClientesMaiorNivel(List<Cliente> clientes)
        {
            List<Cliente> top10ClientesMaiorNivel = clientes.OrderByDescending(cliente => cliente.Nivel).Take(10).ToList();
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
        public (float lucro, List<Venda>) CalcularLucroEListarVendasMesEspecifico(int mes, List<Venda> vendas)
        {
            List<Venda> vendasMesEspecifico = vendas.Where(venda => venda.DataVenda.Month == mes).ToList();
            float lucroMesEspecifico = vendasMesEspecifico.Sum(venda => venda.CalcularValorTotal());
            return (lucroMesEspecifico, vendasMesEspecifico);
        }
        public (float lucro, List<Venda> vendas) ListarVendasECalcularLucroDesenvolvedoraMesEspecifico(string nomeDesenvolvedora, int mes)
        {
            List<Venda> vendasDaDesenvolvedoraNoMes = new List<Venda>();

            foreach (var venda in Vendas)
            {
                foreach (var itemVenda in venda.ItensVenda)
                {
                    if (itemVenda.Jogo.Desenvolvedora.Nome == nomeDesenvolvedora && venda.DataVenda.Month == mes)
                    {
                        vendasDaDesenvolvedoraNoMes.Add(venda);
                    }
                }
            }

            float lucroTotal = vendasDaDesenvolvedoraNoMes.Sum(venda => venda.CalcularValorTotal());

            return (lucroTotal, vendasDaDesenvolvedoraNoMes);
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

        public void CadastrarCliente(string nome, string cpf, string rg, DateTime dataNascimento, string endereco, string cep, string email, DateTime dataCadastro, int nivel, bool clienteEpico)
        {
            Cliente cliente = new Cliente(-1, nome, cpf, rg, dataNascimento, endereco, cep, email, dataCadastro, nivel, clienteEpico);
            Clientes.Add(cliente);
        }
        public void CadastrarGerente(string nome, string cpf, string rg, DateTime dataNascimento, string endereco, string cep, string email, double salario, string pis, DateTime dataContratacao)
        {
            Gerente gerente = new Gerente(-1, nome, cpf, rg, dataNascimento, endereco, cep, email, salario, pis, dataContratacao);
            Gerentes.Add(gerente);
        }
        public void CadastrarDesenvolvedora(string cnpj, string nome, string email, string site, string redeSocial, string endereco)
        {
            Desenvolvedora desenvolvedora = new Desenvolvedora(-1, cnpj, nome, email, site, redeSocial, endereco);
            Desenvolvedoras.Add(desenvolvedora);
        }
        public void CadastrarTransportadora(string cnpj, string nome, string email, string telefone, string endereco, int tempo)
        {
            Transportadora transportadora = new Transportadora(-1, cnpj, nome, email, telefone, endereco, tempo);
            Transportadoras.Add(transportadora);
        }
        public void CadastrarJogo(string nome, string descricao, Desenvolvedora desenvolvedora, DateTime dataLancamento, double valor, string requisitosMinimos, double avaliacao, string comentarios, bool disponivel, string tipo)
        {
            Jogos.Add(FactoryJogo.CreateJogo(-1, nome, descricao, desenvolvedora, dataLancamento, valor, requisitosMinimos, avaliacao, comentarios, disponivel, tipo));
        }
        public string BuscarCliente(int codigo)
        {
            foreach (Cliente cliente in Clientes)
            {
                {
                    if (cliente.Codigo == codigo)
                    {
                        string clienteString = cliente.ToString();
                        return clienteString;
                    }
                }
            }
            return "Não encontrado";
        }
        public string BuscarGerente(int codigo)
        {
            foreach (Gerente gerente in Gerentes)
            {
                if (gerente.Codigo == codigo)
                {
                    string gerenteString = gerente.ToString();
                    return gerenteString;
                }
            }
            return "Não encontrado";
        }
        public string BuscarDesenvolvedora(int codigo)
        {
            foreach (Desenvolvedora desenvolvedora in Desenvolvedoras)
            {
                if (desenvolvedora.Codigo == codigo)
                {
                    string desenvolvedoraString = desenvolvedora.ToString();
                    return desenvolvedoraString;
                }
            }
            return "Não encontrado";
        }
        public string BuscarTransportadora(int codigo)
        {
            foreach (Transportadora transportadora in Transportadoras)
            {
                if (transportadora.Codigo == codigo)
                {
                    string transportadoraString = transportadora.ToString();
                    return transportadoraString;
                }
            }
            return "Não encontrado";
        }
        public string BuscarJogo(int codigo)
        {
            foreach (Jogo jogo in Jogos)
            {
                if (jogo.Codigo == codigo)
                {
                    string jogoString = jogo.ToString();
                    return jogoString;
                }
            }
            return "Não encontrado";
        }
        public void CadastrarVenda(Venda venda)
        {
            Vendas.Add(venda);
        }

        public string buscarVenda(int codigo)
        {
            foreach (Venda venda in Vendas)
            {
                if (venda.Codigo == codigo)
                {
                    string vendaString = venda.ToString();
                    return vendaString;
                }
            }
            return "Não encontrado";
        }

        public void tornarJogoIndisponivel(int codigo)
        {
            foreach (Jogo jogo in Jogos)
            {
                if (jogo.Codigo == codigo)
                {
                    jogo.tornarIndisponivel();
                }
            }
        }
        public void atualizarAvalicao(int codigo, int avaliacao)
        {
            foreach (Jogo jogo in Jogos)
            {
                if (jogo.Codigo == codigo)
                {
                    jogo.AtualizarAvaliacao(avaliacao);
                }
            }
        }
        public void atualizarComentarios(int codigo, string comentarios)
        {
            foreach (Jogo jogo in Jogos)
            {
                if (jogo.Codigo == codigo)
                {
                    jogo.AtualizarComentarios(comentarios);
                }
            }
        }

        public List<Cliente> TransformarUsuariosEmClientes(List<Usuario> usuarios)
        {
            List<Cliente> clientes = new List<Cliente>();

            foreach (var usuario in usuarios)
            {
                Cliente cliente = new Cliente(-1, usuario.Nome, usuario.CPF, usuario.RG, usuario.DataNascimento, usuario.Endereco, usuario.Cep, usuario.Email, DateTime.Now, 0, false);

                clientes.Add(cliente);
            }

            return clientes;
        }
        public List<Venda> ListarTodasVendasDesenvolvedora(Desenvolvedora desenvolvedora)
        {
            List<Venda> vendasDesenvolvedora = new List<Venda>();

            foreach (var venda in Vendas)
            {
                foreach (var itemVenda in venda.ItensVenda)
                {
                    if (itemVenda.Jogo.Desenvolvedora == desenvolvedora)
                    {
                        vendasDesenvolvedora.Add(venda);
                    }
                }
            }

            return vendasDesenvolvedora;
        }
    }
}
