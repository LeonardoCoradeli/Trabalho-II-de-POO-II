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
            sistemaJogosEletronicos.cadastrarCliente(nome, cpf, rg, dataNascimento, endereco, cep, email, dataCadastro, nivel, clienteEpico);
        }
        public void CadastrarGerente(string nome, string cpf, string rg, DateTime dataNascimento, string endereco, string cep, string email, DateTime dataAdmissao, double salario, string senha)
        {
            sistemaJogosEletronicos.CadastrarGerente(nome, cpf, rg, dataNascimento, endereco, cep, email, dataAdmissao, salario, senha);
        }
        public void CadastrarDesenvolvedora(string nome, string cnpj, string endereco, string cep, string email, DateTime dataCadastro, string telefone)
        {
            sistemaJogosEletronicos.CadastrarDesenvolvedora(nome, cnpj, endereco, cep, email, dataCadastro, telefone);
        }
        public void CadastrarTransportadora(string nome, string cnpj, string endereco, string cep, string email, DateTime dataCadastro, string telefone)
        {
            sistemaJogosEletronicos.CadastrarTransportadora(nome, cnpj, endereco, cep, email, dataCadastro, telefone);
        }
        public void buscarCliente(int codigo)
        {
            sistemaJogosEletronicos.buscarCliente(codigo);
        }
        public void buscarGerente(int codigo)
        {
            sistemaJogosEletronicos.buscarGerente(codigo);
        }
        public void buscarDesenvolvedora(int codigo)
        {
            sistemaJogosEletronicos.buscarDesenvolvedora(codigo);
        }
        public void buscarTransportadora(int codigo)
        {
            sistemaJogosEletronicos.buscarTransportadora(codigo);
        }
        public void removerCliente(int codigo)
        {
            sistemaJogosEletronicos.removerCliente(codigo);
        }
        public void removerGerente(int codigo)
        {
            sistemaJogosEletronicos.removerGerente(codigo);
        }
        public void removerDesenvolvedora(int codigo)
        {
            sistemaJogosEletronicos.removerDesenvolvedora(codigo);
        }
        public void removerTransportadora(int codigo)
        {
            sistemaJogosEletronicos.removerTransportadora(codigo);
        }
        public void listarDesenvolvedoras()
        {
            sistemaJogosEletronicos.ListarDesenvolvedorasCadastradas();
        }
        public void listarDesenvolvedorasMaisVendidas()
        {
            sistemaJogosEletronicos.ListarDesenvolvedorasMaisVendidas();
        }
        public void ListarDesenvolvedorasComMaiorLucro()
        {
            sistemaJogosEletronicos.ListarDesenvolvedorasComMaiorLucro();
        }
        public void listarTransportadoras()
        {
            sistemaJogosEletronicos.ListarTransportadorasCadastradas();
        }
        public void listarGerentes()
        {
            sistemaJogosEletronicos.ListarGerentesCadastrados();
        }
        public void listarClientes()
        {
            sistemaJogosEletronicos.ListarClientesCadastrados();
        }
        public void listarClientesEpicos()
        {
            sistemaJogosEletronicos.ListarClientesEpicos();
        }
        public void listarTop10ClientesMaiorNivel()
        {
            sistemaJogosEletronicos.ListarTop10ClientesMaiorNivel();
        }
    }
}
