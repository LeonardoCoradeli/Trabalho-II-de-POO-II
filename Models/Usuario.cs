using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_II_de_POO_II.GUI
{
 
    [Serializable]
    public abstract class Usuario
    {
        public int Codigo { get; protected set; }
        protected string Nome { get; set; }
        protected string CPF { get; set; }
        protected string RG { get; set; }
        protected DateTime DataNascimento { get; set; }
        protected string Endereco { get; set; }
        protected string Cep { get; set; }
        protected string Email { get; set; }


        public Usuario() { }

        public Usuario(int codigo, string nome, string cpf, string rg, DateTime dataNascimento, string endereco, string cep, string email)
        {
            Codigo = codigo;
            Nome = nome;
            CPF = cpf;
            RG = rg;
            DataNascimento = dataNascimento;
            Endereco = endereco;
            Cep = cep;
            Email = email;
        }

        public override string ToString()
        {
            return $"Usuario: {Nome}, CPF: {CPF}, RG: {RG}, Data de Nascimento: {DataNascimento}, Endereço: {Endereco}, CEP: {Cep}, Email: {Email}";
        }
    }

    [Serializable]
    public class Cliente : Usuario
    {
        protected DateTime DataCadastro { get; set; }
        public float Nivel { get; protected set; }
        public bool ClienteEpico {  get; protected set; }


        public Cliente() { }

        public Cliente(int codigo,string nome, string cpf, string rg, DateTime dataNascimento, string endereco, string cep, string email, DateTime dataCadastro, double nivel, bool clienteEpico)
        : base((codigo == -1)? NumAleatorio.Gerar<Cliente>(): codigo, nome, cpf, rg, dataNascimento, endereco, cep, email)
        {
            DataCadastro = dataCadastro;
            Nivel = (float)nivel;
            ClienteEpico = clienteEpico;
        }

        public override string ToString()
        {
            return $"Data de Cadastro: {DataCadastro}, Nível: {Nivel}, Cliente Épico: {ClienteEpico}";
        }
    }

    [Serializable]
    public class Gerente : Usuario
        {
            protected float Salario { get; set; }
            protected string Pis { get; set; }
            protected DateTime DataAdmissao { get; set; }

            public Gerente() { }

            public Gerente(int codigo,string nome, string cpf, string rg, DateTime dataNascimento, string endereco, string cep, string email, double salario, string pis, DateTime dataAdmissao)
                : base((codigo == -1)? NumAleatorio.Gerar<Gerente>(): codigo, nome, cpf, rg, dataNascimento, endereco, cep, email)
            {
                Salario = (float)salario;
                Pis = pis;
                DataAdmissao = dataAdmissao;
            }

            public override string ToString()
            {
                return $"Gerente: {Nome}, CPF: {CPF}, RG: {RG}, Data de Nascimento: {DataNascimento}, Endereço: {Endereco}, CEP: {Cep}, Email: {Email}, Salario: {Salario}, PIS: {Pis}, Data de Admissão: {DataAdmissao}";
            }
        }

}
