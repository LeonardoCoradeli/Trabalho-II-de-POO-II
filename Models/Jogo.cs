using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_II_de_POO_II.GUI
{
    
    public interface IJogo
    {

        float CalcularValor();

    }

    [Serializable]
    public abstract class Jogo : IJogo
    {
        public int Codigo { get; protected set; }
        public string Nome { get; protected set; }
        public string Descricao { get; protected set; }
        public  Desenvolvedora Desenvolvedora { get; protected set; }
        public DateTime DataLancamento { get; protected set; }
        public float Valor { get; protected set; }
        public string RequisitosMinimos { get; protected set; }
        public float Avaliacao { get; protected set; }
        public string Comentarios { get; protected set; }
        public bool Disponivel { get; protected set; }
        public string Tipo { get; protected set; }


        public Jogo(){ }

        protected Jogo(int codigo, string nome, string descricao, Desenvolvedora desenvolvedora, DateTime dataLancamento, float valor, string requisitosMinimos, float avaliacao, string comentarios, bool disponivel, string tipo)
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

        public float AtualizarAvaliacao(int avaliacao)
        {
            Avaliacao = avaliacao;
            return Avaliacao;
        }
        public string AtualizarComentarios(string comentarios)
        {
            Comentarios = comentarios;
            return Comentarios;
        }

        public bool EstaDisponivel()
        {
            return Disponivel;
        }
        public void tornarIndisponivel()
        {
            Disponivel = false;
        }

        public override string ToString()
        {
            return $"Jogo: {Nome}, Descrição: {Descricao}, Desenvolvedora: {Desenvolvedora.Nome}, Data de Lançamento: {DataLancamento}, Valor: {Valor}, Requisitos Mínimos: {RequisitosMinimos}, Avaliação: {Avaliacao}, Comentários: {Comentarios}, Disponível: {Disponivel}";
        }
    }

    [Serializable]
    public class Acao : Jogo
    {
        public Acao() { }

        public Acao(int codigo, string nome, string descricao, Desenvolvedora desenvolvedora, DateTime dataLancamento, float valor, string requisitosMinimos, float avaliacao, string comentarios, bool disponivel,string tipo)
            : base(codigo, nome, descricao, desenvolvedora, dataLancamento, valor, requisitosMinimos, avaliacao, comentarios, disponivel,tipo)
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

    [Serializable]
    public class Aventura : Jogo
    {
        public Aventura() { }

        public Aventura(int codigo, string nome, string descricao, Desenvolvedora desenvolvedora, DateTime dataLancamento, float valor, string requisitosMinimos, float avaliacao, string comentarios, bool disponivel, string tipo)
            : base(codigo, nome, descricao, desenvolvedora, dataLancamento, valor, requisitosMinimos, avaliacao, comentarios, disponivel,tipo)
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

    [Serializable]
    public class RPG : Jogo
    {
        public RPG() { }

        public RPG(int codigo, string nome, string descricao, Desenvolvedora desenvolvedora, DateTime dataLancamento, float valor, string requisitosMinimos, float avaliacao, string comentarios, bool disponivel, string tipo) 
            : base(codigo, nome, descricao, desenvolvedora, dataLancamento, valor, requisitosMinimos, avaliacao, comentarios, disponivel,tipo)
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

    [Serializable]
    public class Esporte : Jogo
    {
        public Esporte() { }

        public Esporte(int codigo, string nome, string descricao, Desenvolvedora desenvolvedora, DateTime dataLancamento, float valor, string requisitosMinimos, float avaliacao, string comentarios, bool disponivel, string tipo)
            : base(codigo, nome, descricao, desenvolvedora, dataLancamento, valor, requisitosMinimos, avaliacao, comentarios, disponivel,tipo)
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

    [Serializable]
    public class Corrida : Jogo
    {
        public Corrida() { }

        public Corrida(int codigo, string nome, string descricao, Desenvolvedora desenvolvedora, DateTime dataLancamento, float valor, string requisitosMinimos, float avaliacao, string comentarios, bool disponivel, string tipo)
            : base(codigo, nome, descricao, desenvolvedora, dataLancamento, valor, requisitosMinimos, avaliacao, comentarios, disponivel,tipo)
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
