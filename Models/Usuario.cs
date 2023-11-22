using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_II_de_POO_II.GUI
{
    public abstract class Usuario
    {
        protected int Codigo { get; set; }
        protected string Nome { get; set; }
        protected string Cpf { get; set; }
        protected string Rg { get; set; }
        protected DateTime DataNascimento { get; set; }
        protected string Endereco { get; set; }
        protected string Cep { get; set; }
        protected string Email { get; set; }

        public Usuario() { }

        public Usuario(int codigo, string nome, string cpf, string rg, DateTime dataNascimento, string endereco, string cep, string email)
        {
            Codigo = codigo;
            Nome = nome;
            Cpf = cpf;
            Rg = rg;
            DataNascimento = dataNascimento;
            Endereco = endereco;
            Cep = cep;
            Email = email;
        }

        public override string ToString()
        {
            return $"Usuario: {Nome}, CPF: {Cpf}, RG: {Rg}, Data de Nascimento: {DataNascimento}, Endereço: {Endereco}, CEP: {Cep}, Email: {Email}";
        }
    }
    public class Cliente : Usuario
    {
        protected DateTime DataCadastro { get; set; }
        protected int Nivel { get; set; }
        protected bool ClienteEpico { get; set; }

        public Cliente() { }

        public Cliente(int codigo, string nome, string cpf, string rg, DateTime dataNascimento, string endereco, string cep, string email, DateTime dataCadastro, int nivel, bool clienteEpico)
        : base(codigo, nome, cpf, rg, dataNascimento, endereco, cep, email)
        {
            DataCadastro = dataCadastro;
            Nivel = nivel;
            ClienteEpico = clienteEpico;
        }

        public override string ToString()
        {
            return $"Data de Cadastro: {DataCadastro}, Nível: {Nivel}, Cliente Épico: {ClienteEpico}";
        }
    }


    public class Gerente : Usuario
        {
            protected float Salario { get; set; }
            protected string Pis { get; set; }
            protected DateTime DataAdmissao { get; set; }

            public Gerente() { }

            public Gerente(int codigo, string nome, string cpf, string rg, DateTime dataNascimento, string endereco, string cep, string email, float salario, string pis, DateTime dataAdmissao)
                : base(codigo, nome, cpf, rg, dataNascimento, endereco, cep, email)
            {
                Salario = salario;
                Pis = pis;
                DataAdmissao = dataAdmissao;
            }

            public override string ToString()
            {
                return $"Gerente: {Nome}, CPF: {Cpf}, RG: {Rg}, Data de Nascimento: {DataNascimento}, Endereço: {Endereco}, CEP: {Cep}, Email: {Email}, Salario: {Salario}, PIS: {Pis}, Data de Admissão: {DataAdmissao}";
            }
        }

}
