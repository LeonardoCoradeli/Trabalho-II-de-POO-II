using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trabalho_II_de_POO_II.GUI;

namespace Trabalho_II_de_POO_II.Controllers
{
    public class ControladorUsuario
    {
        private SistemaJogosEletronicos sistemaJogosEletronicos;
        public ControladorUsuario(SistemaJogosEletronicos sistemaJogosEletronicos)
        {
            this.sistemaJogosEletronicos = sistemaJogosEletronicos;
        }
        public void CadastrarCliente(string nome, string cpf, string rg, DateTime dataNascimento, string endereco, string cep, string email, DateTime dataCadastro, int nivel, bool clienteEpico)
        {
            sistemaJogosEletronicos.CadastrarCliente(nome, cpf, rg, dataNascimento, endereco, cep, email, dataCadastro, nivel, clienteEpico);
        }
        public void CadastrarGerente(string nome, string cpf, string rg, DateTime dataNascimento, string endereco, string cep, string email, double salario, string cargo, DateTime dataContratacao)
        {
            sistemaJogosEletronicos.CadastrarGerente(nome, cpf, rg, dataNascimento, endereco, cep, email, salario, cargo, dataContratacao);
        }
        public void CadastrarDesenvolvedora(string nome, string cnpj, string endereco, string cep, string email, DateTime dataCadastro, string telefone)
        {
            CadastrarDesenvolvedora(nome, cnpj, endereco, cep, email, dataCadastro, telefone);
        }
        public void CadastrarTransportadora(string nome, string cnpj, string endereco, string cep, string email, DateTime dataCadastro, string telefone)
        {
            CadastrarTransportadora(nome, cnpj, endereco, cep, email, dataCadastro, telefone);
        }
        public void BuscarCliente(int codigo)
        {
            sistemaJogosEletronicos.BuscarCliente(codigo);
        }
        public void BuscarGerente(int codigo)
        {
            sistemaJogosEletronicos.BuscarGerente(codigo);
        }
        public void BuscarDesenvolvedora(int codigo)
        {
            sistemaJogosEletronicos.BuscarDesenvolvedora(codigo);
        }
        public void BuscarTransportadora(int codigo)
        {
            sistemaJogosEletronicos.BuscarTransportadora(codigo);
        }
        public void listarDesenvolvedoras()
        {
            sistemaJogosEletronicos.ListarDesenvolvedorasCadastradas();
        }
        public void listarDesenvolvedorasMaisVendidos()
        {
            sistemaJogosEletronicos.ListarDesenvolvedorasMaisVendidos();
        }
        public void ListarDesenvolvedorasComMaiorLucro()
        {
            sistemaJogosEletronicos.ListarDesenvolvedorasComMaiorLucro();
        }
        public void listarTransportadoras()
        {
            sistemaJogosEletronicos.ListarTodasTransportadoras();
        }
        public void listarGerentes()
        {
            sistemaJogosEletronicos.ListarGerentesCadastrados();
        }
        public void listarClientes()
        {
            sistemaJogosEletronicos.ListarClientesCadastrados();
        }
        public List<Cliente> listarClientesEpicos(List<Cliente> clientes)
        {
            return sistemaJogosEletronicos.ListarClientesEpicos(clientes);
        }
        public List<Cliente> listarTop10ClientesMaiorNivel(List<Cliente> clientes)
        {
            return sistemaJogosEletronicos.ListarTop10ClientesMaiorNivel(clientes);
        }
    }
}
