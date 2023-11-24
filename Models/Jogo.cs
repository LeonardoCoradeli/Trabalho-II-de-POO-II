using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_II_de_POO_II.GUI
{
    //Criar a interface simplesmente para poder criar variaveis do tipo IJogo, vai ser util na factory
    public interface IJogo
    {
        float CalcularValor();
    }

    public abstract class Jogo : IJogo
    {
        protected int Codigo { get; set; }
        public string Nome { get; protected set; }
        protected string Descricao { get; set; }
        protected Desenvolvedora Desenvolvedora { get; set; }
        protected DateTime DataLancamento { get; set; }
        protected float Valor { get; set; }
        protected string RequisitosMinimos { get; set; }
        public float Avaliacao { get; protected set; }
        protected string Comentarios { get; set; }
        protected bool Disponivel { get; set; }
        protected string Tipo { get; set; }

        public Jogo() { }

        protected Jogo(string tipo,int codigo, string nome, string descricao, Desenvolvedora desenvolvedora, DateTime dataLancamento, float valor, string requisitosMinimos, float avaliacao, string comentarios, bool disponivel)
        {
            Codigo = codigo;
            Nome = nome;
            Descricao = descricao;
            Desenvolvedora = desenvolvedora;
            DataLancamento = dataLancamento;
            Valor = valor;
            RequisitosMinimos = requisitosMinimos;
            Avaliacao = avaliacao;
            Comentarios = comentarios;
            Disponivel = disponivel;
            Tipo = tipo;
        }

        public abstract float CalcularValor();

        public float AtualizarAvaliacao()
        {
            // Implement the logic to update the rating here
            return Avaliacao;
        }

        public bool EstaDisponivel()
        {
            return Disponivel;
        }

        public override string ToString()
        {
            return $"Jogo: {Nome}, Descrição: {Descricao}, Desenvolvedora: {Desenvolvedora.Nome}, Data de Lançamento: {DataLancamento}, Valor: {Valor}, Requisitos Mínimos: {RequisitosMinimos}, Avaliação: {Avaliacao}, Comentários: {Comentarios}, Disponível: {Disponivel}";
        }
    }
    public class Acao : Jogo
    {
        public Acao() { }

        public Acao(string tipo, int codigo, string nome, string descricao, Desenvolvedora desenvolvedora, DateTime dataLancamento, float valor, string requisitosMinimos, float avaliacao, string comentarios, bool disponivel)
            : base(tipo, codigo, nome, descricao, desenvolvedora, dataLancamento, valor, requisitosMinimos, avaliacao, comentarios, disponivel)
        {
        }

        public override float CalcularValor()
        {
            // Retorna o valor mais 2.25% do valor
            return Valor * 1.0225f;
        }

        public override string ToString()
        {
            return $"Ação: {Nome}, Descrição: {Descricao}, Desenvolvedora: {Desenvolvedora.Nome}, Data de Lançamento: {DataLancamento}, Valor: {Valor}, Requisitos Mínimos: {RequisitosMinimos}, Avaliação: {Avaliacao}, Comentários: {Comentarios}, Disponível: {Disponivel}";
        }
    }
    public class Aventura : Jogo
    {
        public Aventura() { }

        public Aventura(string tipo, int codigo, string nome, string descricao, Desenvolvedora desenvolvedora, DateTime dataLancamento, float valor, string requisitosMinimos, float avaliacao, string comentarios, bool disponivel)
            : base(tipo, codigo, nome, descricao, desenvolvedora, dataLancamento, valor, requisitosMinimos, avaliacao, comentarios, disponivel)
        {
        }

        public override float CalcularValor()
        {
            // Retorna o valor mais 5.5% do valor
            return Valor * 1.055f;
        }

        public override string ToString()
        {
            return $"Aventura: {Nome}, Descrição: {Descricao}, Desenvolvedora: {Desenvolvedora.Nome}, Data de Lançamento: {DataLancamento}, Valor: {Valor}, Requisitos Mínimos: {RequisitosMinimos}, Avaliação: {Avaliacao}, Comentários: {Comentarios}, Disponível: {Disponivel}";
        }
    }
    public class RPG : Jogo
    {
        public RPG() { }

        public RPG(string tipo, int codigo, string nome, string descricao, Desenvolvedora desenvolvedora, DateTime dataLancamento, float valor, string requisitosMinimos, float avaliacao, string comentarios, bool disponivel) : base(tipo, codigo, nome, descricao, desenvolvedora, dataLancamento, valor, requisitosMinimos, avaliacao, comentarios, disponivel)
        {
        }

        public override float CalcularValor()
        {
            // Retorna o valor mais 3.75% do valor
            return Valor * 1.0375f;
        }

        public override string ToString()
        {
            return $"RPG: {Nome}, Descrição: {Descricao}, Desenvolvedora: {Desenvolvedora.Nome}, Data de Lançamento: {DataLancamento}, Valor: {Valor}, Requisitos Mínimos: {RequisitosMinimos}, Avaliação: {Avaliacao}, Comentários: {Comentarios}, Disponível: {Disponivel}";
        }
    }
    public class Esporte : Jogo
    {
        public Esporte() { }

        public Esporte(string tipo, int codigo, string nome, string descricao, Desenvolvedora desenvolvedora, DateTime dataLancamento, float valor, string requisitosMinimos, float avaliacao, string comentarios, bool disponivel)
            : base(tipo, codigo, nome, descricao, desenvolvedora, dataLancamento, valor, requisitosMinimos, avaliacao, comentarios, disponivel)
        {
        }

        public override float CalcularValor()
        {
            // Retorna o valor mais 0.75% do valor
            return Valor * 1.0075f;
        }

        public override string ToString()
        {
            return $"Esporte: {Nome}, Descrição: {Descricao}, Desenvolvedora: {Desenvolvedora.Nome}, Data de Lançamento: {DataLancamento}, Valor: {Valor}, Requisitos Mínimos: {RequisitosMinimos}, Avaliação: {Avaliacao}, Comentários: {Comentarios}, Disponível: {Disponivel}";
        }
    }
    public class Corrida : Jogo
    {
        public Corrida() { }

        public Corrida(string tipo, int codigo, string nome, string descricao, Desenvolvedora desenvolvedora, DateTime dataLancamento, float valor, string requisitosMinimos, float avaliacao, string comentarios, bool disponivel)
            : base(tipo, codigo, nome, descricao, desenvolvedora, dataLancamento, valor, requisitosMinimos, avaliacao, comentarios, disponivel)
        {
        }

        public override float CalcularValor()
        {
            // Retorna o valor mais 7.25% do valor
            return Valor * 1.0725f;
        }

        public override string ToString()
        {
            return $"Corrida: {Nome}, Descrição: {Descricao}, Desenvolvedora: {Desenvolvedora.Nome}, Data de Lançamento: {DataLancamento}, Valor: {Valor}, Requisitos Mínimos: {RequisitosMinimos}, Avaliação: {Avaliacao}, Comentários: {Comentarios}, Disponível: {Disponivel}";
        }
    }

}
