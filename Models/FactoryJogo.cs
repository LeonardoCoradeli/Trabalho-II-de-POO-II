using System;
using System.Collections.Generic;

namespace Trabalho_II_de_POO_II.GUI
{
    public static class FactoryJogo
    {

        public static Jogo CreateJogo(string tipo, string nome, string descricao, Desenvolvedora desenvolvedora, DateTime dataLancamento, double valor, string requesitosminimos, double avaliacao, string comentarios, bool disponivel)
        {
            //gera um código aleatório para cada jogo criado
            int codigo = NumAleatorio.Gerar<Jogo>();
            switch (tipo)
            {
                case "Ação":
                    return new Acao(codigo,nome, descricao, desenvolvedora, dataLancamento, (float)valor, requesitosminimos, (float)avaliacao, comentarios, disponivel,typeof(Acao));
                case "Aventura":
                    return new Aventura(codigo, nome, descricao, desenvolvedora, dataLancamento, (float)valor, requesitosminimos, (float)avaliacao, comentarios, disponivel, typeof(Aventura));
                case "RPG":
                    return new RPG(codigo, nome, descricao, desenvolvedora, dataLancamento, (float)valor, requesitosminimos, (float)avaliacao, comentarios, disponivel, typeof(RPG));
                case "Esporte":
                    return new Esporte(codigo, nome, descricao, desenvolvedora, dataLancamento, (float)valor, requesitosminimos, (float)avaliacao, comentarios, disponivel, typeof(Esporte));
                case "Corrida":
                    return new Corrida(codigo, nome, descricao, desenvolvedora, dataLancamento, (float)valor, requesitosminimos, (float)avaliacao, comentarios, disponivel, typeof(Corrida));
                default:
                    throw new ArgumentException("Tipo de jogo inválido");
            }
        }

    }
}
