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
        public string BuscarCliente(int codigo)
        {
            return sistemaJogosEletronicos.BuscarCliente(codigo);
        }
        public string BuscarGerente(int codigo)
        {
            return sistemaJogosEletronicos.BuscarGerente(codigo);
        }
        public string BuscarDesenvolvedora(int codigo)
        {
            return sistemaJogosEletronicos.BuscarDesenvolvedora(codigo);
        }
        public string BuscarTransportadora(int codigo)
        {
            return sistemaJogosEletronicos.BuscarTransportadora(codigo);
        }
        public List<Desenvolvedora> listarDesenvolvedoras()
        {
            return sistemaJogosEletronicos.ListarDesenvolvedorasCadastradas();
        }
        public List<Desenvolvedora> listarDesenvolvedorasMaisVendidos()
        {
            return sistemaJogosEletronicos.ListarDesenvolvedorasMaisVendidos();
        }
        public List<Desenvolvedora> ListarDesenvolvedorasComMaiorLucro()
        {
            return sistemaJogosEletronicos.ListarDesenvolvedorasComMaiorLucro();
        }
        public List<Transportadora> listarTransportadoras()
        {
            return sistemaJogosEletronicos.ListarTodasTransportadoras();
        }
        public List<Usuario> listarGerentes()
        {
            return sistemaJogosEletronicos.ListarGerentesCadastrados();
        }
        public List<Usuario> listarClientes()
        {
            return sistemaJogosEletronicos.ListarClientesCadastrados();
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
