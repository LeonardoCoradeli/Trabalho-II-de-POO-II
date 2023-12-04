 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trabalho_II_de_POO_II.GUI;

namespace Trabalho_II_de_POO_II.Controllers
{
    public static class ControladorUsuario
    {
        public static SistemaJogosEletronicos SJE;
        public static void CadastrarCliente(string nome, string cpf, string rg, DateTime dataNascimento, string endereco, string cep, string email, DateTime dataCadastro, int nivel, bool clienteEpico)
        {
            SJE.CadastrarCliente(nome, cpf, rg, dataNascimento, endereco, cep, email, dataCadastro, nivel, clienteEpico);
        }
        public static void CadastrarGerente(string nome, string cpf, string rg, DateTime dataNascimento, string endereco, string cep, string email, double salario, string pis, DateTime dataContratacao)
        {
            SJE.CadastrarGerente(nome, cpf, rg, dataNascimento, endereco, cep, email, salario, pis, dataContratacao);
        }
        public static void CadastrarDesenvolvedora(string cnpj, string nome, string email, string site, string redeSocial, string endereco)
        {
            SJE.CadastrarDesenvolvedora(cnpj, nome, email, site, redeSocial, endereco);
        }
        public static void CadastrarTransportadora(string nome, string cnpj, string endereco, string email, string telefone, int tempo)
        {
            SJE.CadastrarTransportadora(cnpj, nome, email, telefone, endereco, tempo);
        }
        public static string BuscarCliente(int codigo)
        {
            return SJE.BuscarCliente(codigo);
        }
        public static string BuscarGerente(int codigo)
        {
            return SJE.BuscarGerente(codigo);
        }
        public static string BuscarDesenvolvedora(int codigo)
        {
            return SJE.BuscarDesenvolvedora(codigo);
        }
        public static string BuscarTransportadora(int codigo)
        {
            return SJE.BuscarTransportadora(codigo);
        }
        public static List<Desenvolvedora> listarDesenvolvedoras()
        {
            return SJE.ListarDesenvolvedorasCadastradas();
        }
        public static List<Desenvolvedora> listarDesenvolvedorasMaisVendidos()
        {
            return SJE.ListarDesenvolvedorasMaisVendidos();
        }
        public static List<Desenvolvedora> ListarDesenvolvedorasComMaiorLucro()
        {
            return SJE.ListarDesenvolvedorasComMaiorLucro();
        }
        public static List<Transportadora> listarTransportadoras()
        {
            return SJE.ListarTodasTransportadoras();
        }
        public static List<Usuario> listarGerentes()
        {
            return SJE.ListarGerentesCadastrados();
        }
        public static List<Usuario> listarClientes()
        {
            return SJE.ListarClientesCadastrados();
        }
        public static List<Cliente> listarClientesEpicos(List<Cliente> clientes)
        {
            return SJE.ListarClientesEpicos(clientes);
        }
        public static List<Cliente> listarTop10ClientesMaiorNivel(List<Cliente> clientes)
        {
            return SJE.ListarTop10ClientesMaiorNivel(clientes);
        }
        public static string ListarClientesParaTextbox(List<Usuario> clientes)
        {
            StringBuilder sb = new StringBuilder();

            foreach (var cliente in clientes)
            {
                sb.AppendLine(cliente.ToString());
            }

            return sb.ToString();
        }
        public static string ListarDesenvolvedorasParaTextbox(List<Desenvolvedora> desenvolvedoras)
        {
            StringBuilder sb = new StringBuilder();

            foreach (var desenvolvedora in desenvolvedoras)
            {
                sb.AppendLine(desenvolvedora.ToString());
            }

            return sb.ToString();
        }
        public static string ListarDesenvolvedorasMaisVendidosParaTextbox(List<Desenvolvedora> desenvolvedoras)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var desenvolvedora in SJE.ListarDesenvolvedorasMaisVendidos())
            {
                sb.AppendLine(desenvolvedora.ToString());
            }
            return sb.ToString();
        }

        public static string ListarDesenvolvedorasMaiorLucro(List<Desenvolvedora> desenvolvedoras)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var desenvolvedora in SJE.ListarDesenvolvedorasComMaiorLucro())
            {
                sb.AppendLine(desenvolvedora.ToString());
            }
            return sb.ToString();
        }

        public static string ListarTransportadorasParaTextbox(List<Transportadora> transportadoras)
        {
            StringBuilder sb = new StringBuilder();

            foreach (var transportadora in transportadoras)
            {
                sb.AppendLine(transportadora.ToString());
            }

            return sb.ToString();
        }

        public static string ListarGerentesParaTextbox(List<Usuario> gerentes)
        {
            StringBuilder sb = new StringBuilder();

            foreach (var gerente in gerentes)
            {
                sb.AppendLine(gerente.ToString());
            }

            return sb.ToString();
        }

        public static string ListarClientesEpicosParaTextbox(List<Cliente> clientes)
        {
            StringBuilder sb = new StringBuilder();

            foreach (var cliente in SJE.ListarClientesEpicos(clientes))
            {
                sb.AppendLine(cliente.ToString());
            }

            return sb.ToString();
        }

        public static List<Cliente> TransformarUsuariosEmClientes(List<Usuario> usuarios)
        {
            return SJE.TransformarUsuariosEmClientes(usuarios);
        }

        public static string ListarClientesMaiorNivelParaTextbox(List<Cliente> clientes)
        {
            StringBuilder sb = new StringBuilder();

            foreach (var cliente in SJE.ListarTop10ClientesMaiorNivel(clientes))
            {
                sb.AppendLine(cliente.ToString());
            }

            return sb.ToString();
        }
    }
}
